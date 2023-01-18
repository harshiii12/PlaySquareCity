using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision_script : MonoBehaviour
{
    public Text Warnings;
    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "barriers")
        {
            StartCoroutine(WaitForTime());
        }
        if (collisioninfo.collider.gameObject.transform.parent.tag == "surroundings")
        {
            StartCoroutine(WaitForTime2());
        }
        if (collisioninfo.collider.gameObject.transform.parent.tag == "cone")
        {
            StartCoroutine(WaitForTime3());
        }

    }

    public IEnumerator WaitForTime()
    {
        Warnings.text = "Be Careful !";
        yield return new WaitForSeconds(2);
        Warnings.text = "";
    }
    public IEnumerator WaitForTime2()
    {
        Warnings.text = "That's not where you intended to go is it?";
        yield return new WaitForSeconds(3);
        Warnings.text = "";
    }
    public IEnumerator WaitForTime3()
    {
        Warnings.text = "What are you doing bro?";
        yield return new WaitForSeconds(3);
        Warnings.text = "";
    }
}
