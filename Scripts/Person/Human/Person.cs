using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Person : MonoBehaviour
{
    //System
    private static Random RANDOMGENERATOR = new Random();
    
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
    public static int Age { get; set; }
    public static float SkinColor { get; set; }
    public static Color HairColor { get; set; }
    public static Color EyeColor { get; set; }
    public static Color MouthColor { get; set; }

    //UI elements for person
    public Text FullNameText;

    // Gameobjects person Clothes (GameObjects)
    public List<GameObject> personClothes = new List<GameObject>(5);
    /*
        Element 0 - Cloth_up,
        Element 1 - Cloth_down,
        Element 2 - Cloth_helmet,
        Element 3 - Left_arm,
        Element 4 - Right_arm,
     */

    // Gameobjects person Clothes (GameObjects)
    public List<GameObject> personPrefabsClothes = new List<GameObject>(5);
    /*
        Element 0 - PrefabsCloth_up,
        Element 1 - PrefabsCloth_down,
        Element 2 - PrefabsCloth_helmet,
        Element 3 - PrefabsLeft_arm,
        Element 4 - PrefabsRight_arm,
     */

    // Sprites person (GameObjects)
    public List<GameObject> personParts = new List<GameObject>(5);
    /*  Element 0 - Body,
        Element 1 - Hairstyle,
        Element 2 - Beard,
        Element 3 - Eye,
        Element 4 - Mouth,
    */

    // Conteiners for person
    public List<SpritesGeneratorConteiner> SpriteConteiners = new List<SpritesGeneratorConteiner>();
    /*
        Element 0 - BodySprites,
        Element 1 - HairstyleMaleSprites,
        Element 2 - HairstyleFemaleSprites
        Element 3 - BeardSprites,
        Element 4 - EyeSprites,
        Element 5 - MouthSprites,
     */

    //Clothes person ? Maybe new Class for clothes ?
    //public List<GameObject> personClothes = new List<GameObject>(4);
    /*  Element 0 - Clothes_up,
        Element 1 - Clothes_down,
        Element 2 - Helmet,
        Element 3 - Instruments(Weapons),
    */

    // Parameters about person in updates
    public Vector2 POSITION = new Vector2();
    public int MAX_HEALTH = 100;
    public int Health;
    public int MAX_DAMAGE = 20;
    public int Damage = 0;

    public bool DressedCloth_up = false;
    public bool DressedCloth_down = false;
    public bool DressedHelmet = false;
    public bool DressedLeft_arm = false;
    public bool DressedRight_arm = false;

    // UI parameters for person
    public bool PAUSE = false;

    private void Awake()
    {
        
    }

    private void Start()
    {
        SetPositionPerson(Random.Range(-5, 5), Random.Range(-5, 5));
        CreatePerson();
    }

    private void Update()
    {
        CheckPerson(PAUSE);
    }

    private void CheckParametersPerson() // Health, Position, Damage and another parameters
    {
        GetComponent<Transform>().position = POSITION; // every seconds we check position person
    }

    private void CheckUIPereson() 
    {
        
    }
    private void CheckDressPerson() 
    {
        
        for (int i = 0; i < 5; i++) {
            switch (i)
            {
                case 0:
                    personClothes[0].SetActive(DressedCloth_up);
                    break;
                case 1:
                    personClothes[1].SetActive(DressedCloth_down);
                    break;
                case 2:
                    personClothes[2].SetActive(DressedHelmet);
                    break;
                case 3:
                    personClothes[3].SetActive(DressedLeft_arm);
                    break;
                case 4:
                    personClothes[4].SetActive(DressedRight_arm);
                    break;
            }
        }
    }
    private void CreateDressPerson() 
    {

        /*
          *personPrefabsClothes*                *personClothes*
        Element 0 - PrefabsCloth_up,         Element 0 - Cloth_up,     
        Element 1 - PrefabsCloth_down,       Element 1 - Cloth_down,
        Element 2 - PrefabsCloth_helmet,     Element 2 - Cloth_helmet,
        Element 3 - PrefabsLeft_arm,         Element 3 - Left_arm,
        Element 4 - PrefabsRight_arm,        Element 4 - Right_arm,
        */
        SetDressPerson(0, true);
        Instantiate(personPrefabsClothes[0], personClothes[0].GetComponent<Transform>());
        Instantiate(personPrefabsClothes[1], personClothes[1].GetComponent<Transform>());
        Instantiate(personPrefabsClothes[2], personClothes[2].GetComponent<Transform>());
    }

    private void CreateDataPerson() // Gender, Name, Surename and another data
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
        Age = Random.Range(14, 60);

        /* UI init */
        FullNameText.text = GetFullName();
    }

    private void CreatePartsPerson() // Body, Hirstyle, Beard and another parts
    {
        /*
                *SpriteConteiners*                  *personParts*
            Element 0 - BodySprites,              Element 0 - Body,
            Element 1 - HairstyleMaleSprites,     Element 1 - Hairstyle,
            Element 2 - HairstyleFemaleSprites,
            Element 3 - BeardSprites,             Element 2 - BeardSprites,
            Element 4 - EyeSprites,               Element 3 - EyeSprites,
            Element 5 - MouthSprites,             Element 4 - MouthSprites,
        */
        float color = Random.value; // Brown color for generator
        if (Random.value > 0.5f)
        {
            HairColor = new Color(color, color - 0.6f, 0f);//red - brown black
        }
        else 
        {
            if (Random.value > 0.5f)
            {
                HairColor = new Color(color, color, color);// grey - black
            }
            else 
            {
                HairColor = new Color(1f, 1f, color);//yellow - white
            }
        }
        EyeColor = new Color(Random.value, Random.value, Random.value);
        MouthColor = new Color(Random.value+0.55f, 0, 0);


        //Init beard, hair, eye, mouth color generator  
        personParts[1].GetComponent<SpriteRenderer>().color = HairColor;
        personParts[2].GetComponent<SpriteRenderer>().color = HairColor; // Beard only for male
        personParts[3].GetComponent<SpriteRenderer>().color = EyeColor;
        personParts[4].GetComponent<SpriteRenderer>().color = MouthColor;

        if (Gender == "male") // Chooise body for gender
        {
            personParts[0].GetComponent<SpriteRenderer>().sprite = SpriteConteiners[0].SpritesList[0];
            /* Hairstyle init for person */
            personParts[1].GetComponent<SpriteRenderer>().sprite = SpriteConteiners[1].SpritesList[Random.Range(0, SpriteConteiners[1   ].SpritesList.Count)];
            /* Beard init for person*/
            //Debug.Log(SpriteConteiners[2].SpritesList.Count);
            personParts[2].GetComponent<SpriteRenderer>().sprite = SpriteConteiners[3].SpritesList[Random.Range(0, SpriteConteiners[3].SpritesList.Count)];
        }
        else if (Gender == "female")
        {
            personParts[0].GetComponent<SpriteRenderer>().sprite = SpriteConteiners[0].SpritesList[1];
            /* Hairstyle init for person */
            personParts[2].GetComponent<SpriteRenderer>().sprite = SpriteConteiners[2].SpritesList[Random.Range(0, SpriteConteiners[2].SpritesList.Count)];
        }
        /*Moth and eye init for person*/

        personParts[3].GetComponent<SpriteRenderer>().sprite = SpriteConteiners[4].SpritesList[Random.Range(0, SpriteConteiners[4].SpritesList.Count)];
        personParts[4].GetComponent<SpriteRenderer>().sprite = SpriteConteiners[5].SpritesList[Random.Range(0, SpriteConteiners[5].SpritesList.Count)];

        /* Skin color generator */
        SkinColor = Random.value + 0.3f; // Init skin color of person
        personParts[0].GetComponent<SpriteRenderer>().color = new Color((float)SkinColor, (float)SkinColor, (float)SkinColor);
    }

    public void SetPositionPerson(float x, float y) // Set position for person
    {
        POSITION = new Vector2(x, y);
    }

    public Vector2 GetPositionPerson() // Get postion of person
    {
        return POSITION;
    }

    public void CreatePerson()
    {
        CreateDataPerson();
        CreatePartsPerson();
        CreateDressPerson();
        print(AllInfo());
    }


    public void CheckPerson(bool pause = false) 
    {
        if (!pause)
        {
            CheckParametersPerson();
            CheckUIPereson();
            CheckDressPerson();
        }
    }
    //For generator
    /*public void GeneratorPerson(int count)
    {
        for (int i = 0; i < count; i++)
        {
            CreatePerson();
        }
    }*/

    public void SetDressPerson(int element, bool dressed) 
    {
        if (element >= 4) 
        {
            element = 4;
        }
        if(element <= 0) 
        {
            element = 0;
        }
        switch (element)
        {
            case 0:
                DressedCloth_up = dressed;
                break;
            case 1:
                DressedCloth_down = dressed;
                break;
            case 2:
                DressedHelmet = dressed;
                break;
            case 3:
                DressedLeft_arm = dressed;
                break;
            case 4:
                DressedRight_arm = dressed;
                break;
        }
    }
    public static string GetFullName() 
    {
        return Name + " " + Surename;
    }

    public static string AllInfo() 
    {
        return 
            "Gender: " + Gender + "\n" +
            "Name: " + Name + "\n" +
            "Surename: " + Surename + "\n" +
            "Age: " + Age + "\n";
    }
}
