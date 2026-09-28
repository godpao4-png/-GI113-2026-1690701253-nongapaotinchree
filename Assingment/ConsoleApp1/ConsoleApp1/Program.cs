using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Boss Stats
            Console.WriteLine("===== KIRIN SAVE CONVERTER ===== ");
            Console.WriteLine($"NAME: {bossName}" +
                $"\nRANK: {rank}" +
                 $"\nlevel: {level} / {MaxLevel}" +
                  $"\nhp / {maxHp}" +
                   $"\nattack / {attackPower} " +
                    $"\ncritmultiplier / {critMultiplier} " +
                     $"\nisboos: {isBoss} ");

            //implicit coversion HP(int) -->> double 
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"Hp (double) : {currentHpDouble}");
             
            // Calcuate Percent as double
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double HPPercentExact = currentHpDouble *100 / maxHp;
            Console.WriteLine($"Hp Percent (exact): {HPPercentExact}%");

            // Explicit casting attack power(float) -->> int

            // cast vs. convert: critMultiplier      



        }
    }
}
