using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SemanticPercentage : MonoBehaviour
{
    public TextMeshProUGUI semanticName;
    public TextMeshProUGUI semanticTotalContribution;

    public void SetSemanticData(string semanticName, float semanticTotalContribution)
    {
        this.semanticName.text = semanticName;
        this.semanticTotalContribution.text = semanticTotalContribution.ToString();
    }
}
