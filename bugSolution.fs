let mutable x = 1
let mutable y = 2
let mutable z = x + y
printf "%d\n" z
x <- 3
z <- x + y
printf "%d\n" z