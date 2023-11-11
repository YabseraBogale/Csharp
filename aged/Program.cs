int[][] jagedArray= new int[3][];

Random number=new Random();
int sum=0;
for(int i=0;i<jagedArray.Length;i++){
    jagedArray[i]=new int[(i*2)+2];
    for(int j=0;j<jagedArray[i].Length;j++){
            jagedArray[i][j]=number.Next(10);
            //Console.WriteLine("The Entered Value is {0}",jagedArray[i][j]);
            sum+=jagedArray[i][j];
    }
}

Console.WriteLine("The sum is {0}.\nArray Values are",sum);
sum=0;
foreach(int[] i in jagedArray){
    foreach(int j in i){
        Console.Write("{0} ",j);
        sum+=j;
    }
    Console.WriteLine("the sum of this inner array {0}",sum);
    sum=0;
}







