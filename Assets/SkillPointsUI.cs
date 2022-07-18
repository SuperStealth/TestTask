using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillPointsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scorePointsText;
    [SerializeField] private Button earnButton;
    [SerializeField] private Button learnButton;
    [SerializeField] private Button forgetButton;
    [SerializeField] private Button forgetAllButton;

    public Action EarnAction;
    public Action LearnAction;
    public Action ForgetAction;
    public Action ForgetAllAction;

    private void Awake()
    {
        earnButton.onClick.AddListener(Earn);
        learnButton.onClick.AddListener(Learn);
        forgetButton.onClick.AddListener(Forget);
        forgetAllButton.onClick.AddListener(ForgetAll);
    }

    private void Earn()
    {

    }

    private void Learn()
    {

    }

    private void Forget()
    {

    }

    private void ForgetAll()
    {

    }

    private void OnDestroy()
    {
        earnButton.onClick.RemoveListener(Earn);
        learnButton.onClick.RemoveListener(Learn);
        forgetButton.onClick.RemoveListener(Forget);
        forgetAllButton.onClick.RemoveListener(ForgetAll);
    }
}
