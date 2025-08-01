using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1.6f);
        ExitDoor exitDoor = FindAnyObjectByType<ExitDoor>();
        transform.position = exitDoor.transform.position + new Vector3(-1.318f, 0, 0);
    }

    public IEnumerator ExitAndLeave(string nextLevel)
    {
      
        GetComponentInChildren<Animator>().SetTrigger("Exit");
        yield return new WaitForSeconds(1.6f);
        SceneManager.LoadScene(nextLevel);
    }
}
