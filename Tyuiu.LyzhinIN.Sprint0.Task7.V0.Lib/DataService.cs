namespace Tyuiu.LyzhinIN.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AddArrs(int[] numOne, int[] numTwo)
        {
            int[] resultArr = new int[5];
            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = numOne[i]+numTwo[i];
            }
            return resultArr;
        }
    }
}
