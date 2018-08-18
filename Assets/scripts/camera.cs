﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform[] points;
    public GameObject[] nuvens;
    public float tempo_respawn;
    private float tempo_passado;

	// Use this for initialization
	void Start ()
    {

    }

	// Update is called once per frame
	void Update ()
    {
        tempo_passado += Time.deltaTime;
        if(tempo_passado >= tempo_respawn)
        {
            int ponto, nuvem;
            ponto = Random.Range(0, 5);
            nuvem = Random.Range(0, 5);
            Instantiate(nuvens[nuvem], points[ponto].position, points[ponto].rotation);
            tempo_passado = 0;
        }

	}
}
