namespace edu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 задание
            int parts = 15;
            Console.WriteLine(parts);

            //2 задание
            int eng = 20;
            int engN = eng - 7;// в задании не сказано выводить переменную

            // 3 задание
            int hour = 12;
            int hour8 = hour * 8;

            // 4 задание
            int all = 29;
            int box = 6;
            int boxPolnih = all / box;
            int lostDet = all % box;

            // 5 задание
            double r1 = 7;
            double r2 = 8;
            double r3 = 9;
            double sred = (r1 + r2 + r3) / 3;

            // 6 задание
            decimal det = 49.90m;
            decimal rez = det + det + det + det; //использовал сложение а не умножение на 4 потому что сказано вычеслить сумму

            // 7 задание
            double ed = 40;
            double rez15 = ed * 1.15;

            // 8 задание 
            int allBolts = 137;
            int robots = 8; 
            int kolVo = allBolts / robots;
            int rezerv = allBolts % robots;
            int kolVoOnRobot = kolVo * robots;
            Console.WriteLine("Количество на одного робота: " + kolVo);
            Console.WriteLine("резерв: " + rezerv);
            Console.WriteLine("количество болтов на одного робота: " + kolVoOnRobot);
        }
    }
}
