using UnityEngine;
using System.Collections.Generic;
using System;

public class LevelManager
{

    public static int level { get { return getLevel(); } }

    private static int getLevel()
    {
        // calculate the level according to level factors
        int value = 0;
        value += EnergyProvision.Instance.get();
        value -= EnergyConsumption.Instance.get();
        return value;
    }

    public static LevelFactor getLevelFactor(string key)
    {
        // load LevelFactor according to key
        LevelFactor levelFactor;
        switch (key)
        {
            case "Energy Provision":
                levelFactor = EnergyProvision.Instance;
                break;
            case "Energy Consumption":
                levelFactor = EnergyConsumption.Instance;
                break;
            default:
                levelFactor = EnergyProvision.Instance;
                break;
        }
        return levelFactor;
    }

    public static List<LevelFactor> getAllLevelFactors()
    {
        // load all LevelFactor
        List<LevelFactor> levelFactors = new List<LevelFactor>();
        levelFactors.Add(EnergyProvision.Instance);
        levelFactors.Add(EnergyConsumption.Instance);
        return levelFactors;
    }

}
