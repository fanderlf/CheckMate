module CheckMate.Domain

type User = {
  Username: string;
  PasswordHash: string;
}

let HashPassword password =
    password
    
let MatchPassword password user =
    user.PasswordHash = HashPassword password