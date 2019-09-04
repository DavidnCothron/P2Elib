module ArmorTraits

    type ArmorTrait =
        private
        | Bulwark of string
        | Comfort of string
        | Flexible of string
        | Noisy of string