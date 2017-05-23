// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Recommendations.Client.Entities
{

    /// <summary>
    /// Defines values for Error.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error
    {
        [System.Runtime.Serialization.EnumMember(Value = "MalformedLine")]
        MalformedLine,
        [System.Runtime.Serialization.EnumMember(Value = "MissingFields")]
        MissingFields,
        [System.Runtime.Serialization.EnumMember(Value = "BadTimestampFormat")]
        BadTimestampFormat,
        [System.Runtime.Serialization.EnumMember(Value = "BadWeightFormat")]
        BadWeightFormat,
        [System.Runtime.Serialization.EnumMember(Value = "MalformedCatalogItemFeature")]
        MalformedCatalogItemFeature,
        [System.Runtime.Serialization.EnumMember(Value = "ItemIdTooLong")]
        ItemIdTooLong,
        [System.Runtime.Serialization.EnumMember(Value = "IllegalCharactersInItemId")]
        IllegalCharactersInItemId,
        [System.Runtime.Serialization.EnumMember(Value = "UserIdTooLong")]
        UserIdTooLong,
        [System.Runtime.Serialization.EnumMember(Value = "IllegalCharactersInUserId")]
        IllegalCharactersInUserId,
        [System.Runtime.Serialization.EnumMember(Value = "UnknownItemId")]
        UnknownItemId,
        [System.Runtime.Serialization.EnumMember(Value = "DuplicateItemId")]
        DuplicateItemId
    }
}