    using System.Collections.Generic;
using Ducks;
using Unity.VisualScripting;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
    [SerializeField] private Duck[] ducks;

    private void Awake()
    {
        foreach (Duck d in ducks)
        {
            Duck newDuck = Instantiate(d, transform.position, transform.rotation);
        }

    }
}
