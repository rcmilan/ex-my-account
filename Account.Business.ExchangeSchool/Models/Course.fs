namespace Account.Business.ExchangeSchool.Models

open Account.Domain.Models

type public Course(name:string, priceRanges:PriceRange[])=
    inherit BaseProduct(name)

    member this.PriceRanges with get() = priceRanges