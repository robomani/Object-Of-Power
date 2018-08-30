using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBodyPart : MonoBehaviour
{
    //The type of this body part
    private BodyParts m_BodyPartType;
    //The type of body part this part can be on
    private List<BodyParts> m_LinkedBodyPartType;
    //The body part this part is on (And use it's capacity)
    private BaseBodyPart m_LinkedBodyPart;
    //Total space avalable on this part to add other parts
    private float m_TotalSpaceAvalable;
    //Space remaining to add part on this body part
    private float m_SpaceRemainig;
    //Cost in space for this body part on the linked body part
    private float m_SpaceCost;
    //Senses granted by this body part
    private Dictionary<SensesPrimary, Dictionary<SensesSecondary, float>> m_SensesAdded;
    //Reproductive capability addet by this body part
    private Dictionary<Reproduction, Pregnancy> m_SexeAdded;
    //Stats added by this body part
    private Dictionary<Stats, float> m_StatsAdded;
    //Traits added by this body part
    private List<BaseTrait> m_TraitsAdded;
    //Actions added by this body part
    private List<PossibleActions> m_ActionsAdded;
}
