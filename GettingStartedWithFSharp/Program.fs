// For more information see https://aka.ms/fsharp-console-apps

// Bind a value to a variable (Immutable By Default)
let name = "Talha"

// Not Allowed
// name <- "John Doe"

// Making the varibale mutable with the "mutable" keyword
let mutable age = 23
age <- 24                                                   // Allowed

// Variable types
let university = "KUET"                                     // String
let moneyLeft = 25.75                                       // Float
let isDesert = true                                         // Bool

// Printing to the console
printfn "Hello, I'm learning F#"

// Foramtting
printfn $"Name: {name}, University: {university}"
printfn "I have %f Taka left" moneyLeft

// Read from the Console
System.Console.Write "Type something: "
let str = System.Console.ReadLine()
printfn "You typed %s" str

// Convert between data types
let first = "57"
let mutable numberedVersion = System.Int32.Parse first
printfn "Number is: %i" numberedVersion

let second = "57"
numberedVersion <- int second
printfn "Number is: %i" numberedVersion                     // Prefered


// Branching
printf "Enter a number: "
let seniorityCheck = System.Console.ReadLine()
if (int seniorityCheck) > 65
then printfn "You're a senior citizen"
else printfn "Citizen"

let messeage = if (int seniorityCheck) > 65 then "Senior Citizen" else "Citizen"
printfn "%s" messeage

let cardValue = 1
let cardDescription = if cardValue = 1 then "Ace" elif cardValue = 14 then "Ace" else "A Card"
printfn "%s" cardDescription

// Branching Exercise
let cardNo = 12
let cardName = 
    if cardNo = 1 || cardNo = 14 then "Ace"
    elif cardNo = 11 then "Jack"
    elif cardNo = 12 then "Queen"
    elif cardNo = 13 then "King"
    else string cardNo
printfn "%s" cardName
