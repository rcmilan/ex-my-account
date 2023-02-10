namespace Account.Business.ExchangeSchool.Services

module Services =

    open Account.Business.ExchangeSchool.Models

    let FindRange (priceRanges:PriceRange[], weekRange:int) =
        priceRanges |> Array.find (fun (pr) -> pr.RangeFrom <= weekRange && pr.RangeTo >= weekRange)

    let CalculatePriceRange (course:Course, weekRange:int) =
        let selectedRange = FindRange(course.PriceRanges, weekRange)

        selectedRange.Price * (decimal weekRange)