using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public SpritesGeneratorConteiner Bodies;

    //All data about person
    private static string[] genders = { "male", "female" };
    private static string[] maleNames = { "A", "Avgust", "Avgustin", "Avraam", "Agafon", "Adonis", "Akaeio", "Alan", "Aleksandr",
        "Alekseei", "Albert", "Alfred", "Anastasiei", "Anatoliei", "Andreei", "Anisiei", "Anton", "Apollinariei", "Apollon",
        "Aristarh", "Arkadiei", "Arsen", "Arseniei", "Artem", "Artemiei", "Artur", "Arhip", "B", "Benedikt", "Bogdan", "Boleslav",
        "Boris", "Borislav", "Bronislav", "Bulat", "V", "Vadim", "Valentin", "Valeriei", "Vasiliei", "Veniamin", "Vikentiei",
        "Viktor", "Vilen", "Vissarion", "Vitaliei", "Vlad", "Vladimir", "Vladislav", "Vladlen", "Voldemar", "Vsevolod", "Vyacheslav",
        "G", "Gavriil", "Garri", "Gennadiei", "Georgiei", "German", "Gleb", "Gordeei", "Grigoriei", "D", "David", "Daniil",
        "Demyan", "Denis", "Djeeims", "Djek", "Djozef", "Dmitriei", "Dobrenya", "E", "Evgeniei", "Evdokim", "Egor", "Eliseei",
        "Efim", "Efrem", "J", "Jdan", "Z", "Zahar", "Zinoviei", "Zoriei", "I", "Ivan", "Ignatiei", "Igor", "Illarion", "Ilya",
        "Innokentiei", "Iosif", "Irakliei", "Itan", "K", "Kazimir", "Kamil", "Kasyan", "Kim", "Kir", "Kirill", "Klim", "Kliment",
        "Kondrat", "Konstantin", "Kuzma", "L", "Lev", "Leon", "Leonid", "Leontiei", "Lukyan", "M", "Magdalina", "Makar", "Maksim",
        "Marat", "Mark", "Martin", "Matveei", "Miron", "Mitrofan", "Mihail", "Modest", "Moiseei", "Muhammed", "N", "Nazar", "Naum",
        "Nikanor", "Nikita", "Nikifor", "Nikolaei", "Nikon", "O", "Oleg", "Oliver", "Oskar", "P", "Pavel", "Paramon", "Patrik",
        "Petr", "Platon", "Prohor", "R", "Raeian", "Raeimond", "Renat", "Riku", "Rinat", "Robert", "Rodion", "Roman", "Rostislav",
        "Ruslan", "Rustam", "Ren", "S", "Savva", "Saveliei", "Samson", "Samuil", "Svyatoslav", "Sevastyan", "Semen", "Sergeei",
        "Sora", "Stanislav", "Stepan", "T", "Takeshi", "Taras", "Teodor", "Terentiei", "Timofeei", "Timur", "Tihon", "Tomas",
        "Trofim", "F", "Faddeei", "Fedor", "Fedot", "Feliks", "Filat", "Filimon", "Filipp", "Foma", "CH", "CHarli", "E",
        "Edgar", "Eduard", "Eldar", "Erik", "U", "Ulian", "Uliei", "Uma", "Uriei", "YA", "YAkov", "YAmato", "YAn", "YAroslav", 
    };
    private static string[] femaleNames = { "Avdotya", "Avrora", "Agata", "Aglaya", "Agnessa", "Agniya", "Ada", "Adelina",
        "Adelaida", "Adel", "Adilya", "Adriana", "Aza", "Azaliya", "Aziza", "Aeigul", "Aeilin", "Aida", "Aksinya", "Akulina",
        "Alana", "Alevtina", "Aleksandra", "Alena", "Alina", "Alisa", "Aliya", "Alla", "Alsu", "Albina", "Alvina", "Alfiya",
        "Ameliya", "Amina", "Amira", "Anastasiya", "Angelina", "Anjela", "Anjelika", "Anisya", "Anita", "Anna", "Antonina",
        "Anfisa", "Ariadna", "Ariana", "Arina", "Asel", "Asiya", "Asya", "Aelita", "Bella", "Bogdana", "Bojena", "Valentina",
        "Valeriya", "Varvara", "Vasilina", "Vasilisa", "Venera", "Vera", "Veronika", "Veta", "Viktoriya", "Vilena", "Violetta",
        "Virineya", "Vita", "Vitalina", "Vlada", "Vladislava", "Vladlena", "Galina", "Galiya", "Glafira", "Guzel", "Gulmira",
        "Gulnaz", "Gulnara", "Dana", "Dara", "Darina", "Darya", "Dayana", "Djamilya", "Diana", "Dina", "Dinara", "Dominika", "Eva",
        "Evangelina", "Evgeniya", "Evdokiya", "Ekaterina", "Elena", "Elizaveta", "Eseniya", "Janna", "Jasmin", "Zamira", "Zara", "Zarema",
        "Zarina", "Zemfira", "Zinaida", "Zlata", "Zoya", "Zulfiya", "Zuhra", "Ivanna", "Ivetta", "Izabella", "Ilariya", "Iliana", "Ilona",
        "Inga", "Ingeborga", "Indira", "Inessa", "Inna", "Iraida", "Irina", "Irma", "Iya", "Kamilla", "Karina", "Karolina", "Kira", "Klavdiya",
        "Kristina", "Kseniya", "Lada", "Lana", "Lara", "Larisa", "Laura", "Leeila", "Leeisan", "Lera", "Lesya", "Liana", "Lidiya", "Liza", "Lika",
        "Liliana", "Liliya", "Lina", "Linda", "Liya", "Lolita", "Lora", "Luiza", "Lubov", "Ludmila", "Magdalina", "Madina", "Maeiya", "Malika",
        "Mara", "Margarita", "Marianna", "Marika", "Marina", "Mariya", "Marta", "Marusya", "Marfa", "Maryam", "Melaniya", "Melissa", "Mila",
        "Milada", "Milana", "Milena", "Milica", "Miloslava", "Mira", "Miroslava", "Monika", "Meri", "Nadejda", "Nailya", "Natalya", "Nelli",
        "Nika", "Nikol", "Nina", "Nonna", "Nora", "Oksana", "Olesya", "Oliviya", "Olga", "Ofeliya", "Pelageya", "Polina", "Praskovya",
        "Rada", "Radmila", "Raisa", "Regina", "Renata", "Rimma", "Rita", "Roza", "Roksana", "Ruzanna", "Ruslana", "Rufina", "Sabina",
        "Sabrina", "Saida", "Samira", "Saniya", "Sara", "Svetlana", "Serafima", "Slava", "Snejana", "Sonya", "Sofiya", "Stanislava",
        "Stella", "Stefaniya", "Taisiya", "Tamara", "Tamila", "Tatyana", "Tina", "Ulyana", "Ustinya", "Faina", "Farida", "Fatima",
        "Hristina", "SHarlotta", "Evelina", "Evita", "Eleonora", "Eliza", "Elina", "Ella", "Elvina", "Elvira", "Elza", "Elmira",
        "Elya", "Emiliya", "Emma", "Erika", "Uliya", "YAna", "YAnina", "YArina", "YAroslava", "YAsmina", 
    };
    private static string[] surenames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis",
        "Garcia", "Rodriguez", "Wilson", "Martinez", "Anderson", "Taylor", "Thomas", "Hernandez", "Moore", "Martin", "Jackson",
        "Thompson", "White", "Lopez", "Lee", "Gonzalez", "Harris", "Clark", "Lewis", "Robinson", "Walker", "Perez", "Hall", 
        "Young", "Allen", "Sanchez", "Wright", "King", "Scott", "Green", "Baker", "Adams", "Nelson", "Hill", "Ramirez", 
        "Campbell", "Mitchell", "Roberts", "Carter", "Phillips", "Evans", "Turner", "Torres", "Parker", "Collins", "Edwards", 
        "Stewart", "Flores", "Morris", "Nguyen", "Murphy", "Rivera", "Cook", "Rogers", "Morgan", "Peterson", "Cooper", "Reed",
        "Bailey", "Bell", "Gomez", "Kelly", "Howard", "Ward", "Cox", "Diaz", "Richardson", "Wood", "Watson", "Brooks", "Bennett",
        "Gray", "James", "Reyes", "Cruz", "Hughes", "Price", "Myers", "Long", "Foster", "Sanders", "Ross", "Morales", "Powell",
        "Sullivan", "Russell", "Ortiz", "Jenkins", "Gutierrez", "Perry", "Butler", "Barnes", "Fisher", "Henderson", "Coleman",
        "Simmons", "Patterson", "Jordan", "Reynolds", "Hamilton", "Graham", "Kim", "Gonzales", "Alexander", "Ramos", "Wallace",
        "Griffin", "West", "Cole", "Hayes", "Chavez", "Gibson", "Bryant", "Ellis", "Stevens", "Murray", "Ford", "Marshall", "Owens",
        "Harrison", "Ruiz", "Kennedy", "Wells", "Alvarez", "Woods", "Mendoza", "Castillo", "Olson", "Webb", "Washington", "Tucker",
        "Freeman", "Burns", "Henry", "Vasquez", "Snyder", "Simpson", "Crawford", "Jimenez", "Porter", "Mason", "Shaw", "Gordon", "Wagner",
        "Hunter", "Romero", "Hicks", "Dixon", "Hunt", "Palmer", "Robertson", "Black", "Holmes", "Stone", "Meyer", "Boyd", "Mills",
        "Warren", "Fox", "Rose", "Rice", "Moreno", "Schmidt", "Patel", "Ferguson", "Nichols", "Herrera", "Medina", "Ryan", "Fernandez",
        "Weaver", "Daniels", "Stephens", "Gardner", "Payne", "Kelley", "Dunn", "Pierce", "Arnold", "Tran", "Spencer", "Peters", "Hawkins",
        "Grant", "Hansen", "Castro", "Hoffman", "Hart", "Elliott", "Cunningham", "Knight", "Bradley", "Carroll", "Hudson", "Duncan",
        "Armstrong", "Berry", "Andrews", "Johnston", "Ray", "Lane", "Riley", "Carpenter", "Perkins", "Aguilar", "Silva", "Richards",
        "Willis", "Matthews", "Chapman", "Lawrence", "Garza", "Vargas", "Watkins", "Wheeler", "Larson", "Carlson", "Harper", "George",
        "Greene", "Burke", "Guzman", "Morrison", "Munoz", "Jacobs", "Lawson", "Franklin", "Lynch", "Bishop", "Carr", "Salazar", "Austin",
        "Mendez", "Gilbert", "Jensen", "Williamson", "Montgomery", "Harvey", "Oliver", "Howell", "Dean", "Hanson", "Weber", "Garrett", 
        "Sims", "Burton", "Fuller", "Soto", "Welch", "Chen", "Schultz", "Walters", "Reid", "Fields", "Walsh", "Little", "Fowler", "Bowman",
        "Davidson", "May", "Day", "Schneider", "Newman", "Brewer", "Lucas", "Holland", "Wong", "Banks", "Santos", "Curtis", "Pearson", 
        "Delgado", "Valdez", "Pena", "Rios", "Douglas", "Sandoval", "Barrett", "Hopkins", "Keller", "Guerrero", "Stanley", "Bates",
        "Alvarado", "Beck", "Ortega", "Wade", "Estrada", "Contreras", "Barnett", "Caldwell", "Santiago", "Lambert", "Powers", "Chambers",
        "Nunez", "Craig", "Leonard", "Lowe", "Rhodes", "Byrd", "Gregory", "Shelton", "Frazier", "Becker", "Maldonado", "Fleming", "Vega",
        "Sutton", "Cohen", "Jennings", "Parks", "Watts", "Barker", "Norris", "Vaughn", "Vazquez", "Holt", "Schwartz", "Steele", "Benson",
        "Neal", "Dominguez", "Horton", "Terry", "Wolfe", "Hale", "Lyons", "Graves", "Haynes", "Miles", "Park", "Warner", "Padilla", "Bush",
        "Thornton", "Mann", "Zimmerman", "Erickson", "Fletcher", "Page", "Dawson", "Joseph", "Marquez", "Reeves", "Klein", "Espinoza",
        "Baldwin", "Moran", "Love", "Robbins", "Higgins", "Ball", "Cortez", "Le", "Griffith", "Bowen", "Sharp", "Cummings", "Ramsey",
        "Hardy", "Swanson", "Barber", "Acosta", "Luna", "Chandler", "Blair", "Daniel", "Cross", "Simon", "Dennis", "Quinn", "Gross",
        "Navarro", "Moss", "Fitzgerald", "Doyle", "Rojas", "Rodgers", "Stevenson", "Singh", "Yang", "Figueroa", "Harmon", "Newton",
        "Paul", "Manning", "Garner", "Reese", "Francis", "Burgess", "Adkins", "Goodman", "Curry", "Brady", "Christensen", "Potter",
        "Walton", "Goodwin", "Mullins", "Molina", "Webster", "Fischer", "Campos", "Avila", "Sherman", "Todd", "Chang", "Blake",
        "Malone", "Wolf", "Hodges", "Juarez", "Gill", "Farmer", "Hines", "Gallagher", "Duran", "Hubbard", "Cannon", "Miranda",
        "Wang", "Saunders", "Tate", "Mack", "Hammond", "Carrillo", "Townsend", "Wise", "Ingram", "Barton", "Mejia", "Ayala", 
        "Schroeder", "Hampton", "Rowe", "Parsons", "Frank", "Waters", "Strickland", "Osborne", "Maxwell", "Chan", "Deleon",
        "Norman", "Harrington", "Casey", "Patton", "Logan", "Bowers", "Mueller", "Glover", "Floyd", "Hartman", "Buchanan",
        "Cobb", "French", "Kramer", "Clarke", "Tyler", "Gibbs", "Moody", "Conner", "Sparks", "Leon", "Bauer", "Norton", "Pope",
        "Flynn", "Hogan", "Robles", "Salinas", "Yates", "Lindsey", "Lloyd", "Marsh", "Owen", "Solis", "Pham", "Lang", "Pratt",
        "Lara", "Brock", "Ballard", "Trujillo", "Shaffer", "Drake", "Roman", "Aguirre", "Morton", "Stokes", "Lamb", "Pacheco",
        "Patrick", "Cochran", "Shepherd", "Cain", "Burnett", "Hess", "Li", "Cervantes", "Olsen", "Briggs", "Ochoa", "Cabrera", 
        "Velasquez", "Montoya", "Roth", "Meyers", "Cardenas", "Fuentes", "Weiss", "Hoover", "Wilkins", "Nicholson", "Underwood", 
        "Short", "Carson", "Morrow", "Colon", "Holloway", "Summers", "Bryan", "Petersen", "Serrano", "Wilcox", "Carey", "Clayton",
        "Poole", "Calderon", "Gallegos", "Greer", "Rivas", "Guerra", "Decker", "Collier", "Wall", "Whitaker", "Bass", "Flowers",
        "Davenport", "Conley", "Houston", "Huff", "Copeland", "Hood", "Monroe", "Massey", "Roberson", "Combs", "Franco", "Larsen", 
        "Pittman", "Randall", "Skinner", "Wilkinson", "Kirby", "Cameron", "Bridges", "Anthony", "Richard", "Kirk", "Bruce", 
        "Singleton", "Mathis", "Bradford", "Boone", "Abbott", "Charles", "Allison", "Sweeney", "Atkinson", "Horn", "Jefferson", 
        "Rosales", "York", "Christian", "Phelps", "Farrell", "Castaneda", "Nash", "Dickerson", "Bond", "Wyatt", "Foley", "Chase",
        "Gates", "Vincent", "Mathews", "Hodge", "Garrison", "Trevino", "Villarreal", "Heath", "Dalton", "Valencia", "Callahan", 
        "Hensley", "Atkins", "Huffman", "Roy", "Boyer", "Shields", "Lin", "Hancock", "Grimes", "Glenn", "Cline", "Delacruz",
        "Camacho", "Dillon", "Parrish", "Melton", "Booth", "Kane", "Berg", "Harrell", "Pitts", "Savage", "Wiggins", "Brennan",
        "Salas", "Marks", "Russo", "Sawyer", "Baxter", "Golden", "Hutchinson", "Liu", "Walter", "Wiley", "Rich", "Humphrey", 
        "Johns", "Koch", "Suarez", "Hobbs", "Beard", "Gilmore", "Ibarra", "Keith", "Macias", "Khan", "Andrade", "Ware", "Stephenson",
        "Henson", "Wilkerson", "Dyer", "Blackwell", "Mercado", "Tanner", "Eaton", "Clay", "Barron", "Beasley", "Preston", "Small",
        "Wu", "Zamora", "MacDonald", "Vance", "Snow", "Stafford", "Barry", "English", "Shannon", "Kline", "Jacobson", "Woodard",
        "Huang", "Kemp", "Mosley", "Prince", "Merritt", "Hurst", "Villanueva", "Roach", "Nolan", "Lam", "Yoder", "Lester", "Santana",
        "Valenzuela", "Winters", "Barrera", "Leach", "Orr", "Berger", "Strong", "Conway", "Stein", "Whitehead", "Bullock", "Escobar",
        "Knox", "Meadows", "Solomon", "Velez", "Kerr", "Stout", "Blankenship", "Browning", "Kent", "Lozano", "Bartlett", "Pruitt", 
        "Buck", "Barr", "Gaines", "Durham", "Gentry", "Sloan", "Melendez", "Rocha", "Herman", "Sexton", "Moon", "Hendricks", "Rangel",
        "Stark", "Lowery", "Hardin", "Hull", "Sellers", "Ellison", "Calhoun", "Gillespie", "Mora", "Knapp", "Morse", "Dorsey", "Weeks",
        "Nielsen", "Livingston", "Leblanc", "Bradshaw", "Glass", "Middleton", "Buckley", "Schaefer", "Frost", "Howe", "House", "Ho",
        "Pennington", "Reilly", "Hebert", "Hickman", "Noble", "Spears", "Conrad", "Arias", "Galvan", "Velazquez", "Huynh", "Frederick", 
        "Randolph", "Cantu", "Fitzpatrick", "Mahoney", "Peck", "Villa", "Michael", "Donovan", "Walls", "Boyle", "Mayer", "Zuniga",
        "Giles", "Pineda", "Pace", "Hurley", "Mays", "Crosby", "Ayers", "Case", "Bentley", "Shepard", "Everett", "Pugh", "David", 
        "Dunlap", "Bender", "Hahn", "Harding", "Acevedo", "Raymond", "Blackburn", "Duffy", "Landry", "Dougherty", "Bautista", "Shah",
        "Potts", "Arroyo", "Valentine", "Meza", "Gould", "Vaughan", "Fry", "Rush", "Avery", "Herring", "Dodson", "Clements", "Sampson",
        "Tapia", "Bean", "Lynn", "Crane", "Farley", "Cisneros", "Benton", "Ashley", "Finley", "Best", "Blevins", "Friedman", "Moses",
        "Sosa", "Blanchard", "Huber", "Frye", "Krueger", "Bernard", "Rosario", "Rubio", "Mullen", "Benjamin", "Haley", "Chung", "Moyer",
        "Choi", "Horne", "Yu", "Woodward", "Ali", "Nixon", "Hayden", "Rivers", "Estes", "Richmond", "Stuart", "Maynard", "Brandt",
        "Hanna", "Sanford", "Sheppard", "Church", "Burch", "Levy", "Rasmussen", "Coffey", "Ponce", "Faulkner", "Donaldson", "Schmitt",
        "Novak", "Costa", "Montes", "Booker", "Cordova", "Waller", "Arellano", "Maddox", "Mata", "Bonilla", "Stanton", "Compton",
        "Kaufman", "Dudley", "Beltran", "Dickson", "Villegas", "Proctor", "Hester", "Cantrell", "Daugherty", "Cherry", "Bray", "Davila",
        "Rowland", "Levine", "Madden", "Spence", "Good", "Irwin", "Werner", "Krause", "Petty", "Whitney", "Baird", "Hooper", "Pollard",
        "Zavala", "Jarvis", "Holden", "Haas", "Hendrix", "Bird", "Lucero", "Terrell", "Riggs", "Joyce", "Mercer", "Rollins", "Galloway",
        "Duke", "Odom", "Andersen", "Downs", "Hatfield", "Benitez", "Archer", "Huerta", "Travis", "Hinton", "Zhang", "Hays", "Mayo", 
        "Fritz", "Branch", "Mooney", "Ewing", "Ritter", "Esparza", "Frey", "Braun", "Gay", "Riddle", "Haney", "Kaiser", "Holder", "Chaney",
        "Gamble", "Vang", "Cooley", "Carney", "Cowan", "Forbes", "Ferrell", "Davies", "Barajas", "Shea", "Osborn", "Bright", "Cuevas", "Bolton",
        "Murillo", "Lutz", "Duarte", "Kidd", "Key", "Cooke", 
    };

    List<string> gendersRange = new List<string>(genders);
    List<string> maleNamesRange = new List<string>(maleNames);
    List<string> femaleNamesRange = new List<string>(femaleNames);
    List<string> surenamesRange = new List<string>(surenames);

    // Info about person
    public static string Gender { get; set; }
    public static string Name { get; set; }
    public static string Surename { get; set; }
    public static string Age { get; set; }

    // Sprites person
    public GameObject BodySprite;
    public GameObject Hairstyle;
    public GameObject Clothes_up;
    public GameObject Clothes_down;
    public GameObject Helmet;

    // Parameters about person
    public static int MAX_HEALTH { get; set; }
    public static int Health { get; set; }
    public static int MAX_DAMAGE { get; set; }
    public static int Damage { get; set; }

    private void Awake()
    {
       
    }

    private void Start()
    {
        CreateDataPerson();
        CreateBodyPerson();
        print(Info());
    }

    private void Update()
    {
        
    }

    private void CreateDataPerson() // Gender, Name, Surename and another parameters
    {
        Gender = gendersRange[Random.Range(0, genders.Length)];
        if (Gender == "male")
        {
            Name = maleNamesRange[Random.Range(0, maleNames.Length)];
        }
        else if (Gender == "female")
        {
            Name = femaleNamesRange[Random.Range(0, femaleNames.Length)];
        }
        Surename = surenamesRange[Random.Range(0, surenames.Length)];
    }

    private void CreateBodyPerson() // Gender, Name, Surename and another parameters
    {
        if (Gender == "male") // Chooise body for gender
        {
            BodySprite.GetComponent<SpriteRenderer>().sprite = Bodies.SpritesList[0]; 
        }
        else if (Gender == "female")
        {
            BodySprite.GetComponent<SpriteRenderer>().sprite = Bodies.SpritesList[1];
        }
    }

    
        public static string Info() 
    {
        return 
            "Gender: " + Gender + "\n" +
            "Name: " + Name + "\n" +
            "Surename: " + Surename + "\n";
    }
}
