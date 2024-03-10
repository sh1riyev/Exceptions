using Exception_Claswork.Helpers.Exceptions;

void Calculate()
{
    bool isCorrect = true;
    try
    {
        int a = 5;
        int b = 0;
        var result = a / b;
        Console.WriteLine(result);

        int[] arr = { 1, 2, 3 };
        arr[6] = 100;
    }
    catch (Exception ex)
    {
        isCorrect = false;
    }
    finally
    {
        SendMessage(isCorrect);
    }
}

//Calculate();

void SendMessage(bool isCorrect)
{
    if (isCorrect)
    {
        Console.WriteLine("You calculation is true");
    }
    Console.WriteLine("Your calculation is false");
}


string GetById(int ? id)
{
    try
    {
        if (id == null)
        {
            //throw new ArgumentNullException();
            throw new CustomArgumentNullException("Argument cannot be null");
        }
        return "Salam";
    }
    catch(Exception ex)
    {
        return ex.Message;
    }
}

Console.WriteLine(GetById(null));