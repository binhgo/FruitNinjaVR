﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager Instance;

    private List<Level> levels = new List<Level>();


    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(gameObject);
        }

        InitLevels();
    }



    public Level GetFirstLevel()
    {
        return levels[0];
    }

    public Level GetNextLevel(Level currentLevel)
    {
        if (currentLevel.level < levels.Count)
        {
            return levels[currentLevel.level];
        }
        else
        {
            return null;
        }
    }

    public Level ResetCurrentLevel(Level currentLevel)
    {
        return levels[currentLevel.level - 1];
    }


    void InitLevels()
    {
        Level level1 = new Level();
        level1.level = 1;
        level1.levelTime = 30;
        level1.maxOnSceneBoom = 3;
        level1.minOnSceneBoom = 0;
        level1.maxOnSceneFruits = 5;
        level1.minOnsceneFruits = 2;

        Level level2 = new Level();
        level2.level = 2;
        level2.levelTime = 45;
        level2.maxOnSceneBoom = 3;
        level2.minOnSceneBoom = 1;
        level2.maxOnSceneFruits = 5;
        level2.minOnsceneFruits = 3;

        Level level3 = new Level();
        level3.level = 3;
        level3.levelTime = 60;
        level3.maxOnSceneBoom = 4;
        level3.minOnSceneBoom = 2;
        level3.maxOnSceneFruits = 6;
        level3.minOnsceneFruits = 3;

        levels.Add(level1);
        levels.Add(level2);
        levels.Add(level3);
    }
}
