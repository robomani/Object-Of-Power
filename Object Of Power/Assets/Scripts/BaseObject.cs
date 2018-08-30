using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObject : MonoBehaviour
{
    //Name of the Object
    protected string m_Name;
    //Sences of the Object
    protected Dictionary<SensesPrimary, Dictionary<SensesSecondary, float>> m_Senses;
    //Stats of the Object
    protected Dictionary<Stats, float> m_Stats;
}
