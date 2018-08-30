using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTrait : MonoBehaviour
{
    #region Variables
    //Type of trait
    [SerializeField]
    private List<TraitsSources> m_Sources;
    //Required trait to gain this trait
    [SerializeField]
    private List<BaseTrait> m_RequiredTrait;
    //Required Senses: sub senses / minimum level of senses to gain this trait
    [SerializeField]
    private Dictionary<SensesPrimary, Dictionary<SensesSecondary, float>> m_RequiredSenses;
    //Senses: sub senses / maximum level of senses to gain this trait ex: require Sight:General/0 so require to be blind or Sight:Light/0 only require to be blind in lighted environments
    [SerializeField]
    private Dictionary<SensesPrimary, Dictionary<SensesSecondary, float>> m_ExcludedSenses;
    //All races that can gain this trait (If empty all races can gain this trait unless excluded)
    [SerializeField]
    private List<BaseRace> m_RequiredRace;
    //Races that can't gain this trait
    [SerializeField]
    private List<BaseRace> m_ExcludedRace;
    //Description of this trait
    [SerializeField]
    private string m_Description;
    //Impact of this trait on the maximum number of trait someone can have (Can be 0)
    [SerializeField]
    private float m_TraitCost;
    #endregion

    #region Getter/Setters
    public List<TraitsSources> Sources
    {
        get
        {
            return m_Sources;
        }

        set
        {
            m_Sources = value;
        }
    }

    public string Description
    {
        get
        {
            return m_Description;
        }

        set
        {
            m_Description = value;
        }
    }

    public float TraitCost
    {
        get
        {
            return m_TraitCost;
        }

        set
        {
            m_TraitCost = value;
        }
    }

    public List<BaseTrait> RequiredTrait
    {
        get
        {
            return m_RequiredTrait;
        }

        set
        {
            m_RequiredTrait = value;
        }
    }
    #endregion


}
