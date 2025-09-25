namespace Tyuiu.LyzhinIN.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AddArr(int[] num)
        {
            var total = 0;
            for (var i = 0; i < num.Length; i++)
            {
                total = total + num[i];
            }
            return total;
        }
        public static int SubArr(int[] num)
        {
            var total = 0;
            int count = 0;
            while (count < num.Length)
            {
                total = total - num[count];
                count++;
            }
            return total;
        }
        public static int MultArr(int[] num)
        {
            var total = 1;
            int count = 0;
            do
            {
                total = total * num[count];
                count++;
            }
            while (count < num.Length);
            return total;
        }
    }
}
