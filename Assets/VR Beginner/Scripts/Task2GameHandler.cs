using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Task2GameHandler : MonoBehaviour
{
    private int correctGuesses;
    public List<GameObject> AnimalPictures;
    private GameObject randomAnimal;
    public GameObject PointsCount;
    public GameObject DogButton;
    public GameObject CatButton;
    public GameObject StartGameButton;
    public GameObject GoToTask3Button;
    private Text points;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject picture in AnimalPictures)
        {
            picture.SetActive(false);
        }

        points = PointsCount.GetComponent<Text>();
        GoToTask3Button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        StartGameButton.SetActive(false);
        showRandomAnimal();
        correctGuesses = 0;
    }

    private void showRandomAnimal()
    {
        
        int randomInt = Random.Range(0, AnimalPictures.Count);
        randomAnimal = AnimalPictures[randomInt];
        randomAnimal.SetActive(true);
    }

    public void DogClicked()
    {
        if (randomAnimal.CompareTag("dog"))
        {
            correctGuesses++;
            points.text = "Points: " + correctGuesses;
        }
        randomAnimal.SetActive(false);
        showRandomAnimal();
        checkIfFinished();
    }

    public void CatClicked()
    {
        if (randomAnimal.CompareTag("cat"))
        {
            correctGuesses++;
            points.text = "Points: " + correctGuesses;
        }
        randomAnimal.SetActive(false);
        showRandomAnimal();
        checkIfFinished();
    }

    private void checkIfFinished()
    {
        if (correctGuesses == 5)
        {
            GoToTask3Button.SetActive(true);
            DogButton.SetActive(false);
            CatButton.SetActive(false);
        }
    }
}
