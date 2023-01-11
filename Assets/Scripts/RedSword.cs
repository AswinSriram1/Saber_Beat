using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSword : MonoBehaviour
{
    public GameObject BlueSword;
    [SerializeField] GameObject panel;

    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Blue")
        {
            //Vibration.Vibrate(500);
            StartCoroutine(GameOver());
            
        }
        if (other.gameObject.tag == "Yellow")
        {
            gameObject.SetActive(false);
            BlueSword.SetActive(true);

        }
        if (other.gameObject.tag == "Red")
        {
            ScoreManager.instance.AddPoints();
            
        }
    }
    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2);
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
}
