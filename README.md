# TryGetHelper
Generic TryGet wrapper method that will wrap any delegate that may result in an exception with the standard TryGet interface.

## Example
```
int result;
if (TryGetHelper.TryGet(() => x / 0, out result));
  Console.WriteLine(result.ToString())
else
  Comsole.WriteLine("Error - cannot divide by zero.")
```
 
