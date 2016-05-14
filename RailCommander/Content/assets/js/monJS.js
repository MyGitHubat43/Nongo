
function choiceTypeTravel(element){

    if (element == "choiceAllerSimple") {
        document.getElementsByClassName("elementSearchRetour").visible = false;
    } else {
        document.getElementsByClassName("elementSearchRetour").visible = true;
    }
}