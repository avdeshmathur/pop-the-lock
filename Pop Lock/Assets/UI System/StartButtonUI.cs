using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButtonUI : MonoBehaviour
{
    float WaitTime = 1.5f;
    public Animator anim;

    private void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Anim").GetComponent<Animator>();
    }

    public void StartGame()
    {
        StartCoroutine(Play());
    }
    
    IEnumerator Play()
    {
        anim.SetTrigger("DoAnimation");
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene("TestGame");
    }
}
