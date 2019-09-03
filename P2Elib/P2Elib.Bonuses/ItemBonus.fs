module Item

    type ItemBonus = private | Integer of int

    let getItem item = 
        match item with
        | Integer i -> i