﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public ConstructManager m_ConstructManager;
    public List<Enemy> m_Enemies;

    public Transform GetTarget()
    {
        return m_ConstructManager.GetConstruct();
    }

    private void Update()
    {
        // Constantly checks and removes any null enemies (ones destroyed or cleared somehow)
        for (int i = m_Enemies.Count - 1; i >= 0; i--)
        {
            if (!m_Enemies[i])
            {
                m_Enemies.RemoveAt(i);
            }
        }
    }
}
