module Bonuses
    
    open Proficiency
    open Circumstance
    open Item
    open Status

    type Bonus = 
        private
        | ProficiencyBonus of ProficiencyBonus
        | CircumstanceBonus of CircumstanceBonus
        | ItemBonus of ItemBonus
        | StatusBonus of StatusBonus          
    
    module Bonus =
        let create bonusValue = 
            match bonusValue with
            | ProficiencyBonus i -> ProficiencyBonus i
            | CircumstanceBonus i -> CircumstanceBonus i
            | ItemBonus i -> ItemBonus i
            | StatusBonus i -> StatusBonus i

        let(|ProficiencyBonus|CircumstanceBonus|ItemBonus|StatusBonus|) bonus =
            match bonus with
            | ProficiencyBonus i -> ProficiencyBonus i
            | CircumstanceBonus i -> CircumstanceBonus i
            | ItemBonus i -> ItemBonus i
            | StatusBonus i -> StatusBonus i
            
    let getProficiencyBonus bonuses =
        let getProficiencyBonuses = 
            List.choose(fun (x) -> 
                match x with
                | ProficiencyBonus x -> Some x
                | _ -> None) bonuses
        let maxBonus = List.max(getProficiencyBonuses)
        getProficiency maxBonus

    let private getCircumstanceBonus bonuses =
        let getCircumstanceBonuses = 
            List.choose(fun (x) -> 
                match x with
                | CircumstanceBonus x -> Some x
                | _ -> None) bonuses
        let maxBonus = List.max(getCircumstanceBonuses)
        getCircumstance maxBonus

    let private getItemBonus bonuses =
        let getItemBonuses = 
            List.choose(fun (x) -> 
                match x with
                | ItemBonus x -> Some x
                | _ -> None) bonuses
        let maxBonus = List.max(getItemBonuses)
        getItem maxBonus

    let private getStatusBonus bonuses =
        let getStatusBonuses = 
            List.choose(fun (x) -> 
                match x with
                | StatusBonus x -> Some x 
                | _ -> None) bonuses
        let maxBonus = List.max(getStatusBonuses)
        getStatus maxBonus
        

    let calculate bonuses =
            let proficiencyBonus = getProficiencyBonus bonuses
            let addCircumstanceBonus otherBonuses = 
                let circumstanceBonus = getCircumstanceBonus bonuses + otherBonuses
                let addItemBonus otherBonuses = 
                    let itemBonus = getItemBonus bonuses + otherBonuses
                    let addStatusBonus otherBonuses =
                        getStatusBonus bonuses + otherBonuses
                    addStatusBonus itemBonus
                addItemBonus circumstanceBonus
            addCircumstanceBonus proficiencyBonus
            