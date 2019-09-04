module Traits

    open AlignmentTraits
    open AncestryTraits
    open ArmorTraits
    open ClassTraits
    open CreatureTypeTraits
    open ElementalTraits
    open EnergyTraits
    open MonsterTraits
    open PoisonTraits
    open RarityTraits
    open SchoolTraits
    open TraditionTraits
    open WeaponTraits
    open UntypedTraits

    type Trait = 
        | Alignment of AlignmentTrait
        | Ancestry of AncestryTrait
        | Armor of ArmorTrait
        | Class of ClassTrait
        | CreatureType of CreatureTypeTrait
        | Elemental of ElementalTrait
        | Energy of EnergyTrait
        | Monster of MonsterTrait
        | Poison of PoisonTrait
        | Rarity of RarityTrait
        | School of SchoolTrait
        | Tradition of TraditionTrait
        | Weapon of WeaponTrait
        | Untyped of UntypedTrait
        