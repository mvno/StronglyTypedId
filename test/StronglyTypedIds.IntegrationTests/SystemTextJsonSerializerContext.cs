#if NET6_0_OR_GREATER
using System.Text.Json;
using System.Text.Json.Serialization;
using StronglyTypedIds.IntegrationTests.Types;

namespace StronglyTypedIds.IntegrationTests;

[JsonSerializable(typeof(GuidId1))]
[JsonSerializable(typeof(ConvertersGuidId))]
[JsonSerializable(typeof(ConvertersGuidId2))]
[JsonSerializable(typeof(GuidIdTests.TypeWithDictionaryKeys))]
internal partial class SystemTextJsonSerializerContext : JsonSerializerContext
{
    internal static SystemTextJsonSerializerContext Custom
        => new(new JsonSerializerOptions
        {
            Converters =
            {
                new GuidId1.GuidId1SystemTextJsonConverter(),
                new ConvertersGuidId.ConvertersGuidIdSystemTextJsonConverter(),
                new ConvertersGuidId2.ConvertersGuidId2SystemTextJsonConverter(),
            }
        });

    internal static SystemTextJsonSerializerContext Web
        => new(new JsonSerializerOptions()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters =
            {
                new GuidId1.GuidId1SystemTextJsonConverter(),
                new ConvertersGuidId.ConvertersGuidIdSystemTextJsonConverter(),
                new ConvertersGuidId2.ConvertersGuidId2SystemTextJsonConverter(),
            }
        });
}
#endif
