using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MagicBox : MonoBehaviour
{
    [SerializeField] private AudioSource UpMBox;
    public int mbox;
    public Text TextMbox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MagicBox")
        {
            mbox++;
            UpMBox.Play();
            other.gameObject.SetActive(false);
            TextMbox.text = mbox.ToString();
        }
    }

}
