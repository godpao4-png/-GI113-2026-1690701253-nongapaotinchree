
/*
*Student ID: 1690701253
* Name       :ungpao
* Section    :129B
* No.        :N / A
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment_02

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // VOIDSTRIKE
            // ==========================================

            const double SMELT_RATE = 2.0;
            const double BREAKDOWN_RATE = 1.0;

            Console.WriteLine("==========================================");
            Console.WriteLine("           VOIDSTRIKE ");
            Console.WriteLine("==========================================");
            Console.WriteLine("        Welcome to  VOIDSTRIKE");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("======================================================================");
            Console.WriteLine("++=======+========+=++++++++++++++%@@%%%#-=--*=-:---++++=-=+*+=+*****#");
            Console.WriteLine("++=====++++=++==++*+++++++++++=-=-#@@@@@@@@@#%%**+-:*===-.-+*+====++**");
            Console.WriteLine("*+=+==++++++++++*##*++--=-=---::: *@@@@@@@@@@@@@%#*:*---...:+----::--*");
            Console.WriteLine("*+++=++*+=+++*###+=------:.... .. *@@@@@@@@@@@@@@@@%%*-::-:.-..:::. .+");
            Console.WriteLine("***++*##+++++##*+--::..     ..    *@@@@@@@@@@@@@@@@@@@#+-:=+-..:::.  -");
            Console.WriteLine("#%#+###***+++*+-:. .     .. ..    *@@@@@@@@@@@@@@@@@@@@@#:-*=..:...  -");
            Console.WriteLine("#%%##***+*+++-. .   . ...:: ...   *@@@@@@@@@@@@@@@@@@@@@@--*-.....   .");
            Console.WriteLine("%%###***++**=..  .  ..    ::.:.:  *@@@@@@@@@@@@@@@@@@@@@@#:*:..  ...  ");
            Console.WriteLine("%%####****#+:  .  .. ..    ..::.: *@@@@@@@@@@@@@@@@@@@@@@@*+........  ");
            Console.WriteLine("%#####**###+:   .. .....    ......#@@@@@@@@@@@@@@@@@@@@@@@@: .......  ");
            Console.WriteLine("%%%###*#%%#+.   .::::-=----:..... #@@@@@@@@@@@@@@@@@@@@@@@*.......... ");
            Console.WriteLine("%%%#*#**#%#+: ...:-+####+++++=-:..*@@@@@@@%%%%@%##@@@@@@@@+:......... ");
            Console.WriteLine("%%#***#*+#**-.  .:=+%%%#**+*****+-#@%#%@%%#%#%@@**%@@@@@@@-:......... ");
            Console.WriteLine("%%#+++*#*+++-.   .=+#%%%###*******%%###%@@%%#%%@%*%@@@@@@@*-........  ");
            Console.WriteLine("##*++**####*-:    -*#%%%%##******+%%#%%%%@@%%##%@##@@@@@@@#=:.......  ");
            Console.WriteLine("*#++=**#####-:    :#%%#####**##**+%%%%%%###%*=+%#%%@@@@@@@@#: ....... ");
            Console.WriteLine("%#===**#####===:--=**=::::::::=:  *#**+====###%@%%@@%%@@@@@#: ..   .:-");
            Console.WriteLine("#*--+#*#####=-:+*+=-:::-==-:-::..-#=---+%%@%%%#@###%%%@@@@@%=.    .:==");
            Console.WriteLine("#=-=*#######+- -=+=:.:==::++====-+#=--+%@@*--#@@%=-*%%%@@@@@*-:   .-++");
            Console.WriteLine("*=::*########=.==--:  :--:=+-=-+*+%**##%#*+=--+#+==+%##@@@@@%**:: .=**");
            Console.WriteLine("*=-:+########+-+#+=:.         :+*+%#%%++**+=:.=*-==*%##%@@@@@@%+*:.+**");
            Console.WriteLine("+----########+=+**+=.  ...... .=#*%%%%*:::::::+*:--####%@@@@@@@@@%%%%%");
            Console.WriteLine("=-::-**###**#-=+++**-     :.  .+#*%%###=:::::.**:=*###%@@@@@@@@@@@@@@@");
            Console.WriteLine("--::-+=+**+-+::*+++#*.    .:.  =#*%%#*+-::::::*+:+#*###@@@@@@@@@@@@@@@");
            Console.WriteLine("--::::---+=:=-.+++++#=  .:-:    -=#*+-::::::::+==#*#*#%@@@@@@@@@@%@@@@");
            Console.WriteLine("##+:-=*#####%###++++*+: .-:..  .==###*+-::::::*++**###%@@@@@@@@@@@%#%%");
            Console.WriteLine("%@@**%%%%%%%%%%%#+****- .:...:::..#+===-----::#*+**#%%%@@@@@@@@@@@@@%*");
            Console.WriteLine("@@@%%##############**#+:.. .::....*++++***=--+@#*###%@@%@@@%%@@@@@@@@@");
            Console.WriteLine("@%#%%###*****##########-. . .==---####**##++*#@%#%%%%%*#@@@%%%@@@@@@@@");
            Console.WriteLine("@@%###*****###***+++****+=-:..... *=---=+***#%@%%#*++*+*@%@@%%%@@@@@@@");
            Console.WriteLine("%@@#***+++++++++++++++++++*++=:...*=---==+*%%@@%####%%%%@@@@%%%%@@@@@@");
            Console.WriteLine("**##+---::::.........:::.::-=+*=:.*--=*#%%##*#@#******+*@*%#*#%+@@@@@@");
            Console.WriteLine("-=-=+-.........              .:-=-#*%%%#++==-*@#-----=-+%+#=*##=#@@@@@");
            Console.WriteLine(":--::==::........               .=%#*+=------*@@=------+#++=++*=*@@@@@");
            Console.WriteLine("====--**--------:::...           .#=---------+@@+-=====**++=*=+++@@@@@");
            Console.WriteLine("======================================================================");
            Console.WriteLine();

            Console.WriteLine("SMELT    : 2 Ore -> 1 Ingot");
            Console.WriteLine("BREAKDOWN: 1 Ingot -> 1 Ore");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("[S] SMELT ORE");
            Console.WriteLine("[B] BREAKDOWN INGOT");
            Console.WriteLine("==========================================");

            // ==========================================
            // SELECT MENU
            // ==========================================

            Console.Write("Choose action [S/B]: ");
            string menu = Console.ReadLine()?.Trim().ToUpper();

            if (menu != "S" && menu != "B")
            {
                Console.WriteLine();
                Console.WriteLine("[ERROR] INVALID COMMAND!");
                Console.WriteLine("Please choose S or B.");
                return;
            }

            // ==========================================
            // GET AMOUNT
            // ==========================================

            Console.Write("Enter amount: ");
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double amount))
            {
                Console.WriteLine();
                Console.WriteLine("[ERROR] INVALID AMOUNT!");
                Console.WriteLine("Amount must be a number.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("[ERROR] INVALID AMOUNT!");
                Console.WriteLine("Amount must be greater than 0.");
                return;
            }

            // ==========================================
            // VOIDSTRIKE CALCULATION
            // ==========================================

            Console.WriteLine();
            Console.WriteLine("==========================================");

            if (menu == "S")
            {
                double ingot = amount / SMELT_RATE;

                Console.WriteLine(">> ACTION   : SMELT");
                Console.WriteLine($">> MATERIAL : {amount:0.##} Ore");
                Console.WriteLine($">> OUTPUT   : {ingot:0.##} Ingot");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("⚔ VOIDSTRIKE MATERIAL READY!");
            }
            else
            {
                double ore = amount * BREAKDOWN_RATE;

                Console.WriteLine(">> ACTION   : BREAKDOWN");
                Console.WriteLine($">> MATERIAL : {amount:0.##} Ingot");
                Console.WriteLine($"OUTPUT   : {ore:0.##} Ore");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("⚔ VOIDSTRIKE MATERIALS RECOVERED!");
            }

            Console.WriteLine("==========================================");
            Console.WriteLine("_VOIDSTRIKE operation completed.");
            Console.WriteLine("Returning to battlefield...");
        }
    }
}