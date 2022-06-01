using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class again : MonoBehaviour
{
    public Image canbarý;
    float can = 100.0f;
    float suanki_can = 100.0f;
    public GameObject game_over;
    bool oyundurumu = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "elma")
        {
            float rast = Random.Range(6.0f, -4.0f);
            collision.gameObject.transform.position = new Vector3(rast, 10.87f, -11.67f);

            suanki_can -= 10.0f;
            canbarý.fillAmount = suanki_can / can;

            if (suanki_can <= 0.0f)
            {
                game_over.SetActive(true);
                Time.timeScale = 0.0f;
            }            
        }
    }

    public void tekrar()
    {
        SceneManager.LoadScene("Scenes/elma");
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        
    }
}
