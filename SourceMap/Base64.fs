namespace SourceMap

exception TypeError of string

module Base64 =
    let intToCharMap = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"
    
    // /**
    //  * Encode an integer in the range of 0 to 63 to a single base 64 digit.
    //  */
    let encode number =
      if 0 <= number && number < (String.length intToCharMap) then
        intToCharMap.[number]
      else
        invalidArg (nameof number) $"Must be between 0 and 63: {number}"
