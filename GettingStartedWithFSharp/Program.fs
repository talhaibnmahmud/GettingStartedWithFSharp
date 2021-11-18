// For more information see https://aka.ms/fsharp-console-apps

// Bind a value to a variable (Immutable By Default)
let name = "Talha"

// Not Allowed
// name <- "John Doe"

// Making the varibale mutable with the "mutable" keyword
let mutable age = 23
age <- 24               // Allowed

// Variable types
let university = "KUET"     // String
let moneyLeft = 25.75       // Float
let isDesert = true         // Bool

// Printing to the console
printfn "Hello, I'm learning F#"

// Foramtting
printfn $"Name: {name}, University: {university}"
printfn "I have %f Taka left" moneyLeft
