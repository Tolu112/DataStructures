//DATA STRUCTURES


Console.WriteLine("Welcome to the Data Structures Database\n");
string input = "";


//Program loop
bool runProgram = true;
while (runProgram)
{
    //Get user input and validate entry
    for (int numOfTries = 0; numOfTries == 0 || !Validator.Validator.ContainsOnlyLetters(input); numOfTries++)
    {
        var displayMessage = numOfTries > 0
                             ? "Invalid entry. Please enter a word or sentence."
                             : "Please enter a word you would like to reverse: ";
        Console.Write(displayMessage);
        input = Console.ReadLine();

    }
    //Add users word/sentence to a string array
    string[] sentence = input.Split(" ");

    //Display word/sentence in reverse
    Array.ForEach(sentence, word => Console.Write(string.Join(ReverseString(word), " ")));

    //Ask user to continue
    runProgram = Validator.Validator.GetContinue();
}



//Method to add string to stack and reverse output
static string ReverseString(string input)
{
    //Store letters of each word in character array
    char[] letters;
    letters = input.ToCharArray(0, input.Length);

    //Instantiate Stack
    Stack<char> inputStack = new Stack<char>();

    //Add letters to stack
    Array.ForEach(letters, l => inputStack.Push(l));

    //display top element in stack
    Array.ForEach(letters, l => Console.Write(inputStack.Pop()));
    return input;
}




