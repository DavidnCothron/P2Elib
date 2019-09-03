module Proficiency

    type ProficiencyBonus = 
        private
        | Untrained of int
        | Trained of int
        | Expert of int
        | Master of int
        | Legendary of int
            
    // let trained = "Trained 2"
    // let expert = "Expert 4"
    // let master = "Master 6"
    // let legendary = "Legendary 8"
    // let untrained = "Untrained 0"

    module ProficiencyBonus = 
        let create i = 
            if i = 2 then Trained i
            elif i = 4 then Expert i
            elif i = 6 then Master i
            elif i = 8 then Legendary i
            elif i = 0 then Untrained i
            else failwith ("Value is not valid for a Proficiency: " + i.ToString())


        let(|Untrained|Trained|Expert|Master|Legendary|) proficiencyLevel = 
            match proficiencyLevel with
            | Trained i -> Trained i
            | Expert i -> Expert i
            | Master i -> Master i
            | Legendary i -> Legendary i
            | Untrained i -> Untrained (i * 0)  
            
    open ProficiencyBonus

    let getProficiency proficiencyLevel = 
        match proficiencyLevel with
            | Trained i -> i
            | Expert i -> i
            | Master i -> i
            | Legendary i -> i
            | Untrained i -> i 

    let proficiency level = 
        let calculateProficiency proficiency =
            match getProficiency proficiency with
                | 0 -> 0
                | i -> level + i
        calculateProficiency
        
        