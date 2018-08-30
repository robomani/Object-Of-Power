using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : BaseObject
{
    //Name of the clan of the character
    private string m_Clan;
    //Reproduction method of the character
    private Dictionary<Reproduction, Pregnancy> m_Reproduction;
    //Body of the character
    private BaseBodyPart m_Body;
}
