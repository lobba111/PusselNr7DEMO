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

int[] arr1 = filterdOutput.ToArray();





int[] arr = new int[] { 16, 1, 2, 0, 4, 2, 7, 1, 2, 14 };
// find smallest nummer in array
int n = arr.Length;//längen på arrayen
int i;






//räkna nu kostnaden för varje nummer från högsta siffran ned till 0 -
// från noll räkna ut kostanden uppåt +
//håll koll på position och kostnad 



// find most common number in array sedan ta och dra av från de alla andra positionerna för att räkna ut kostnaden plussa på om dom ligger under mest förekommande nummer 

Array.Sort(arr);
int max_count = 1, mostFrequent = arr[0];
int curr_count = 1;
for (i = 1; i < n; i++)
{
    if (arr[i] == arr[i - 1])
    {
        curr_count++;
    }
    else
    {
        if (curr_count > max_count)
        {
            max_count = curr_count;
            mostFrequent = arr[i - 1];
        }
        curr_count = 1;
    }
}
if (curr_count > max_count)
{
    max_count = curr_count;
    mostFrequent = arr[n - 1];

}
Console.WriteLine("Det mest förekommande nummret är {0}", mostFrequent);

int fuel = 0;
//int mostFrequent = 2;

for (i = 0; i < arr.Length; i++)
{
    int result = 0;
    if (arr[i] > mostFrequent)
    {
        result += arr[i] - mostFrequent;
        fuel += result;
        Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", arr[i], mostFrequent, result);
    }
    else if (mostFrequent > arr[i] && arr[i] != 0)
    {
        result = mostFrequent - arr[i];
        fuel += result;
        Console.WriteLine("Move from {0} to {1} : cost in fuel {2}",arr[i], mostFrequent, result);
    }
    else if (arr[i] == 0)
    {
        result = mostFrequent;
        fuel += result;
        Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", arr[i], mostFrequent, result);
    }
    else
    {
        fuel += 0;
        Console.WriteLine("Move from {0} to {1} : cost in fuel {2}", arr[i], mostFrequent, result);
    }
    
   
}

Console.WriteLine("Fuel cost to move is : {0}", fuel);


