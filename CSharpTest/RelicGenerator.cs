//Goal - make it so that a gui will display the prompts and after display the final data that would originaly be put into the hsr ps

//Passerby of Wandering Cloud 0-3
//Musketeer of Wild Wheat 4-7
//Knight of Purity Palace 8-11
//Hunter of Glacial Forest 12-15
//Champion of Streetwise Boxing-16-19
//Guard of Wuthering Snow 20-23
//Firesmith of Lava-Forging 24-28
//Genius of Brilliant Stars 29-32
//Band of Sizzling Thunder 33-36
//Eagle of Twilight Line 37-40
//Thief of Shooting Meteor 41-44
//Wastelander of Banditry Desert 45-48
//Longevous Disciple 49-52
//Messenger Traversing Hackerspace 53-56
//The Ashblazing Grand Duke 57-60
//Prisoner in Deep Confinement 61-64
//Pioneer Diver of Dead Waters 65-68
//Watchmaker, Master of Dream Machinations 69-72
using CSharpTest;
using GUi;

//names for all the relics
string[] relicName =
{
"Passerby of Wandering Cloud Head", "Passerby of Wandering Cloud Hand", "Passerby of Wandering Cloud Body", "Passerby of Wandering Cloud Feet",
"Musketeer of Wild Wheat Head", "Musketeer of Wild Wheat Hand", "Musketeer of Wild Wheat Body", "Musketeer of Wild Wheat Feet",
"Knight of Purity Palace Head", "Knight of Purity Palace Hand","Knight of Purity Palace Body", "Knight of Purity Palace Feet",
"Hunter of Glacial Forest Head","Hunter of Glacial Forest Hand" , "Hunter of Glacial Forest Body" , "Hunter of Glacial Forest Feet",
"Champion of Streetwise Boxing Head", "Champion of Streetwise Boxing Hand", "Champion of Streetwise Boxing Body","Champion of Streetwise Boxing Feet",
"Guard of Wuthering Snow Head", "Guard of Wuthering Snow Hand", "Guard of Wuthering Snow Body", "Guard of Wuthering Snow Feet",
"Firesmith of Lava-Forging Head", "Firesmith of Lava-Forging Hand", "Firesmith of Lava-Forging Body", "Firesmith of Lava-Forging Feet",
"Genius of Brilliant Stars Head","Genius of Brilliant Stars Hand","Genius of Brilliant Stars Body","Genius of Brilliant Stars Feet",
"Band of Sizzling Thunder Head","Band of Sizzling Thunder Hand","Band of Sizzling Thunder Head Body","Band of Sizzling Thunder Head Feet",
"Eagle of Twilight Line Head","Eagle of Twilight Line Hand","Eagle of Twilight Line Body","Eagle of Twilight Line Feet",
"Thief of Shooting Meteor Head","Thief of Shooting Meteor Hand","Thief of Shooting Meteor Body","Thief of Shooting Meteor Feet",
"Wastelander of Banditry Desert Head","Wastelander of Banditry Desert Hand","Wastelander of Banditry Desert Body","Wastelander of Banditry Desert Feet",
"Longevous Disciple Head","Longevous Disciple Hand","Longevous Disciple Body","Longevous Disciple Feet",
"Messenger Traversing Hackerspace Head","Messenger Traversing Hackerspace Hand","Messenger Traversing Hackerspace Body","Messenger Traversing Hackerspace Feet",
"The Ashblazing Grand Duke Head","The Ashblazing Grand Duke Hand","The Ashblazing Grand Duke Body","The Ashblazing Grand Duke Feet",
"Prisoner in Deep Confinement Head","Prisoner in Deep Confinement Hand","Prisoner in Deep Confinement Body","Prisoner in Deep Confinement Feet",
"Pioneer Diver of Dead Waters Haed","Pioneer Diver of Dead Waters Hand","Pioneer Diver of Dead Waters Body","Pioneer Diver of Dead Waters Feet",
"Watchmaker, Master of Dream Machinations Head","Watchmaker, Master of Dream Machinations Hand","Watchmaker, Master of Dream Machinations Body","Watchmaker, Master of Dream Machinations Feet"};

List<string> avatarData = createGui();//gets the Character the user inputted
string character = avatarData[0];

string level = avatarData[1];

string eidelon = avatarData[2];

string ascention = avatarData[3];

string health = avatarData[4];

string TrailblazeLvl = avatarData[5];

characterCreate(character, Int32.Parse(level), Int32.Parse(eidelon), Int32.Parse(ascention), Int32.Parse(health), Int32.Parse(TrailblazeLvl));
//do the same thing as above for relics
/*
//display all the names for relics so that the user can input the relic name they want
foreach (string name in relicName)//make this loop only run if the user wants to see the names for all relics
{
    Console.WriteLine(name);
}
Console.WriteLine("Enter the name for the relic");
string userRelicName = Console.ReadLine();

int relicId = getRelic(userRelicName);

relicCreate(relicId);*/

void relicCreate(int relicId)
{
    var relic = new BattleRelic//make it so that the mainaffixID and subaffixes can be inputed by the user
    {
        BattleRelicId = relicId,
        Level = 15,
        MainAffixId = 5,
        SubAffixes = new List<RelicAffix>
    {
        new RelicAffix
        {
            AffixId = 1,
            Cnt = 2,
            Step = 3,
        }
    }
    };
}

List<string> createGui()
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    MainForm mainForm = new MainForm();
    Application.Run(mainForm);

    List<string> data = mainForm.getData();

    return data;
}
void characterCreate(String name, int level, int Eidelon, int ascention, int health, int TrailblazeLvl)
{
    int id = getCharacterNamesIndex(name);
    List<BattleAvatar> avatars = new List<BattleAvatar>();
    var avatar1 = new BattleAvatar
    {
        CharacterId = id,
        Level = level,
        Eidelon = Eidelon,
        Ascention = ascention,
        hp = health,
        worldLevel = TrailblazeLvl,
    };
    avatars.Add(avatar1);//this is the format for each added character up to 4

}

//the functions below are used to figure out the different Ids for characters and relics (maybe can include Lightcones)
int getCharacterId(int index)
{
    //an array that stores the character Id's of all the characters in star rail version 2.1
    int[] characterId = { 1308,1307,1306,1305,1304, 1303, 1302,1217,1213,1212,1211,1209,1208,1205,1204,1203,1112,1107,1104,1102,1101,1006,1005,1004,1003,8001,8002,8003,8004,1312,1301,1215,
    1214,1210,1207,1206,1202,1201,1111,1110,1109,1108,1106,1105,1103,1013,1009,1008,1002,1001};

    return characterId[index];
}

int getCharacterNamesIndex(string name)
{   //an array that stores the character names of all the characters in star rail version 2.1
    String[] charactersNames = { "Acheron", "Black Swan", "Sparkle", "Dr. Ratio", "Aventurine", "Ruan Mei", "Argenti", "Huohuo", "Dan Heng Imbibitor Lunae", "Jingliu", "Bailu", "Yanqing",
    "Fu Xuan","Blade","Jing Yuan","Luocha","Topaz & Numby","Clara","Gepard","Seele","Bronya","Silver Wolf","Kafka","Welt","Himeko","Phy Male Trailblazer","Phy Female Trailblazer",
    "Fire Male Trailblazer","Fire Female Trailblazer","Misha","Gallagher","Hanya","Xueyi","Guinaifen","Yukong","Sushang","Tingyun","Qingque","Luka","Lynx","Hook","Sampo","Pela","Natasha",
    "Serval","Herta","Asta","Arlan","Dan Heng","March 7th"};

    for (int i = 0; i < charactersNames.Length; i++)
    {
        if (charactersNames[i].ToLower() == name.ToLower())
        {
            return getCharacterId(i);
        }
    }
    return 0;
}
int getRelic(string name)
{
    for (int i = 0; i < relicName.Length; i++)
    {
        if (relicName[i].ToLower() == name.ToLower())
        {
            return getRelicId(i);
        }
    }
    return 0;
}
int getRelicId(int index)
{   //an array that stores all the relic Ids in star rail version 2.1
    int[] relicId = { 61011, 61012, 61013, 61014, 61021, 61022, 61023, 61024, 61031, 61032, 61033, 61034, 61041, 61042, 61043, 61044, 61051, 61052, 61053, 61054, 61051, 61052, 61053, 61054,
    61071,61072,61073,61074,61081,61082,61083,61084,61091,61092,61093,61094,61101,61102,61103,61104,61111,61112,61113,61114,61121,61122,61123,61124,61131,61132,61133,61134,61141,61143,
    61143,61144,61151,61152,61153,61154,61161,61162,61163,61164,61171,61172,61173,61174,61181,61182,61183,61184};

    return relicId[index];
}