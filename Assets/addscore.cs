using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class addscore : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision){
        score.sc++;
    }
}
