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


// Loops

// For...In Loop
// for <pattern> in <enumerable-expression> do
//      <body-expression>
printfn ""
let list = [1; 2; 3; 4; 5]
for i in list do
    printf "%i " i

// For...To Loop
// for <identifier = start> [to | downto] <finish> do
//      <body-expression>
printfn ""
for i = 1 to 10 do
    printf "%i " i

printfn ""
for i = 10 downto 1 do
    printf "%i " i


// While loops
// while <test-expression> do
printfn ""
let mutable quit = false
let number = 11
while not quit do
    printf "Guess a Number: "
    let guess = int (System.Console.ReadLine())
    if guess = number then
        quit <- true
        printfn "You guessed correctly %i is the secret number!" number
    else
        printfn "%i is incorrect" guess


// Finctions
let add a b =  a + b

let addAndMultiply a b c =                                  // No return keyword
    let sum = a + b
    let product = sum * c
    product                                                 // The last line is the return

// Calling a function
printfn "%i" (addAndMultiply 2 3 3)                         // 15

// Infered types
let sum = add 2 2 
// let concat = add "hello" "world"                         // will give compilation error


// Functional patterns

// Composition
let addComposed a = a + 2
let multiplyComposed a = a * 3
//let addMultiply a = 
//    let sum = addComposed a
//    let product = addAndMultiply sum
//    product
let addMultiply = addComposed >> addAndMultiply
// addMultiply 2                                            // 12

// Pipeline
let myList = [4; 3; 2; 1]
let sort (list: int list) = List.sort list
let print (list: int list) = List.iter(fun x -> printfn "Item %i " x) list
myList |> sort |> print


// F# Collections
let logEntryMonday = "first entry"
let logEntryTuesDay = "second entry"
let logEntryWednesday = "third entry"

let logEntriesWeek = ["first entry"; "second entry"; "third entry";]

// F# List (Immutable)
let cards = ["Ace"; "King"; "Queen"]
let newCards = [
  "Ace"
  "King"
  "Queen"
]
// let cards = [ 1, "Ace", "King" ]                         // not permitted
let numbers = [1 .. 5]                                      // Range based list [1, 2, 3, 4, 5]

let cardList = ["Ace"; "King"; "Queen"]
let newCardList = "Jack" :: cardList                        // "Ace", "King", "Queen", "Jack"                       

let otherCardList = ["Jack"; "10";]
let fullCardList = cards @ otherCardList                    // "Ace", "King", "Queen", "Jack", "10"

let appendedList = cards |> List.append ["Jack"]
let fullList = cards |> List.append otherCardList

printfn $"Head: {fullList.Head}, Tail: {fullList.Tail}, Length: {fullList.Length}, isEmpty: {fullList.IsEmpty}"
