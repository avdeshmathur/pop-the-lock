using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUp : MonoBehaviour
{
    List<Animator> anim;
    float WaitSec = 0.2f;
    float WaitEnd = 0.5f;

    void Start()
    {
        anim = new List<Animator>(GetComponentsInChildren<Animator>());
        StartCoroutine(DoAnim());
    }
    
    IEnumerator DoAnim()
    {
        while (true)
        {
            foreach(var a in anim)
            {
                a.SetTrigger("DoAnim"); 
                yield return new WaitForSeconds(WaitSec);
            }
            yield return new WaitForSeconds(WaitEnd);
        }
    }
}
