using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     public void YellowButton()
    {
        SceneManager.LoadScene("Sc3");
    }
    public void GreenButton()
    {
        SceneManager.LoadScene("Sc1");
    }
    public void BlueButton()
    {
        SceneManager.LoadScene("Sc2");
    }
}
