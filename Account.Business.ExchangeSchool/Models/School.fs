namespace Account.Business.ExchangeSchool.Models

open System

type public School(name:string, courses:Course[])=
    let name =
        if String.IsNullOrEmpty(name) then
            raise (new ArgumentException("Name cannot be empty"))
        else
            name
                
    let mutable isActive = true

    member this.Name with get() = name
    member this.Courses with get() = courses

    member this.IsActive with get() = isActive and set v = isActive <- v

    member this.ToggleIsActive() =
        isActive <- not isActive