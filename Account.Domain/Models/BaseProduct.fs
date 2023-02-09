namespace Account.Domain.Models

open System

[<AbstractClass>]
type public BaseProduct(name:string)=
    let name =
        if String.IsNullOrEmpty(name) then
            raise (new ArgumentException("Name cannot be empty"))
        else
            name
                
    let mutable isActive = true

    member this.Name with get() = name
    member this.IsActive with get() = isActive and set v = isActive <- v

    member this.ToggleIsActive() =
        isActive <- not isActive