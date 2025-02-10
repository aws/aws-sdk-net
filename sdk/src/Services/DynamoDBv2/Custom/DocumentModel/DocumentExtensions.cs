using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Extensions methods Document type.
    /// </summary>
    public static class DocumentExtensions
    {
        /// <summary>
        /// <para>
        /// Converts the current <see cref="IEnumerable{T}"/> of <see cref="Document"/> into a matching JSON string.
        /// </para>
        /// <para>
        /// DynamoDB types are a superset of JSON types, thus the following DynamoDB cannot
        /// be properly represented as JSON data:
        ///  PrimitiveList (SS, NS, BS types) - these sets will be converted to JSON arrays
        ///  Binary Primitive (B type) - binary data will be converted to Base64 strings
        /// </para>
        /// <para>
        /// If the resultant JSON is passed to Document.FromJson, the binary values will be
        /// treated as Base64 strings. Invoke Document.DecodeBase64Attributes to decode these
        /// strings into binary data.
        /// </para>
        /// </summary>
        /// <returns>JSON string corresponding to the current <see cref="IEnumerable{Document}"/>.</returns>
        public static string ToJson(this IEnumerable<Document> documents)
        {
            return SerializeEnumerable(documents, false);
        }

        /// <summary>
        /// <para>
        /// Converts the current <see cref="IEnumerable{T}"/> of <see cref="Document"/> into a matching pretty JSON string.
        /// </para>
        /// <para>
        /// DynamoDB types are a superset of JSON types, thus the following DynamoDB cannot
        /// be properly represented as JSON data:
        ///  PrimitiveList (SS, NS, BS types) - these sets will be converted to JSON arrays
        ///  Binary Primitive (B type) - binary data will be converted to Base64 strings
        /// </para>
        /// <para>
        /// If the resultant JSON is passed to Document.FromJson, the binary values will be
        /// treated as Base64 strings. Invoke Document.DecodeBase64Attributes to decode these
        /// strings into binary data.
        /// </para>
        /// </summary>
        /// <returns>JSON string corresponding to the current <see cref="IEnumerable{Document}"/>.</returns>
        public static string ToJsonPretty(this IEnumerable<Document> documents)
        {
            return SerializeEnumerable(documents, true);
        }

        private static string SerializeEnumerable(IEnumerable<Document> documents, bool prettyPrint)
        {
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { 
                Indented = prettyPrint 
            });

            writer.WriteStartArray();
            if (documents != null)
            {
                foreach (var document in documents)
                {
                    if (document != null)
                    {
                        JsonUtils.WriteJson(document, writer, DynamoDBEntryConversion.V2);
                    }
                }
            }
            writer.WriteEndArray();

            writer.Flush();
            return Encoding.UTF8.GetString(stream.ToArray());
        }
    }
}
