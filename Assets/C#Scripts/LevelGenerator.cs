using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    // Block prefableri
    [SerializeField] private GameObject[] roads;

    // Z pozisyon farklari
    [SerializeField] private float zGap = 25f;

    // Levelda kac adet bu yoldan bulunacagi / levelin uzunlugu
    [SerializeField] private int roadLength = 5;

    //Level basladiginda spawnlanmalari
    private void Awake()
    {
        // Sahne duzeni saglanmasi icin road parenti
        GameObject roadsParent = new GameObject("Roads Parent");
        // Blocklarin spawn loopu
        for (int i = 0; i < roadLength; i++)
        {
            // Spawnlanan yol
            GameObject spawnedRoad = Instantiate(roads[Random.Range(0, roads.Length)], roadsParent.transform);
            // Spawnlanan yolun pozisyonu
            spawnedRoad.transform.position = new Vector3(0, 0, i * zGap);
        }
    }
}
