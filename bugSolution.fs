let rec loop i acc1 acc2 = 
    if i = 0 then
        acc1, acc2
    else
        loop (i - 1) (acc1 + i) (acc2 + 1)

let x, y = loop 10 0 0
printf "%d %d" x y