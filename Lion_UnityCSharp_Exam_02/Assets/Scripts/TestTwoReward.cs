using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestTwoReward : MonoBehaviour
{
    [Header("獎品")]
    public Image reward;
    public Sprite[] rewards;
    public int rewardNumber;

    public void getReward()
    {
        rewardNumber = Random.Range(0, 24);
        reward.sprite = rewards[rewardNumber];
    }

}
