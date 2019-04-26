using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAssign
{
    class Program
    {
        static int ans, ansTwo;
        
        static string[] geoPoliticalZone = { "North Central", "North East", "North West", "South East", "South West", "South South" };

        static string[] northCentral = { "Benue", "Kogi", "Kwara", "Nasarawa", "Niger", "Plateau", "FCT" };

        static string[] northEast = { "Adamawa", "Bauchi", "Borno", "Gombe", "Taraba", "Yobe" };

        static string[] northWest = { "Jigawa", "Kaduna", "Kano", "Katsina", "Kebbi", "Sokoto", "Zamfara" };

        static string[] southEast = { "Abia", "Anambra", "Ebonyi", "Enugu", "Imo" };

        static string[] southSouth = { "Akwa Ibom", "Bayelsa", "Cross River", "Rivers", "Delta", "Edo" };

        static string[] southWest = { "Ekiti", "Lagos", "Ogun", "Ondo", "Osun", "Oyo" };

        static string[] kwara = {"Asa", "Baruten", "Edu", "Ekiti", "Ifelodun", "Ilorin East", "Ilorin South",
            "Ilorin West", "Irepodun", "Isin", "Kaiama", "Moro", "Offa", "Oke Ero","Oyun", "Pategi"};

        static string[] abia = {"Aba South", "Arochukwu", "Bende", "Ikwuano", "Isiala Ngwa North", "Isiala Ngwa South", "Isuikwuato", "Obi Ngwa", "Ohafia", "Osisioma", "Ugwunagbo", "Ukwa East", "Ukwa West", "Umuahia North", "Umuahia South", "Umu Nneochi"};

        static string[] adamawa = {"Fufure", "Ganye", "Gayuk", "Gombi", "Grie", "Hong", "Jada", "Lamurde", "Madagali", "Maiha", "Mayo Belwa", "Michika", "Mubi North", "Mubi South", "Numan", "Shelleng", "Song", "Toungo", "Yola North", "Yola South"};

        static string[] akwaIbom = {"Abak","Eastern Obolo","Eket","Esit-Eket","Essien Udim","Etim-Ekpo","Etinan","Ibeno","Ibesikpo-Asutan","Ibiono-Ibom","Ika","Ikono","Ikot Abasi","Ikot Ekpene","Ini",
            "Itu","Mbo", "Mkpat-Enin", "Nsit-Atai", "Nsit-Ibom", "Nsit-Ubium", "Obot-Akara", "Okobo", "Onna", "Oron","Oruk Anam","Ukanafun","Udung-Uko","Uruan","Urue-Offong/Oruko","Uyo"};

        static string[] anambra = { "Aguata", "Awka North", "Awka South", "Anambra East", "Anambra West", "Anaocha", "Ayamelum", "Dunukofia", "Ekwusigo", "Idemili North", "Idemili South", "Ihiala", "Njikoka", "Nnewi North", "Nnewi South", "Ogbaru", "Onitsha North", "Onitsha South", "Orumba North", "Orumba South", "Oyi" };
        static string[] bauchi = { "Bauchi", "Tafawa Balewa", "Dass", "Toro", "Bogoro", "Ningi", "Warji", "Ganjuwa", "Kirfi", "Alkaleri", "Darazo", "Misau", "Giade", "Shira", "Jama'are", "Katagum", "Itas/Gadau", "Zaki", "Gamawa", "Damban" };
        static string[] bayelsa = { "Brass", "Ekeremor", "Kolokuma/Opokuma", "Nembe", "Ogbia", "Sagbama", "Southern Ijaw", "Yenagoa" };
        static string[] benue = { "Ado", "Agatu", "Apa", "Buruku", "Gboko", "Guma", "Gwer East", "Gwer West", "Katsina-Ala", "Konshisha", "Kwande", "Logo", "Makurdi", "Obi", "Ogbadibo", "Ohimini", "Oju", "Okpokwu", "Otukpo", "Tarka", "Ukum", "Ushongo", "Vandeikya" };
        static string[] borno = { "Maiduguri", "Askira/Uba", "Abadam", "Ngala", "Bayo", "Gubio", "Kala/Balge", "Biu", "Guzamala", "Mafa", "Chibok", "Kaga", "Konduga", "Damboa", "Kukawa", "Bama", "Gwoza", "Magumeri", "Jere", "Hawul", "Marte", "Dikwa", "Kwaya Kusar", "Mobbar", "Shani", "Monguno", "Nganzai" };
        static string[] crossRiver = { "Abi", "Akamkpa", "Akpabuyo", "Bekwarra", "Biase", "Boki", "Calabar Municipal", "Calabar South", "Etung", "Ikom", "Obanliku", "Obubra", "Obudu", "Odukpani", "Ogoja", "Yakuur", "Yala" };
        static string[] delta = { "Ethiope East", "Aniocha North", "Bomadi", "Ethiope West", "Aniocha South", "Burutu", "Okpe", "Ika North East", "Isoko North", "Sapele", "Ika South", "Isoko South", "Udu", "Ndokwa East", "Patani", "Ughelli North", "Ndokwa West", "Warri North", "Ughelli South", "Oshimili North", "Warri South", "Uvwie", "Oshimili South", "Warri South West", "Ukwuani" };
        static string[] ebonyi = { "Abakaliki LGA", "Afikpo North LGA", "Afikpo South (Edda) LGA", "Ebonyi LGA", "Ezza North LGA", "Ezza South LGA", "Ikwo LGA", "Ishielu LGA", "Ivo LGA", "Izzi LGA", "Ohaozara LGA", "Ohaukwu LGA", "Onicha LGA" };
        static string[] enugu = { "Aninri LGA", "Awgu LGA", "Enugu East LGA", "Enugu North LGA", "Enugu South LGA", "Ezeagu LGA", "Igbo Etiti LGA", "Igbo Eze North LGA", "Igbo Eze South LGA", "Isi Uzo LGA", "Nkanu East LGA", "Nkanu West LGA", "Nsukka LGA", "Oji River LGA", "Udenu LGA", "Udi LGA", "Uzo-Uwani LGA" };
        static string[] edo = { "Akoko-Edo LGA", "Egor LGA", "Esan Central LGA", "Esan North-East LGA", "Esan South-East LGA", "Esan West LGA", "Etsako Central LGA", "Etsako East LGA", "Etsako West LGA", "Igueben LGA", "Ikpoba-Okha LGA", "Oredo LGA", "Orhionmwon LGA", "Ovia North-East LGA", "Ovia South-West LGA", "Owan East LGA", "Owan West LGA", "Uhunmwonde LGA" };
        static string[] ekiti = { " ", " " };
        static string[] gombe = { " ", " " };
        static string[] imo = { " ", " " };
        static string[] jigawa = { " ", " " };
        static string[] kaduna = { " ", " " };
        static string[] kano = { " ", " " };
        static string[] katsina = { " ", " " };
        static string[] kebbi = { " ", " " };
        static string[] kogi = { " ", " " };
        static string[] lagos = { " ", " " };
        static string[] nasarawa = { " ", " " };
        static string[] niger = { " ", " " };
        static string[] ogun = { " ", " " };
        static string[] ondo = { " ", " " };
        static string[] osun = { " ", " " };
        static string[] oyo = { " ", " " };
        static string[] plateau = { " ", " " };
        static string[] rivers = { " ", " " };
        static string[] sokoto = { " ", " " };
        static string[] taraba = { " ", " " };
        static string[] yobe = { " ", " " };
        static string[] zamfara = { " ", " " };

        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine("This is an APP that gives you the directory of the states in Nigeria and their local government areas");
            Console.WriteLine("******************************************************************************************************");

            Console.WriteLine("Press enter to begin");
            Console.ReadLine();

            Console.WriteLine("Nigeria officially the Federal Republic of Nigeria, is a federal republic in West Africa, bordering Niger in the north, Chad in the northeast, Cameroon in the east, and Benin in the west. " +
                "Its coast in the south is located on the Gulf of Guinea in the Atlantic Ocean. The federation comprises 36 states and 1 Federal Capital Territory, where the capital, Abuja, is located.");
            Console.ReadLine();

            Console.WriteLine("The Federal Republic of Nigeria is divided into thirty-six states and one Federal Capital Territory, which are further sub-divided into 774 Local Government Areas (LGAs). In some contexts, " +
                "the states are aggregated into six geopolitical zones.");
            Console.ReadLine();

            Console.WriteLine("The six geopolitical zones of Nigeria is a major division in modern Nigeria, created during the regime of president General Sani Abacha. " +
                "Nigeria's economic, political and educational resources are often shared across the zones.");
            Console.ReadLine();

            Console.WriteLine("The six zones were not entirely carved out based on geographic location, but rather states with similar ethnic groups, and/or common political " +
                "history were classified in the same zone. Nigeria is made up of approximately 400 ethnic groups and 450 languages. There was a need for the government to merge similar groups for effective allocation of resources.");
            Console.ReadLine();

            Console.WriteLine("The six geopolitical zones are: \n1. North Central\n2. North East\n3. North West\n4. South East\n5. South West\n6. South South");

           
            Console.WriteLine("\nLike to know more? Enter the number of a Geopolitical zone to view information about it.");
            bool success = int.TryParse(Console.ReadLine(), out ans);
            Console.WriteLine($"You have selected number {ans}: {geoPoliticalZone[ans - 1]}\n");
            GeoPoliticalInformation(ans);
            Console.WriteLine("The North Central is loosely known as Middle Belt. The Middle Belt is a term used in human geography to designate a belt region " +
                "stretching across central Nigeria longitudinally and forming a transition zone between Northern and Southern Nigeria. It is characterised by " +
                "its lack of a clear majority ethnic group, and is the location of Nigeria's Federal Capital Territory");
            Console.ReadLine();
            Console.WriteLine("The eminence of manifold minority groups, to some degree, constitutes an ethno-linguistic barrier in the country " +
                "and draws a separation between the principally Islamic North and the mainly Christian south");

            Console.WriteLine($"\nFind below a list of the states in the {geoPoliticalZone[ans - 1]} geopolitical zone");
            string[] zone = ans == 1 ? northCentral :
                            ans == 2 ? northEast :
                            ans == 3 ? northWest :
                            ans == 4 ? southEast :
                            ans == 5 ? southWest : southSouth;

            int i = 1;
            foreach (string item in zone)
            {
                Console.WriteLine(i + ". " + item);
                i++;
            }

            Console.WriteLine("Enter the number of the State you want to view information about");
            bool right = int.TryParse(Console.ReadLine(), out ansTwo);

            Console.WriteLine($"You have selected number {ansTwo}: {zone[ansTwo - 1]} State");
            Console.WriteLine($"\nFind below a list of the LGA in {zone[ansTwo - 1]} State");

            GeoPolitical(zone);
            Console.ReadLine();
        }

        static string GeoPoliticalInformation(int zoneNumber)
        {

            return "";
        }
        static void GeoPoliticalFunction(string[] zone)
        {
            if (zone.Length > 0)
            {
                int i = 1;
                foreach (string item in zone)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
            }
            GeoPolitical(zone);
        }


        static void GeoPolitical(string[] zone)
        {
            if (zone[ansTwo - 1] == "Benue")
                StateFunction(benue);
            else if (zone[ansTwo - 1] == "Kogi")
                StateFunction(kogi);
            else if (zone[ansTwo - 1] == "Kwara")
                StateFunction(kwara);
            else if (zone[ansTwo - 1] == "Nasarawa")
                StateFunction(nasarawa);
            else if (zone[ansTwo - 1] == "Niger")
                StateFunction(niger);
            else if (zone[ansTwo - 1] == "Plateau")
                StateFunction(plateau);
            //else if (zone[ansTwo - 1] == "FCT")
            //    StateFunction(fct);
            else if (zone[ansTwo - 1] == "Adamawa")
                StateFunction(adamawa);
            else if (zone[ansTwo - 1] == "Bauchi")
                StateFunction(bauchi);
            else if (zone[ansTwo - 1] == "Borno")
                StateFunction(borno);
            else if (zone[ansTwo - 1] == "Gombe")
                StateFunction(gombe);
            else if (zone[ansTwo - 1] == "Taraba")
                StateFunction(taraba);
            else if (zone[ansTwo - 1] == "Yobe")
                StateFunction(yobe);
            else if (zone[ansTwo - 1] == "Jigawa")
                StateFunction(jigawa);
            else if (zone[ansTwo - 1] == "Kaduna")
                StateFunction(kaduna);
            else if (zone[ansTwo - 1] == "Kano")
                StateFunction(kano);
            else if (zone[ansTwo - 1] == "Katsina")
                StateFunction(katsina);
            else if (zone[ansTwo - 1] == "Kebbi")
                StateFunction(kebbi);
            else if (zone[ansTwo - 1] == "Sokoto")
                StateFunction(sokoto);
            else if (zone[ansTwo - 1] == "Zamfara")
                StateFunction(zamfara);
            else if (zone[ansTwo - 1] == "Abia")
                StateFunction(abia);
            else if (zone[ansTwo - 1] == "Anambra")
                StateFunction(anambra);
            else if (zone[ansTwo - 1] == "Ebonyi")
                StateFunction(ebonyi);
            else if (zone[ansTwo - 1] == "Enugu")
                StateFunction(enugu);
            else if (zone[ansTwo - 1] == "Imo")
                StateFunction(imo);
            else if (zone[ansTwo - 1] == "Akwa Ibom")
                StateFunction(akwaIbom);
            else if (zone[ansTwo - 1] == "Bayelsa")
                StateFunction(bayelsa);
            else if (zone[ansTwo - 1] == "Cross River")
                StateFunction(crossRiver);
            else if (zone[ansTwo - 1] == "Rivers")
                StateFunction(rivers);
            else if (zone[ansTwo - 1] == "Delta")
                StateFunction(delta);
            else if (zone[ansTwo - 1] == "Edo")
                StateFunction(edo);
            else if (zone[ansTwo - 1] == "Ekiti")
                StateFunction(ekiti);
            else if (zone[ansTwo - 1] == "Lagos")
                StateFunction(lagos);
            else if (zone[ansTwo - 1] == "Ogun")
                StateFunction(ogun);
            else if (zone[ansTwo - 1] == "Ondo")
                StateFunction(ondo);
            else if (zone[ansTwo - 1] == "Osun")
                StateFunction(osun);
            else if (zone[ansTwo - 1] == "Oyo")
                StateFunction(oyo);

            return;
        }
            

         static void StateFunction(string[] state)
        {
            if (state.Length > 0)
            {
                int i = 1;
                foreach (string item in state)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
            }
            return;
        }
        
    }

}

