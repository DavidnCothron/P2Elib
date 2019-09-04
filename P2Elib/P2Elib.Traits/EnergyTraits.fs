module EnergyTraits

    type EnergyTrait =
        | Acid of string
        | Cold of string
        | Electricity of string
        | Fire of string
        | Force of string
        | Negative of string
        | Positive of string
        | Sonic of string