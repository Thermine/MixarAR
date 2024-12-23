using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetCondition : MonoBehaviour
{
    public static PetCondition instance;
    [SerializeField] private GameObject pet;
    [SerializeField] private ParticleSystem deathParticles;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance == this)
        {
            Destroy(gameObject);
        }
    }

    public void PetDeath()
    {
        Destroy(pet);
        deathParticles.Play();
    }
}
