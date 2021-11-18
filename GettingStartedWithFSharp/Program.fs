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
System.Console.Write "Type a value: "
let str = System.Console.ReadLine()
printfn "You typed %s" str

// Convert between data types
let first = "57"
let mutable numberedVersion = System.Int32.Parse first
printfn "Number is: %i" numberedVersion

let second = "57"
numberedVersion <- int second
printfn "Number is: %i" numberedVersion                     // Prefered
