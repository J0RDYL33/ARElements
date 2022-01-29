using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class InfoSlider : MonoBehaviour
{
    public Sprite[] elementSprites;
    public Animator panelAnimator;
    public Image panelImage;
    public Text headerText;
    public Text infoText;
    public Text guideText;
    public bool[] alreadyPlayed;

    private void Start()
    {
        alreadyPlayed = new bool[11];
    }

    public void PlayAnim(string element)
    {
        switch (element)
        {
            case "fire":
                if (alreadyPlayed[0] == false)
                    SwitchPlay("fire");
                alreadyPlayed[0] = true;
                break;
            case "water":
                if (alreadyPlayed[1] == false)
                    SwitchPlay("water");
                alreadyPlayed[1] = true;
                break;
            case "air":
                if (alreadyPlayed[2] == false)
                    SwitchPlay("air");
                alreadyPlayed[2] = true;
                break;
            case "earth":
                if (alreadyPlayed[3] == false)
                    SwitchPlay("earth");
                alreadyPlayed[3] = true;
                break;
            case "dust":
                if (alreadyPlayed[4] == false)
                    SwitchPlay("dust");
                alreadyPlayed[4] = true;
                break;
            case "energy":
                if (alreadyPlayed[5] == false)
                    SwitchPlay("energy");
                alreadyPlayed[5] = true;
                break;
            case "gunpowder":
                if (alreadyPlayed[6] == false)
                    SwitchPlay("gunpowder");
                alreadyPlayed[6] = true;
                break;
            case "lava":
                if (alreadyPlayed[7] == false)
                    SwitchPlay("lava");
                alreadyPlayed[7] = true;
                break;
            case "mud":
                if (alreadyPlayed[8] == false)
                    SwitchPlay("mud");
                alreadyPlayed[8] = true;
                break;
            case "rain":
                if (alreadyPlayed[9] == false)
                    SwitchPlay("rain");
                alreadyPlayed[9] = true;
                break;
            case "steam":
                if (alreadyPlayed[10] == false)
                    SwitchPlay("steam");
                alreadyPlayed[10] = true;
                break;
        }
    }

    void SwitchPlay(string element)
    {
        StartCoroutine(TurnSliderOff());
        switch (element)
        {
            case "fire":
                panelImage.sprite = elementSprites[0];
                headerText.text = "You just created fire!";
                infoText.text = "Fire is one of the four basic elements.\nIt is a chemical reaction that releases light and heat.\nFuel, oxygen and heat is required for fire to burn.";
                guideText.text = "Create it again by selection fire on the UI!";
                break;
            case "water":
                panelImage.sprite = elementSprites[1];
                headerText.text = "You just created water!";
                infoText.text = "Water is one of the four basic elements.\nWater is composed of two elements, Hydrogen and oxygen.\nNearly 97% of the world's water is salty or undrinkable.";
                guideText.text = "Create it again by selection water on the UI!";
                break;
            case "air":
                panelImage.sprite = elementSprites[2];
                headerText.text = "You just created air!";
                infoText.text = "Air is one of the four basic elements.\nAir is mostly a gas, is all around us, but we can't see it.\nIt is a clear gas in which living things live and breath.";
                guideText.text = "Create it again by selection air on the UI!";
                break;
            case "earth":
                panelImage.sprite = elementSprites[3];
                headerText.text = "You just created earth!";
                infoText.text = "Earth is one of the four basic elements.\n1 tablespoon of earth has more organisms in it than there are people on earth.\nThere are 70,000 different types of earth in the U.S. alone.";
                guideText.text = "Create it again by selection earth on the UI!";
                break;
            case "dust":
                panelImage.sprite = elementSprites[4];
                headerText.text = "You just created dust!";
                infoText.text = "Most dust in the atmosphere came from the Sahara desert.\nAirborne dust helps create cloud condensation nuclei, which causes rain!\nThe average home generates 40 pounds of dust each year.";
                guideText.text = "Create it again by combining air and earth!";
                break;
            case "energy":
                panelImage.sprite = elementSprites[5];
                headerText.text = "You just created energy!";
                infoText.text = "A single lightning bolt releases 5 times more heat than the sun.\n60 minutes of solar energy could power the Earth for a year.\n10 Google searches can power a 60-watt lightbulb.";
                guideText.text = "Create it again by combining fire and air!";
                break;
            case "gunpowder":
                panelImage.sprite = elementSprites[6];
                headerText.text = "You just created gunpowder!";
                infoText.text = "It was invented by Chinese alchemists in the 9th century for use in fireworks.\nFor almost 1000 years, gunpowder was the only known way of creating explosive energy.\nGuy Fawkes was arrested on the 4th of November guarding 36 barrels of gunpowder.";
                guideText.text = "Create it again by combining dust and fire!";
                break;
            case "lava":
                panelImage.sprite = elementSprites[7];
                headerText.text = "You just created lava!";
                infoText.text = "Lava is what we call magma when it is above ground.\nThe shape of a volcano is influenced by the type of lava inside it.\nIt tends to flow quite slowly, making it easy to outrun.";
                guideText.text = "Create it again by combining earth and fire!";
                break;
            case "mud":
                panelImage.sprite = elementSprites[8];
                headerText.text = "You just created mud!";
                infoText.text = "Ancient Egyptians used mud to build their houses.\nMud pottery dates back to 27,000 BC.\nPigs bath in mud to stay cool.";
                guideText.text = "Create it again by combining earth and water!";
                break;
            case "rain":
                panelImage.sprite = elementSprites[9];
                headerText.text = "You just created rain!";
                infoText.text = "The familiar smell of rain is called 'Petrichor'.\nRaindrops are most in the shape of a jelly bean, rather than a teardrop.\nIt takes 2 minutes for a raindrop to hit the ground.";
                guideText.text = "Create it again by combining air and water!";
                break;
            case "steam":
                panelImage.sprite = elementSprites[10];
                headerText.text = "You just created steam!";
                infoText.text = "Steam is the name given to water when it is a gas.\nWater will turn into steam when it gets to 100 degrees celcius.\nA major use of steam was to power steam engines.";
                guideText.text = "Create it again by combining fire and water!";
                break;
        }
    }


    IEnumerator TurnSliderOff()
    {
        panelAnimator.SetBool("Slide", false);
        yield return new WaitForSeconds(0.01f);
        panelAnimator.SetBool("Slide", true);
        yield return new WaitForSeconds(10.0f);
        panelAnimator.SetBool("Slide", false);
    }
}
