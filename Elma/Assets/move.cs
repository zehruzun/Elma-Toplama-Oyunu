using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class move : MonoBehaviour
{
    public int hiz;
    int score = 0;
    TextMeshProUGUI score_txt;

    public void Start()
    {
        score_txt = GameObject.Find("Canvas/score_txt").GetComponent<TextMeshProUGUI>(); 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "elma") {
            score += 10;
            score_txt.text = score.ToString();

            float rast = Random.Range(6.0f, -4.0f);
            collision.gameObject.transform.position = new Vector3(rast, 10.87f, -11.67f);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }
    }
}
