﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using Assets.Scripts.Selection;
using Assets.Scripts.Interfaces;

class EvolutionGenerator : MonoBehaviour
{
    #region properties
    public SelectionName SelectionName;
    public GameObject Prefab;
    [Range(1,50)]public int Population = 1;

    private Vector2 _Position = new Vector2(0, 0);
    private Quaternion _Rotation = Quaternion.Euler(0, 0, 0);
    private ISelectable _Selection;
    #endregion

    private void Start()
    {
        _Selection = SelectionFactory.Selection(SelectionName);
        _Selection.Prefab = this.Prefab;
        _Selection.Position = this._Position;
        _Selection.Rotation = this._Rotation;
        _Selection.Population = this.Population;
    }

    private void CreateGeneration()
    {
        _Selection.CreateNewGeneration();
    }
}