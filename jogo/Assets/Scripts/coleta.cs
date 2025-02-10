using System.Collection;
using System.Collection.Generic;
using UnityEngine;
using UnityEngine.UI;




public class colectLamens : MonoBehaviour
{
    public Text scoreTxt;
    private int score;
    private void Start()
    {
        score = 0;
    }
    private void Update()
    {
        scoreTxt.Text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2d col)
    {
        if(col.CompareTag("lamens")==true)
        {
            score = score + 1;
            Destroy(col.gameObject);
        }
    }
}
using System.Collection;
using System.Collection.Generic;
using UnityEngine;
using UnityEngine.UI;




public class colectLamens : MonoBehaviour
{
    public Text scoreTxt;
    private int score;
    private void Start()
    {
        score = 0;
    }
    private void Update()
    {
        scoreTxt.Text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2d col)
    {
        if(col.CompareTag("lamens")==true)
        {
            score = score + 1;
            Destroy(col.gameObject);
        }
    }
}
