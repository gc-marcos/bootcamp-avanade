async function getDigimonsAPI(){
    const response = await fetch("https://digitalinnovationone.github.io/api-digimon/api/digimon.json");
    return await response.json();
}

async function filtroDigimons(digimonList, digimaonId) {
    const digimon = await digimonList.find((monster) => monster.id === digimaonId);
    return digimon;
}

// 3.Rederizador
async function renderDigimons(digimon) {
    const imgDigimonElement = document.getElementById("img__digimon");
    imgDigimonElement.src = digimon.image;

    const txtDigimonElement = document.getElementById("t-name__Digimon");
    txtDigimonElement.textContent = digimon.name;

    const hpDigimonElement = document.getElementById(hp__int);
    const atkDigimonElement = document.getElementById(atk__int);
    const defDigimonElement = document.getElementById(def__int);

    hpDigimonElement.style.width = digimon.HP + '%';
    atkDigimonElement.style.width = digimon.ATK + '%';
    defDigimonElement.style.width = digimon.DEF + '%'
}

// 4. Main
async function main() {
    const digimons = await getDigimonsAPI();
    const chooseDigimons = await filtroDigimons(digimons, 14);

    await renderDigimons(chooseDigimons);
}
main();