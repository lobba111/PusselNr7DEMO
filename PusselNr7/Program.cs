using System.Text.RegularExpressions;

// find smallest nummer in array
//int n = arr1.Length;//längen på arrayen

string[] inputData = System.IO.File.ReadAllLines(@"C:\Users\robin\OneDrive\Skrivbord\InputdataPusselNr7.txt");

List<string> filter = new List<string>();
foreach (string input in inputData)
{
     filter = new List<string>(input.Split(','));
    
}
List<int> filterdOutput = new List<int>();  
foreach (var f in filter)
{
    filterdOutput.Add(Convert.ToInt32(f));  
}

int[] theRealInput = filterdOutput.ToArray();







int[] arr = new int[] { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };
// find smallest nummer in array
int n = theRealInput.Length;//längen på arrayen
int i;






//räkna nu kostnaden för varje nummer från högsta siffran ned till 0 -
// från noll räkna ut kostanden uppåt +
//håll koll på position och kostnad 



// find most common number first the second the third in array sedan ta och dra av från de alla andra positionerna för att räkna ut kostnaden plussa på om dom ligger under mest förekommande nummer 

//Array.Sort(theRealInput);
int max_count = 1, mostFrequent = theRealInput[0];
int curr_count = 1;
for (i = 1; i < n; i++)
{
    if (theRealInput[i] == theRealInput[i - 1])
    {
        curr_count++;
    }
    else
    {
        if (curr_count > max_count)
        {
            max_count = curr_count;
            mostFrequent = theRealInput[i - 1];
        }
        curr_count = 1;
    }
}
if (curr_count > max_count)
{
    max_count = curr_count;
    mostFrequent = theRealInput[n - 1] ;

}
Console.WriteLine("Det mest förekommande nummret är {0}", mostFrequent);

int fuel = 0;
//int mostFrequent = 2;

for (i = 0; i < theRealInput.Length; i++)
{
    int result = 0;
    if (theRealInput[i] > mostFrequent+13)
    {
        result += theRealInput[i] - mostFrequent +13;
        fuel += result;
        //Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", theRealInput[i], mostFrequent, result);
    }
    else if (mostFrequent +13 > theRealInput[i] && theRealInput[i] != 0)
    {
        result = 13+mostFrequent - theRealInput[i];
        fuel += result;
        //Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", theRealInput[i], mostFrequent, result);
    }
    else if (theRealInput[i] == 0)
    {
        result = mostFrequent +13;
        fuel += result;
        //Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", theRealInput[i], mostFrequent, result);
    }
    else
    {
        fuel += 0;
        //Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", theRealInput[i], mostFrequent, result);
    }
    
   
}

int higesthValue = theRealInput.Max();

Console.WriteLine("Fuel cost to move is : {0}", fuel);
fuel = 0;
for (i = 0; i < theRealInput.Length; i++)
{
    int result = 0;
    if (theRealInput[i] > higesthValue)
    {
        result += theRealInput[i] - higesthValue;
        fuel += result;
        //Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", theRealInput[i], higesthValue, result);
    }
    else if (higesthValue > theRealInput[i] && theRealInput[i] != 0)
    {
        result = higesthValue - theRealInput[i];
        fuel += result;
        //Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", theRealInput[i], higesthValue, result);
    }
    else if (theRealInput[i] == 0)
    {
        result = higesthValue;
        fuel += result;
        //Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", theRealInput[i], higesthValue, result);
    }
    else
    {
        fuel += 0;
        //Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", theRealInput[i], higesthValue, result);
    }


}
Console.WriteLine("Fuel cost to move is : {0}", fuel);

int max = theRealInput.Max();
int [] results = new int[max];
for (int p = 1; p < max; p++)
{
    int result = 0;
    for (int j  = 0; j < theRealInput.Length; j++)
    {
        result += Math.Abs(theRealInput[j] - p);
    }
    results[p] = result;
}
Console.WriteLine("FUEL COST");
Console.WriteLine(results.Where(x=> x!=0).Min());



