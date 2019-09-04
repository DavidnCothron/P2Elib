module RarityTraits

    type RarityTrait =
        | Common of string
        | Rare of string
        | Uncommon of string
        | Unique of string