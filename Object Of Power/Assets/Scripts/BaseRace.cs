using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRace : MonoBehaviour
{
    #region Reproduction
    //All reproduction method granted by the race
    private Dictionary<Reproduction, Pregnancy> m_DefaultReproduction;
    //Multiply the attractivness of member of this race when affecting member of other races not specified in the list of racial attractivness
    private float m_DefaultAttractivnessMultyplier;
    //Multiply the attractivness of member of this race when affecting members of the race selected (Race:Multiplyer)
    private Dictionary<BaseRace, float> m_SpecificRaceAttractivnessMultiplyer;
    //Multiply the Fertility of member of this race when affecting member of other races not specified in the list of racial Fertility
    private float m_DefaultFertilityMultyplier;
    //Multiply the Fertility of member of this race when affecting members of the race selected (Race:Multiplyer)
    private Dictionary<BaseRace, float> m_SpecificRaceFertilityMultiplyer;
    //Result of reproduction with specific races by type of reproduction (ex: Vampire sex: Vampire = PureBloodVampire, Vampire bite: (HumanSameSex = Goul / HumanDifferentSex = Vampire))
    private Dictionary<Dictionary<Dictionary<Reproduction, Pregnancy>,BaseRace>,BaseRace> m_ReproductionResults;
    #endregion
    #region RaceDefaults
    //All senses granted by the race
    private Dictionary<SensesPrimary, Dictionary<SensesSecondary, float>> m_DefaultSenses;
    //Default stats granted to an adult of this race
    private Dictionary<Stats, float> m_DefaultStats;
    //Default traits granted to an adult of this race
    private List<BaseTrait> m_DefaultTraits;
    //Default body for a generic memeber of this race
    private BaseBodyPart m_DefaultBody;
    //Lists of possible body parts for member of this race (may be identical to the parts of the default body or have more that are rarer ex: bloodline, or random ex:blue eye)
    private Dictionary<BodyParts, List<BaseBodyPart>> m_BodyPart;
    #endregion

    private string m_RaceName;
}
