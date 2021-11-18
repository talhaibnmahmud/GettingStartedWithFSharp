open System


// For more information see https://aka.ms/fsharp-console-apps

[<EntryPoint>]                                      // Indicating the application entry point explicitly
let main argv = 
    printfn "Welcome to the calculator Program"

    printf "Type the first number: "
    let firstNumber = Console.ReadLine()
    printf "Type the second number: "
    let secondNumber = Console.ReadLine()

    printfn "First: %s, Second: %s" firstNumber secondNumber

    let sum = (int firstNumber) + (int secondNumber)
    printfn "The sum is %i" sum
    0                                               // Returns an integer exit code
