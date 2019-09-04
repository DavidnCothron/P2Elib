module AlignmentTraits

    type AlignmentTrait =
        private
        | Chaotic of string
        | Evil of string
        | Good of string
        | Lawful of string