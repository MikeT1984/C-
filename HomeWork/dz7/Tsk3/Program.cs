
void PrintArrayReversed(int[] array,int index){
if (index < 0){
    return;
}
Console.WriteLine(array[index]);
PrintArrayReversed(array,index-1);

}
int[] array ={1,2,4,5,6,7,8};
PrintArrayReversed(array,array.Length-1);