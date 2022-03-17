using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PawnManager : MonoBehaviour
{
    public static PawnManager singleton;
    public s_Profession defaultProfession;

    private void Awake()
    {
        singleton = this;
    }

    public Pawn pawnPrefab;
    public List<Pawn> pawns;
    public List<s_Profession> professions;

    private void Update()
    {
        foreach (Pawn pawn in pawns)
        {
            try
            {
                pawn.UpdateBehavior();
            }
            catch(Exception e)
            {
                Debug.LogError(e.Message);
            }
        }
    }
}
