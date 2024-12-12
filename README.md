# F# Mutable Variable Swap Bug

This example demonstrates a common pitfall when working with mutable variables in F#.  The `swap` function, as initially implemented, attempts to swap the values of two mutable variables. However, due to F#'s pass-by-reference semantics, it unexpectedly modifies the original variables directly instead of creating copies.

## Bug Description

The issue lies in how F# handles mutable variables.  When `x` and `y` are passed to the `swap` function, the function receives direct references to the original variables.  The assignment within the function directly modifies these original variables, leading to an outcome different from a typical value swap.

## Solution

The solution involves creating copies of the variables before swapping to work with values instead of references.