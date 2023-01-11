using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSword : MonoBehaviour
{
    public GameObject redSword;
    [SerializeField] GameObject panel;


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Red")
        {
            //Vibration.Vibrate(500);
            StartCoroutine(GameOver());
        }
        if (other.gameObject.tag == "Yellow")
        {
            gameObject.SetActive(false);
            redSword.SetActive(true);

        }
        if (other.gameObject.tag == "Blue")
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
