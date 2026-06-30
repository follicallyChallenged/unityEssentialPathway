using UnityEngine;
using TMPro;
using System.Collections;

public class BorderMessage : MonoBehaviour
{
    public GameObject messageUI;
    public float displayTime = 2f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            StartCoroutine(ShowMessage());
        }
    }

    IEnumerator ShowMessage()
    {
        messageUI.SetActive(true);
        yield return new WaitForSeconds(displayTime);
        messageUI.SetActive(false);
    }
}