using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlowBlocks : MonoBehaviour
{
    public float slowMotion = 10f;
   public void EndGame()
   {
      StartCoroutine(Restart());
   }
   IEnumerator Restart()
   {
    Time.timeScale = 1f / slowMotion;
    Time.fixedDeltaTime = Time.fixedDeltaTime / slowMotion;

    yield return new WaitForSeconds(1f/slowMotion);

    Time.timeScale = 1f;
    Time.fixedDeltaTime= Time.fixedDeltaTime * slowMotion;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
