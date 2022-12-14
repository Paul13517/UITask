using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeImage : MonoBehaviour
{
    private Tween tween;
    [SerializeField] private Image img;
    IEnumerator Start()
    {
        tween = img.DOFade(0, 3f);
        yield return new WaitForSeconds(3f);
        tween = img.DOFade(1, 3f);
    }

 
}
