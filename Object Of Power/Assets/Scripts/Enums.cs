public enum TraitsSources
{
    Mecanical,
    Magical,
    Soul,
    Biologic,
    Enchanting,
    Racial,
    Genetic,
}

public enum Races
{
    Human,
    Elf,
    Orc,
    Troll,
    Dwarf,
}

#region Senses
// https://en.wikipedia.org/wiki/Sense#Other_senses
public enum SensesPrimary
{
    Sight,
    Hearing,
    Taste,
    Smell,
    Touch,
    Internal_Sense, // Sensing own internal process ex: hunger, internal co2(need to breath), injury, ect...
    Proprioception, //Sensing and keping track of own body and body part in space without use of other senses (Useful for invisible, blind, hive mind, ect...)
    Agency, //Capacity to chose, resist control
    Memory,
    Soul,
}

public enum SensesSecondary
{
    General, // Basic sense, Limit the level of other SubSenses of this sense
    Control, // Resistance to attacks against this sense, hability to focus or dull this sense and rapidity to change uses of this sense ex:Light vision to LoLight vision
    Physical,
    Astral,
    Dimentional,
    Sound,
    Balance,
    Termal,
    Light,
    LowLight,
    Dark,
    Electricity,
    Magnetism,
    Pain,
    Sexual_Stimulation,
    Time,
    Space,
    Gravity,
    Echolocation,
    Hygroreception, //humidity
    Rhythm,
    Magic,
    Soul,
}
#endregion
#region Reproduction 
public enum Reproduction
{
    None, // Can't reproduce ex: robot, golem, sentient objects, any non biologic entity without specific way to reproduce
    Male, //Reproduce with a female
    Female, // Reproduce with a male
    Adaptive, // Can reproduce with male and females and possibly other ex: shapeshifter, parasites  
    Self, // Can reproduce without need of another being ex: division, constructing other parts(ex: Hive mind robot)
}


public enum Pregnancy
{
    None, // Don't reproduce or is sterile
    Fertilise,  
    CarryInBody, // Carry offspring in the body until birth (Can cause stat drop during pregnency and health loss the presence certain traits before birth can cause the death of the offspring)
    LayEggFertilised, // Lay eggs that were fertilised in the body the health and traits of the one Laying the egg are of limited importance to the survival of the offspring, but the egg must be in acceptable condition until birth or risk the death of the offspring.
    LayEggUnfertilised, //Lay unfertilised eggs that need to be fertilised outside of the body. The health of the one laying the egg is of no importance to the survival of the offspring
    Self_Division, // Multiply by using internal ressources to create a new being health loss and negative traits affect all implicated and until the division end death of any part can cause serious damage to the others.
    Construct_Body, // Multiply by using external ressources to create a new being part of the hive mind. Material quality and skill affect the quality of the new body.
    Infect_Living, // Infect a living host, the offspring depend on the host for survival and health loss and certain traits can cause the death of the offspring
    Infect_Dead, // Infect a dead host, destruction or degradation of the host can cause the death of the offspring 
    Infect_Soul, // Infect a soul, change to the environment of the host soul (death of the body if the soul has one/ sealing of the soul in an object or damage of the soul) can cause the death of the offspring
}
#endregion
public enum Stats
{
    Stenght,
    Dexterity,
    Constitution,
    Inteligence,
    Wisdom,
    Perception,
    Charisma,
    Attractivness,
    Luck,
    Health,
    Mana,
    Stamina,
    Longevity, //Lenght of the life of the character or average for the race
    MaturationSpeed, // number of years to adulthood (Can reproduce, has all basic stat of race)
    LearningSpeed, // How quickly can learn new things and correct previously held beliefs whe proven false
    Fertility, //Average Number of surviving children per year (per partner if not carring in the body)
}

public enum BodyParts
{
    Head, 
    Mouth,
    Torso,
    Arm,
    Hand,
    Leg,
    Foot,
    Tail,
    Bone,
    Skin, // Troll, metal, rock, hide, cameleon, ect...
    SkinCovering, // ex: Fur, scales, Rock plates, bone spikes, ect...
    Organ, // ex: Eye, Core(magic, monster, ect...), heart, Brain, ect...
    System, // ex: Respiratory, immune, circulatory, chakra
}

public enum ActionsTypes
{
    //Default,
    //Favorite,
    Environment,
    Physical,   
    Skill,
    Supernatural,
    Follower,
    Equipment,
}