using UnityEngine;
using TMPro;

public class PlanetManager : MonoBehaviour
{
    [Header("Planets")]
    public GameObject[] planets;

    [Header("UI")]
    public TextMeshProUGUI planetNameText;
    public TextMeshProUGUI planetInfoText;

    private int currentIndex = 0;

    [System.Serializable]
    public class PlanetData
    {
        public string planetName;
        [TextArea(3,5)]
        public string curiosities;
    }

    public PlanetData[] planetInfo;

    void Start()
    {
        UpdatePlanet();
    }

    public void NextPlanet()
    {
        currentIndex++;

        if (currentIndex >= planets.Length)
            currentIndex = 0;

        UpdatePlanet();
    }

    public void PreviousPlanet()
    {
        currentIndex--;

        if (currentIndex < 0)
            currentIndex = planets.Length - 1;

        UpdatePlanet();
    }

    void UpdatePlanet()
    {
        // Desactivar todos
        for (int i = 0; i < planets.Length; i++)
        {
            planets[i].SetActive(false);
        }

        // Activar actual
        planets[currentIndex].SetActive(true);

        // Actualizar textos
        planetNameText.text = planetInfo[currentIndex].planetName;
        planetInfoText.text = planetInfo[currentIndex].curiosities;
    }
}