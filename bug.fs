let mutable x = 0
let mutable y = 0

let rec loop i = 
    if i = 0 then
        ()
    else
        x <- x + i
        y <- y + 1
        loop (i - 1)

loop 10
printf "%d %d" x y