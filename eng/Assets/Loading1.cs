using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading1 : MonoBehaviour
{
    [SerializeField]
    private float units;
    [SerializeField]
    private Image fill;



    private float fillAmount;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(BuildUnits());
    }

    // Update is called once per frame
    void Update()
    {
        UpdateBar();
    }

    private IEnumerator BuildUnits()
    {
        for (int i = 0; i <= units; i++)
        {
            fillAmount = i / units;
            Debug.Log(fillAmount);
            yield return null;
        }

        if (fillAmount == 1.0f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("main");
        }

    }
    private void UpdateBar()
    {
        fill.fillAmount = fillAmount;

    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
