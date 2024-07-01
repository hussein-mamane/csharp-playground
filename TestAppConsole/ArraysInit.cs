namespace TestAppConsole;

public  class ArraysInit
{
    public static void RunCode()
    {
        var objects = new[] { new  { b= 5,c="Hello",d=new string[]{"A","B"}}, new { b = 6,c="There",d= Array.Empty<string>() } };//unspecified type
        int[] oneDim = new int[] { 2, 3 };
        int[] oneDimCollectionExpression = [2, 3];
        int[][] twoDimJagged = [[2]];//jagged are easier and recommended
        int[][] twoDimsIntegers = new int[][] { new int[] {2}, new [] {3} };//type specified outside only is enough
        int[,] multidimesionnalArr = {{1},{2}};  //Implicitly typed array should have initializer & Implicitly typed array cannot have size expression
        int[,] multidimesionnalArr2 = new int[3,2];// Multidimensionnal must give its dimensions

    }
}