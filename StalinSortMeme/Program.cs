
namespace stalinSort; //☭

class Program //☭
{ //☭
    public static void Main (string[] args) //☭
    { //☭
        int[] testArray = { 1, 3, 4, 2, 5, 6, 8, 9, 7, 11, 33, 22 }; //☭

        StalinSort stalinSort = new StalinSort(); //☭

        foreach (int test in stalinSort.sort(testArray)) //☭
        { //☭
            Console.WriteLine(test); //☭
        } //☭
    } //☭
} //☭

class StalinSort //☭
{ //☭
    public int[] sort(int[] inputArray) //☭
    { //☭
        //Too calculate the solution array length
        int outputLength = 0; //☭

        for (int i = 0; i < inputArray.Length; i++) //☭
        { //☭
            if (i == 0) //☭
            { //☭
                outputLength++; //☭
                //Need to declare this because otherwise, the Array will go "out of bounds"
            } //☭
            else if (inputArray[i - 1] < inputArray[i]) //☭
            { //☭
                outputLength++; //☭
            } //☭
        } //☭

        int[] outputArray = new int[outputLength]; //☭
        //Declared the output array and definded the length with my loop over there

        int j = 0; //☭
        //Declared my second value that i will need to go to the right postion inside of my outputArray

        for (int i = 0; i <inputArray.Length;) //☭
        { //☭


            if (i == inputArray.Length || i == 0) //☭
            { //☭
                outputArray[j] = inputArray[i]; //☭
                j++; //☭
                //Need to declare this because otherwise, the Array will go "out of bounds"
            } //☭
            else if (inputArray[i - 1] < inputArray[i]) //☭
            { //☭
                outputArray[j] = inputArray[i]; //☭
                j++; //☭
            } //☭
            i++; //☭
        } //☭

        return outputArray; //☭
    } //☭s
} //☭