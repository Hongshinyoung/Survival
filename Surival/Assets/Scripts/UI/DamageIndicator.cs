using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageIndicator : MonoBehaviour
{
    public Image image;
    public float flashSpeed;

    private Coroutine coroutine;
    void Start()
    {
        CharacterManager.Instance.Player.condition.onTakeDamage += Flash;
    }

    public void Flash()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        image.enabled = true;
        image.color = new Color(135f / 255f, 0, 0);
        coroutine = StartCoroutine(FadeAway());
    }

    private IEnumerator FadeAway()
    {
        float startAlpha = 0.3f;
        float alpha = startAlpha;

        while(alpha > 0)
        {
            alpha -= (startAlpha / flashSpeed) * Time.deltaTime;
            image.color = new Color(135f/255f,0,0,alpha);
            yield return null;
        }
        image.enabled = false;
    }

}
