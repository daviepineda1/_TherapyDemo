using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BreathingManager : MonoBehaviour
{

    public GameObject startButton;
    public GameObject playerPos;
    public GameObject particleS; 
    private float startSpeed = 4f;
    public float inTime = 2;
    public float outTime = 2;
    ParticleSystem ps;
    void Start()
    {
        StartCoroutine(ShowButton());

    }

    // find the middle point between the UI and the player position 
    // place the particle system 
    // change the Start Speed and play and pause in the particle system 
    void ParticleFeatures(bool breathIn, float timer)
    {
        ps = particleS.GetComponent<ParticleSystem>();
        particleS.transform.position = (playerPos.transform.position + startButton.transform.position) / 2f;
      
        var main = ps.main;

        // main.duration = timer;
        if (!ps.isPlaying)
        {
            ps.Play();
        }
        main.startDelay = 0;
        main.startLifetime = timer;

        Debug.Log($"player pos: {playerPos.transform.position};" +
            $"UI pos: {startButton.transform.position};" +
            $"center point of PS: {particleS.transform.position}");


        if (breathIn)
        {
            main.startSpeed = startSpeed * -1;
        }
        else
        {
            main.startSpeed = startSpeed;

        }


        Debug.Log($"main speed is {main.startSpeed.constant }");


    }
    IEnumerator ShowButton()
    {
        startButton.SetActive(false);

        ParticleFeatures(true, inTime);
        yield return new WaitForSeconds(inTime);

        ParticleFeatures(false, inTime);

        yield return new WaitForSeconds(outTime);
        startButton.SetActive(true);
        if (ps.isPlaying)
        {
            ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);

        }
    }

   
}
