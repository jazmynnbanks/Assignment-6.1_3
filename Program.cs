
int[] myArray = { 0, 1, 0, 3, 12 };

int insertPos = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] != 0)
    {
        myArray[insertPos] = myArray[i];
        insertPos++;
    }

}

for (int i = insertPos; i < myArray.Length; i++)
{
    myArray[i] = 0;
}

foreach (int i in myArray)
{
    Console.Write(i + " ");
}
