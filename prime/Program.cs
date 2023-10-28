// See https://aka.ms/new-console-template for more information
int []a=new int[4];

for(int i=0;i<a.Length;i++){
	Console.Write("Enter Number: ");
	a[i]=int.Parse(Console.ReadLine());
	}

int sum=0;

foreach(int i in a){
	bool isPrime=true;
	for(int j=1;j<(int)Math.Sqrt(i);j++){
		if(i<=1){
			break;
		}
		else if(i%j==0){
			isPrime=false;
			break;
		}
	}
	if(isPrime==true){
		sum+=1;
	}
	}

Console.WriteLine(sum);
