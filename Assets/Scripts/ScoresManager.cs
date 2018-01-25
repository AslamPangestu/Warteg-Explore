using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresManager : MonoBehaviour {

    public static ScoresManager Instance;

    [Header("Property")]
    public float coin;
    public float repPoint;
    public int rep;
    public float maxRepPoint;

    [Header("UI")]
    public Text coinLabel;
    public Text repPointLabel;
    public Text repLabel;
    public Image maxRepPointBar;
    public Text maxRepPointLabel;

    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {
        coin = 0f;
        coinLabel.text = coin.ToString();

        repPoint = 0f;
        repPointLabel.text = repPoint.ToString();

        rep = 0;
        repLabel.text = rep.ToString();

        maxRepPoint = 20;
        maxRepPointLabel.text = maxRepPoint.ToString();
    }

    private void Update()
    {
        if(rep == 3)
        {
            ScenesManager.Instance.WinScene();
        }else if(coin < 0)
        {
            ScenesManager.Instance.LoseScene();
        }
    }

    public void AddCoin()
    {
        coin += 5f;
        coinLabel.text = coin.ToString();
    }

    public void AddRep()
    {
        repPoint += 1;
        repPointLabel.text = repPoint.ToString();
        AddRepLevel();
    }

    public void AddRepLevel()
    {
        Level();
        if (repPoint > maxRepPoint-1)
        {
            rep++;
            repLabel.text = rep.ToString();
        }
    }

    public void Level()
    {
        if (rep == 0)
        {
            maxRepPointBar.fillAmount = 0;
            maxRepPoint = 20;
            maxRepPointLabel.text = maxRepPoint.ToString();
            maxRepPointBar.fillAmount = repPoint / maxRepPoint;
        }
        else if (rep == 1)
        {
            maxRepPointBar.fillAmount = 0;
            maxRepPoint = 40;
            repPoint = 0;
            maxRepPointLabel.text = maxRepPoint.ToString();
            maxRepPointBar.fillAmount = repPoint / maxRepPoint;
        }
        else if (rep == 2)
        {
            maxRepPointBar.fillAmount = 0;
            maxRepPoint = 60;
            repPoint = 0;
            maxRepPointLabel.text = maxRepPoint.ToString();
            maxRepPointBar.fillAmount = repPoint / maxRepPoint;
        }
    }
    public void DecCoin()
    {
        coin -= 2.5f;
        coinLabel.text = coin.ToString();
    }
}
