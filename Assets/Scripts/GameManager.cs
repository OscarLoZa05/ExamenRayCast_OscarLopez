using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text remainingClicks;
    public int remaining = 5;
    public bool youClick = false; 
    
    void Awake()
    {

        if(instance != null)
        {
            Destroy(gameObject);
        }
        else if(instance == null)
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    public IEnumerator Bucles(int number)
    {
        for (int i = 4; i > -1; i--)
        {
            yield return new WaitForSeconds(1);
            //remaining --;
            remainingClicks.text = i.ToString();
        }
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(number);
    }

    /*public IEnumerator Second(int number)
    {
        yield return new WaitForSeconds(1);
        remaining --;
        remainingClicks.text = remaining.ToString();
        yield return new WaitForSeconds(1);
        remaining --;
        remainingClicks.text = remaining.ToString();
        yield return new WaitForSeconds(1);
        remaining --;
        remainingClicks.text = remaining.ToString();
        yield return new WaitForSeconds(1);
        remaining --;
        remainingClicks.text = remaining.ToString();
        yield return new WaitForSeconds(1);
        remaining --;
        remainingClicks.text = remaining.ToString();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(number);
    }*/



    /*public IEnumerator Bucle(int number)
    {
        if(remaining > 0)
        {
            yield return new WaitForSeconds(1);
            remaining --;
            remainingClicks.text = remaining.ToString();
            StartBucle(number);
        }
        else if(remaining == 0)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(number);
        }
    }
    private void StartBucle(int numbers)
    {
        StartCoroutine(Bucle(numbers));
    }*/


    
}
