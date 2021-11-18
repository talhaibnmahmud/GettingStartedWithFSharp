// For more information see https://aka.ms/fsharp-console-apps

let cardDescription (card: int): string = 
    let cardNumber = card % 13
    if cardNumber = 1 then "Ace"
    elif cardNumber = 11 then "Jack"
    elif cardNumber = 12 then "Queen"
    elif cardNumber = 0 then "King"
    else string cardNumber


let suit (number: int) : string = 
    let suitNumber: int = number / 13
    if suitNumber = 0 then "Hearts"
    elif suitNumber = 1 then "Spades"
    elif suitNumber = 2 then "Diamonds"
    else "Clubs"


[<EntryPoint>]
let main _argv = 
    let cards = [ 1; 10; 2; 34 ]
    for card in cards do
        printfn "%s of %s" (cardDescription(card)) (suit(card))

    0
