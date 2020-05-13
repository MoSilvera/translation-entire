function getRandomInt(min, max) {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;
}


 const toString = (value) => {
    let dieString = "Unknown";
            switch (value)
            {
                case 1:
                    dieString = "\u2680";
                    break;
                case 2:
                    dieString = "\u2681";
                    break;
                case 3:
                    dieString = "\u2682";
                    break;
                case 4:
                    dieString = "\u2683";
                    break;
                case 5:
                    dieString = "\u2684";
                    break;
                case 6:
                    dieString = "\u2685";
                    break;
            }

            return dieString;
  }


function main() {
  console.log("Let's roll some dice, baby!")
  console.log("----------------------------")
  for (let i = 0; i < 10; i++) {
    let die1 = getRandomInt(1,6)
    let die2 = getRandomInt(1,6)
    let message = `${toString(die1)} + ${toString(die2)} === ${die1 + die2} `
    if (die1 === die2){
      message += "DOUBLES!"
    }
    console.log(message)
  }
}

main();