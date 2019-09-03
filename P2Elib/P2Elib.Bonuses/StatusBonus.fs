module Status

    type StatusBonus = private | Integer of int

    let getStatus status = 
        match status with
        | Integer i -> i