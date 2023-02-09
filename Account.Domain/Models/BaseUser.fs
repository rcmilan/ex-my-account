namespace Account.Domain.Models

open System
open System.Text.RegularExpressions

[<AbstractClass>]
type public BaseUser(name: string, email: string) =
    let isValidEmail (email: string) =
        let regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
        regex.IsMatch(email)

    let name =
        if String.IsNullOrEmpty(name) then
            raise (new ArgumentException("Name cannot be empty"))
        else
            name

    let email =
        if not (isValidEmail email) then
            raise (new ArgumentException("Invalid email address"))
        else
            email

    let mutable isActive = true

    member this.Name with get() = name
    member this.Email with get() = email
    member this.IsActive with get() = isActive and set v = isActive <- v

    member this.ToggleIsActive() =
        isActive <- not isActive