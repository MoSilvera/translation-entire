function main() {
  console.log("Do you believe in magic?")
  console.log("-------------------")
  const goodBook = makeGoodSpellBook(allSpells)
  const evilBook = makeEvilSpellBook(allSpells)
  displaySpellBook(goodBook)
  displaySpellBook(evilBook)
}

const displaySpellBook = (book) => {
  console.log(book.title)
  book.spells.forEach(spell => {
    console.log(spell.name)
  });
}
const makeEvilSpellBook=(spells) => {
  let evilBook = {}
  evilBook.title = "Evil Book"
  evilBook.spells = spells.filter(spell => spell.isEvil === true)
  return evilBook
}
const makeGoodSpellBook = (spells) => {
  let goodBook = {}
  goodBook.title = "Good Book"
  goodBook.spells = spells.filter(spell => spell.isEvil === false)
  return goodBook
}
const allSpells = [
  {
    name: "turn enemy into a newt",
    isEvil: true,
    energyRequired: 5.1
  },
  {
    name: "turn enemy into a happy newt",
    isEvil: false,
    energyRequired: 2
  },
  {
    name: "feed the poor",
    isEvil: false,
    energyRequired: 5.1
  },
  {
    name: "make yourself emperor",
    isEvil: true,
    energyRequired: 5.1
  },
]

main();