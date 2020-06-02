using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCredits : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 17f; // Scene will wait 17 seconds before loading desired Credits Scene allowing a cutscene to finish playing for example
    [SerializeField]
    private string Credits; 

    private float timeElaspsed; // private float for desired time to elapse

    private void Update()
    {
        timeElaspsed += Time.deltaTime;
        if (timeElaspsed > delayBeforeLoading) // if time elapsed equals 17f...
        {

            SceneManager.LoadScene("Quote");      // Then SceneManager will load desired Credits Scene

        }
    }
}