using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] position;
    public float moveSpeed;
    public float spawn;
    private float timer;


    private void Awake()
    {
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawn)
        {
            GameObject Cube = Instantiate(cubes[Random.Range(0, 3)], position[Random.Range(0, 4)]);
            Destroy(Cube, 10f);
            
            timer -= spawn;
        }
        timer += Time.deltaTime;
    }
    
    public void RestartScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
