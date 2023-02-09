namespace Account.Domain.Models

    open System

    [<AbstractClass>]
    type public BaseProduct(name:string)=
        let name =
            if String.IsNullOrEmpty(name) then
                raise (new ArgumentException("Name cannot be empty"))
            else
                name

        member this.Name with get() = name