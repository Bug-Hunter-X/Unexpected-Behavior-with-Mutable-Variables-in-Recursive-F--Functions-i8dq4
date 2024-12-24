# F# Mutable Variable Bug

This repository demonstrates a potential issue with mutable variables in recursive functions in F#. The `bug.fs` file contains code that exhibits unexpected behavior. The `bugSolution.fs` file provides a corrected version.

## Bug Description

The bug arises from the use of mutable variables (`x` and `y`) within a recursive function (`loop`).  The recursive calls modify the variables, but the final values might not match expectations due to the way mutable state is handled within the recursion.

## Solution

The solution avoids the use of mutable variables.  A more functional approach using accumulation or immutable data structures prevents the unexpected behavior.