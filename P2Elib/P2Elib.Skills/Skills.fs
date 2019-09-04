module Skills
    
    open Bonuses
    open Traits

    type Skill = {
        name: string;
        ruleText: string;
        keyAbility: string; // Placeholder for Ability type
        keyAbilityModifier: int; // Placeholder for Ability type
        bonuses: Bonus list;
        traits: Trait list;
        actions: int list; // Placeholder for Action/Activity type
    } 
    
    type Skill with
        member this.skillModifier = this.keyAbilityModifier + Bonuses.calculate this.bonuses        
        member this.skillProficiency = Bonuses.getProficiencyBonus this.bonuses
        member this.isProficient = this.skillProficiency > 0
    
