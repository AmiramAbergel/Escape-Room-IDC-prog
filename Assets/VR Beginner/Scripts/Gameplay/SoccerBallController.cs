using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class SoccerBallController : MonoBehaviour
{
    public XRGrabInteractable m_InteractableBase;
    public ParticleSystem devilHasBeenHit;
    Vector3 initialBallPosition = new Vector3(1f, -0.55f, 8f);
    public bool timerIsRunning = false;
    float timeUntilBallReturnsToPlace = 5f;
    float timeLeft = 0f;
    // Start is called before the first frame update
    void Start()
    {
        m_InteractableBase = GetComponent<XRGrabInteractable>();
        devilHasBeenHit = GameObject.Find("Particle System devil").GetComponent<ParticleSystem>();
        
        m_InteractableBase.onSelectExit.AddListener(ballHasBeenThrown);
    }

    // Update is called once per frame
    void Update()
    {
        // after ball is thrown 5 seconds go by until it
        // returns to its original position
        if (timerIsRunning)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0f)
            {
                gameObject.transform.position = initialBallPosition;
                timerIsRunning = false;
            }
        }
    }

    // if the soccer ball hits the devil then the particles will shoot out and the devil 
    // will disappear
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("devil"))
        {
            devilHasBeenHit.Play();
            other.gameObject.SetActive(false);
        }
    }

    void ballHasBeenThrown(XRBaseInteractor obj)
    {
        timerIsRunning = true;
        timeLeft = timeUntilBallReturnsToPlace;
    }
}
