//nombres masculinos
const primer_masc = [
    "Jose",
    "Juan",
    "Pedro",
    "Pablo",
    "Luis",
    "Jesús",
    "Javier",
    "Carlos",
    "Manuel",
    "Daniel",
    "Miguel",
    "Rafael",
    "Alejandro",
    "Santiago",
    "Diego",
    "Samuel",
    "Antonio",
    "Jorge",
    "Alberto",
    "Lucas",
    "Agustino",
    "Julio",
    "Gabriel",
    "Valentino",

]

const primer_fem = [
    "María",
    "Justina",
    "Juana",
    "Josefa",
    "Francisca",
    "Antonia",
    "Dolores",
    "Manuela",
    "Josefina",
    "Renata",
    "Olivia",
    "Jimena",
    "Gabriela",
    "Camila",
    "Valentina",
    "Sofía",
    "Rita"
]

const apellidos = [
    "García",
    "González",
    "Rodríguez",
    "Fernández",
    "López",
    "Martínez",
    "Sánchez",
    "Pérez",
    "Gómez",
    "Martín",
    "Jiménez",

]

function random(n) {
    return Math.floor(Math.random() * n);
}

function randomElement(list) {
    return list[random(list.length)];
}

function generateName() {
    const genero = randomElement(["m", "f"])
    const primer = genero === "m" ? randomElement(primer_masc) : randomElement(primer_fem);
    const segundo = randomElement(apellidos);
    return `${primer} ${segundo}`;
}

function generateComposedName(gen){
    const genero = gen
    const primer = genero === "m" ? randomElement(primer_masc) : randomElement(primer_fem);
    const segundo = genero === "m" ? randomElement(primer_masc) : randomElement(primer_fem);
    const compuesto = randomElement(apellidos);
    return `${primer} ${segundo} ${compuesto}`;

}

function generateNames(n, gen) {
    const names = [];
    for (let i = 0; i < n; i++) {
        names.push(generateNames(gen));
    }
    return names;
}

const names = generateNames(200, "m");

names.forEach(name => console.log(name));