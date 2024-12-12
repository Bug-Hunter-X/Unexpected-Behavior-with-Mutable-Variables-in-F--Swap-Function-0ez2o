let x = 10
let y = 20

let swap x y =
    let temp = x
    (y, temp)

let x', y' = swap x y
printf "%d %d" x' y'