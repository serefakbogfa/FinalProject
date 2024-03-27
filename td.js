function checkEvenOrOdd(number) {
    if (number % 2 === 0) {
        return "Even"; // Çift sayı
    } else {
        return "Odd"; // Tek sayı
    }
}

var num = 10;
var result = checkEvenOrOdd(num);
console.log("The number " + num + " is " + result + ".");
