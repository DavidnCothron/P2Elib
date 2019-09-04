module PoisonTraits

    type PoisonTrait = 
        | Ingested of string
        | Inhaled of string
        | Injury of string
        | Poison of string