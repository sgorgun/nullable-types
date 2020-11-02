## Task definition ##

Implement a [IsNull](NullableTypesTask/NullableTypeExtensions.cs#L13) extention method that privide  for nullable types the additional possibility of determining whether the nullable variable is null or not.
 
For example:
- for variable string name = "Kathy" => name.IsNull() -> false    
- for variable string name = null => name.IsNull() -> true    
- for the variable int? i = null => i.IsNull() -> true, etc.   