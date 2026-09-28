
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

            const double SMELT_RATE = 0.15;
            const double SALVAGE_RATE = 0.35;

            const double MIN_AMOUNT = 0;
            const double MAX_AMOUNT = 500;


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

            Console.WriteLine($"=> Iron Smelting {SMELT_RATE:0.##} / Salvage {SALVAGE_RATE:0.##}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Salvage (Ingot -> Ore)");

            // ==========================================
            // SELECT MENU
            // ==========================================

            Console.Write("Choose Menu: ");

            string menuInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(menuInput) || menuInput.Length != 1)
            {
                Console.WriteLine("error: menu");
                return;
            }

            char menu = char.ToUpper(menuInput[0]);

            if (menu != 'S' && menu != 'B')
            {
                Console.WriteLine("error: menu");
                return;
            }

            // ==========================================
            // AMOUNT
            // ==========================================

            Console.Write("How much would you like: ");

            string amountInput = Console.ReadLine();

            if (!double.TryParse(amountInput, out double amount))
            {
                Console.WriteLine("error: amount (parse nothing)");
                return;
            }

            if (amount <= MIN_AMOUNT)
            {
                Console.WriteLine("error: amount (CANNOT EXCEED 0!)");
                return;
            }

            if (amount > MAX_AMOUNT)
            {
                Console.WriteLine("error: amount (OUT OF BOUNDS!)");
                return;
            }

            // ==========================================
            // CALCULATE
            // ==========================================

            if (menu == 'S')
            {
                double ingot = amount * SMELT_RATE;

                Console.WriteLine(
                    $"=> {amount:0.00} Iron Ore = {ingot:0.00} Iron Ingot"
                );
            }
            else if (menu == 'B')
            {
                double ore = amount / SALVAGE_RATE;

                Console.WriteLine(
                    $"=> {amount:0.00} Iron Ingot = {ore:0.00} Iron Ore"
                );
            }
        }
    }
}