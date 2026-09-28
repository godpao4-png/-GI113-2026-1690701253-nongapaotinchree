
//Student ID : 1690701253
//Name       : PIYAWAT THANTHONG
//Section    : 129B
//No.        :
//Course     : GI113 Computer Programming (GI113)

using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            const string GameTitle = "HELLDIVERS 2";

            
            var helldiverName = "Super Citizen";     
            var soldierClass = 'H';                  

            
            string activeMission = "LIBERATE SUPER EARTH"; 
            char armorGrade = 'A';                         
            int requisitionSlips = 12500000;               
            float combatSpeed = 7.85f;                     
            double stratagemRange = 125.75;                
            bool isReinforcementReady = true;             

            
            int liberationsPerHour = 650;                  
            double superDestroyerValue = 428500.85;        

            Console.WriteLine("===========================================================================");
            Console.WriteLine("  _   _ _____ _     _     ____  _____ _    _ _____ ____   ____ ");
            Console.WriteLine(" | | | | ____| |   | |   |  _ \\| ____| |  | | ____|  _ \\ / ___|");
            Console.WriteLine(" | |_| |  _| | |   | |   | | | |  _| | |  | |  _| | |_) | |");
            Console.WriteLine(" |  _  | |___| |___| |___| |_| | |___| |__| | |___|  _ <| |___");
            Console.WriteLine(" |_| |_|_____|_____|_____|____/|_____|\\____/|_____|_| \\_\\\\____|");
            Console.WriteLine($"  [{GameTitle} - GALACTIC WAR TERMINAL]");
            Console.WriteLine("===========================================================================");

            Console.WriteLine("==============================================================");
            Console.WriteLine("                    HELLDIVER DEPLOYING                      ");
            Console.WriteLine("==============================================================");
            Console.WriteLine();
            Console.WriteLine("                         /\\");
            Console.WriteLine("                        /  \\");
            Console.WriteLine("                       /____\\");
            Console.WriteLine("                      | 00 00 |");
            Console.WriteLine("                      |  ||   |");
            Console.WriteLine("                  ____|__||___|____");
            Console.WriteLine("                 /      ||       \\");
            Console.WriteLine("                /   ____||____    \\");
            Console.WriteLine("               /   /          \\    \\");
            Console.WriteLine("              |   |   HELLDIVER |    |");
            Console.WriteLine("              |   |             |    |");
            Console.WriteLine("              |   |_____________|    |");
            Console.WriteLine("              |        /  \\          |");
            Console.WriteLine("              |       /____\\         |");
            Console.WriteLine("              |      /|    |\\        |");
            Console.WriteLine("              |     / |    | \\       |");
            Console.WriteLine("              |____/  |    |  \\______|");
            Console.WriteLine("                    __|    |__");
            Console.WriteLine("                   /          \\");
            Console.WriteLine("                  /____________\\");
            Console.WriteLine();
            Console.WriteLine("              [ SUPER EARTH HELLDIVER ]");
            Console.WriteLine("==============================================================");


            Console.WriteLine(" |  +-----------------------------------------------------------------+");
            Console.WriteLine(" |                                                                    |");
            Console.WriteLine(" |  [MISSION STATUS] -> LIBERATE SUPER EARTH                          |");
            Console.WriteLine(" |                                                                    |");
            Console.WriteLine(" |  +-----------------------------------------------------------------+ ");
            Console.WriteLine("+==============================================================================+");
            Console.WriteLine("|                    S U P E R   E A R T H                                     |");
            Console.WriteLine("|                  MINISTRY OF DEFENSE                                         | ");
            Console.WriteLine("+==============================================================================+");
            Console.WriteLine("|                                                                              |");
            Console.WriteLine("|                  G A L A C T I C   W A R                                     |");
            Console.WriteLine("|                                                                              |");
            Console.WriteLine($"|                    {GameTitle,-30}                            |"); 
            Console.WriteLine("|                                                                              |");
            Console.WriteLine("+==============================================================================+");

            Console.WriteLine();
            Console.WriteLine("+==============================================================================+");
            Console.WriteLine("|                         MISSION CONTROL                                      |");
            Console.WriteLine("+==============================================================================+");
            Console.WriteLine($"|  MISSION STATUS     : [ ACTIVE ]                                             |");
            Console.WriteLine($"|  OPERATION         : {activeMission,-48}        |");
            Console.WriteLine("|  FACTION            : SUPER EARTH                                            |");
            Console.WriteLine("| THREAT LEVEL       : ||||||||||| HIGH                                        |");
            Console.WriteLine("+==============================================================================+");

            Console.WriteLine();

            Console.WriteLine("+==============================================================================+");
            Console.WriteLine("|                        HELLDIVER PROFILE                                     |");
            Console.WriteLine("+==============================================================================+");
            Console.WriteLine($"|  CALLSIGN           : {helldiverName,-50}     |");
            Console.WriteLine($"|  CLASS              : [{soldierClass}] GALACTIC HELLDIVER                                 |");
            Console.WriteLine($"|  ARMOR GRADE        : GRADE-{armorGrade} COMBAT ARMOR                                   |");
            Console.WriteLine($"|  COMBAT SPEED       : {combatSpeed,-6} m/s                                             |");
            Console.WriteLine("|  STATUS             : DEMOCRACY OFFICER                                      |");
            Console.WriteLine("================================================================================");

            Console.WriteLine();

            Console.WriteLine("┌+==============================================================================+");
            Console.WriteLine("|                         STRATAGEM SYSTEM                                      |");
            Console.WriteLine("+===============================================================================+");
            Console.WriteLine($"|  STRATAGEM RANGE    : {stratagemRange,-8} METERS                                         |");
            Console.WriteLine($"|  REINFORCEMENT      : {(isReinforcementReady ? "[ READY ]" : "[ UNAVAILABLE ]"),-15}                                         |");
            Console.WriteLine("|  ORBITAL SUPPORT    : [ AVAILABLE ]                                           |");
            Console.WriteLine("|  EAGLE SUPPORT      : [ AVAILABLE ]                                           |");
            Console.WriteLine("================================================================================");

            Console.WriteLine();

            Console.WriteLine("+===============================================================================+");
            Console.WriteLine("|                       SUPER EARTH RESOURCES                                   |");
            Console.WriteLine("+===============================================================================+");
            Console.WriteLine($"|  REQUISITION SLIPS  : {requisitionSlips:N0} CREDITS                                      |");
            Console.WriteLine($"|  LIBERATION RATE    : {liberationsPerHour:N0} POINTS / HOUR                                       | ");
            Console.WriteLine($"|  SUPER DESTROYER    : ${superDestroyerValue:N2} CREDITS                                     |");
            Console.WriteLine("+===============================================================================+");

            Console.WriteLine();

           

           

            double liberationRateAsDouble = liberationsPerHour;

            Console.WriteLine("============================================================================");
            Console.WriteLine("[ SYSTEM LOG ]");
            Console.WriteLine($"Implicit Conversion : int -> double");
            Console.WriteLine($"Liberation Rate     : {liberationRateAsDouble}");
            Console.WriteLine("============================================================================");

           
            int castShipValue = (int)superDestroyerValue;

          
            int convertShipValue = Convert.ToInt32(superDestroyerValue);

            Console.WriteLine();
            Console.WriteLine("[ CONVERSION ANALYSIS ]");
            Console.WriteLine($"Raw Double Value    : {superDestroyerValue}");
            Console.WriteLine($"Explicit Cast (int) : {castShipValue}");
            Console.WriteLine($"Convert.ToInt32()   : {convertShipValue}");

            Console.WriteLine();
            Console.WriteLine("+============================================================================+");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("|                    D E M O C R A C Y   S E C U R E                         |");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("|                  FOR DEMOCRACY! FOR SUPER EARTH!                           |");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("+============================================================================+");

            Console.WriteLine();
            Console.WriteLine("Press any key to return to Super Earth...");
            Console.ReadKey();
        }
    }
}
