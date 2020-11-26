import requests
from bs4 import BeautifulSoup
import re


abet_rus = {
    "А": "a",
    "Б": "b",
    "В": "v",
    "Г": "g",
    "Д": "d",
    "Е": "e",
    "Ё": "e",
    "Ж": "j",
    "З": "z",
    "И": "i",
    "Й": "ei",
    "К": "k",
    "Л": "l",
    "М": "m",
    "Н": "n",
    "О": "o",
    "П": "p",
    "Р": "r",
    "С": "s",
    "Т": "t",
    "У": "u",
    "Ф": "f",
    "Х": "h",
    "Ц": "c",
    "Ч": "ch",
    "Ш": "sh",
    "Щ": "sh",
    "Ъ": "",
    "Ы": "e",
    "Ь": "",
    "Э": "e",
    "Ю": "u",
    "Я": "ya",
    "\"": "\"",
    ",": ","
}
# https://namedb.ru/gender/man/ male
# http://analiz-imeni.ru/women/vse-zhenskie-imena.htm female
#
url = "https://audio-class.ru/names/last-names-sortable.php"
r = requests.get(url)

soup = BeautifulSoup(r.text, 'html.parser')
names = soup.find_all('table', 'td', class_="table_sort")
ar = []
f = open('surename.txt', "w")
f.close()
file = open('surename.txt', "a")
for name in names:
    ar.append(str(name))
    for i in ar:
        res = re.findall(r">\w+<", i)
        for j in res:
            j = j.replace(">", "")
            j = j.replace("<", "")
            try:
                if int(j) in range(2000):
                    j = ""
            except:
                pass
            if j != "":
                j = "\"" + j + "\"" + ","
            for k in j:
                if k in abet_rus:
                    if k.isupper():
                        k = abet_rus[k.upper()].upper()
                    else:
                        k = abet_rus[k.upper()]
                file.write(k)
file.close()
