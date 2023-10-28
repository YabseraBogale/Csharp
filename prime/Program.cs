// See https://aka.ms/new-console-template for more information
int []a=new int[4];

for(int i=0;i<a.Length;i++){
	Console.Write("Enter Number: ");
	a[i]=int.Parse(Console.ReadLine());
	}

int sum=0;
int size=0;
foreach(int i in a){
	bool isPrime=true;
	for(int j=1;j<=(int)Math.Sqrt(i);j++){
		if(i==2){
			break;
		}
		else if(i==1){
			isPrime=false;
		}
		else if(i%j==0 && j!=1){
			isPrime=false;
		}
	}
	if(isPrime==true){
		sum+=i;
		size+=1;
	}
	}
Console.WriteLine($"The Number of Prime Numbers in the array is {size} and the Sum is {sum}");

