﻿module Practice

//let allNumber = (n:number):string
//that returns a string containing all numbers from 0 to n. Separate the numbers with a whitespace.
let rec allNumber (n : int ) : string =
    if n<0 then 
        "" 
    elif 0 = n then
        string n
    else
        (string n ) + " " + (allNumber (n-1))

//let allNumberRev = (n:number):string
//that returns a string containing all numbers from n to 0. Separate the numbers with a white space.
let rec allNumberRev (n : int ) : string =
    if n < 0 then 
        " "
    elif 0 = n then 
        string n 
    else
        (allNumberRev (n-1 )) + " " + (string n)


//let allNumberRange = (lower:number) => (upper:number):string
//that returns a string containing all numbers between lower and upper. Separate the numbers with a white space
let rec allNumberRange ( lower : int )(upper : int) : string = 
    if lower> upper then
        " "
    elif upper = lower then
        string lower
    else 
        (string lower) + " " + (allNumberRange (lower + 1) upper)
 

//let allNumberRangeRev = (lower:number) => (upper:number):string
//that returns a string containing all numbers between lower and upper in reverse order. Separate the numbers with a white space.
let rec allNumberRangeRev (lower: int) (upper : int) :string = 
    if lower> upper then
        ""
    elif upper = lower then
        string lower
    else 
        (string upper) + " " + (allNumberRangeRev lower ( upper - 1))

// EX3 oefententa
let boo  (z:int )( y : int): string = 
     string (z +  y)

let x : string = boo(8)(8)

//let allEvenRange = (lowernumber) => (upper:number):string
//that returns a string containing all even numbers between lower and upper. Separate the numbers with a white space.
let rec allEvenRange  (lower : int) (upper:int) : string = 
    if lower > upper then 
        " "
    elif upper = lower && lower % 2 = 0 then 
        string lower
    else
        if lower % 2 = 0 then
            (string lower) + " " + (allEvenRange (lower + 1 ) upper)
        else
            allEvenRange (lower + 1) upper

//let drawLine = (length:number):string
//that returns a string containing length asterisks.

let rec drawLine (lenght : int ) : string = 
    if lenght = 0 then
        ""
    else
        "*" + (drawLine (lenght - 1))

//let toBinary = (n:number):string
//that returns a string containing the binary representation of the input number (it must be positive).
//The binary representation is obtained using the following procedure:
//1. Add to the end of the string the remainder of the division between the current number and 2.
//2. Repeat the previous step until the number is 0. In this case simply don’t add anything.

let rec toBinary (n:int) : string =
    if n = 0 then
        ""
    else
        let binaryN = n % 2
        (toBinary (n / 2)) + (string binaryN)

//let toBase = (n:number) => (base:number):string
//that returns a string containing the representation of the input number in an arbitrary base (the
//number must be positive). The algorithm is the same as above except you must take the remainder of n divided by base


//let filter = <a, b>(p: (x: a) => bool) => (l:List<a>) => List<a>
//let x: = filter((x: number) => x > 5)

//let rec filter (p :: x : a bool) (l:List<'a>) : List<'a> 
//let x: List<'b> -> List<'b> = filter((x : int) : x >5)

let rec toBase (n:int) (_base:int) : string =
    if n = 0  then
        ""
    else 
        let binaryN = n % _base
        (toBase (n / _base) _base) + (string binaryN)

//let last = <a>(l:List<a>):a
//that returns the last element of a list.

let rec last (l: List<'a>): Option<'a> =
    match l with
    | [] -> None
    | [x] -> Some x
    | _ :: xs -> last xs

//let rev = <a>(l:List<a>):List<a>
//that creates a list with the elements of l in reverse order.
let rec rev (l: List<'a>) : List<'a> = 
    match l with
    | [] -> []
    | x :: xs -> (rev xs ) @  [x]

//let append = <a>(l1:List<a>List<a>) => (l2:List<a>):
//that adds all the elements of l2 after those in l1.
let rec append (l1: List<'a>) (l2: List<'a>) : List<'a> = 
    match l1,l2 with
    | [],l2 -> l2
    | x :: xs,l2 -> x :: (append xs l2)

//let nth = <a>(n:number) => (l:List<a>): a
//that returns the element in position n in l.

let rec nth (n :int) (l: List<'a>) : Option<'a> = 
  if n < 0 then
    None
  elif n = 0 then
    Some l.Head
  else
    nth (n - 1) l.Tail

//let palindrome = <a>(l:List<a>):boolean
//that checks if a list is palindrome. A list is palindrome if it is equal to its inverse.

let rec palindrome (l : List<'a>) : bool =
    (rev l) = l

 

let testPractice() =
  printfn "%A" (drawLine(10))
  printfn "%A" (rev[1;3;4;6;7;8;10])
  printfn "%A" (append[1;3;4;6;7;8;10],[1;4;6;8;9;4;2;])
  printfn "%A" (boo (9)(19))
