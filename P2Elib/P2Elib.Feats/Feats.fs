module Feats

    open Traits
    open Skills
    
    type FeatDetail = {
        name: string;
        level: int;
        traits: Trait list;
        ruleText: string;
    }

    type Feat =
        | ClassFeat of FeatDetail
        | GeneralFeat of FeatDetail
        | AncestryFeat of FeatDetail