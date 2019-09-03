module Circumstance

    type CircumstanceBonus = private | Integer of int

    let getCircumstance circumstance = 
        match circumstance with
        | Integer i -> i