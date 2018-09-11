using System;
using System.Linq;

namespace Helpers.Helpers
{
    public static class MapperHelper
    {
        public static TOutput Map<TInput, TOutput>(TInput inputObject)
            where TOutput : class
        {
            var inputProperties = inputObject.GetType().GetProperties();
            var outputProperties = typeof(TOutput).GetProperties();

            // Will be returning this object
            var outputResponse = Activator.CreateInstance(typeof(TOutput));

            foreach (var inputProperty in inputProperties)
            {
                // If the output object type contains a property with the same name
                if (outputProperties.Any(p => p.Name == inputProperty.Name))
                {
                    // Set the value of this property on the output response object
                    outputResponse.GetType()
                        .GetProperty(inputProperty.Name)
                        ?.SetValue(outputResponse, inputProperty.GetValue(inputObject), null);
                }
            }

            return (TOutput) outputResponse;
        }
        
        public static void OutputProperties<T>(T inputObject)
        {
            var properties = inputObject.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name} : {property.GetValue(inputObject)}");
            }
        }
    }
}