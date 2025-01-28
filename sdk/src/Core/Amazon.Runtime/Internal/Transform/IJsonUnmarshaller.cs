using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// Interface for JSON unmarshallers which unmarshall objects from response data.
    /// The Unmarshallers are stateless, and only encode the rules for what data in
    /// the JSON stream goes into what members of an object.
    /// </summary>
    /// <typeparam name="T">The type of object the unmarshaller returns</typeparam>
    /// <typeparam name="TJsonUnmarshallerContext">The type of the Unmarshaller context. This can be any context that
    /// inherits from JsonUnmarshallerContext or JsonUnmarshallerContext itself. The context contains the
    /// state during parsing of the JSON stream.</typeparam>
    public interface IJsonUnmarshaller<T, TJsonUnmarshallerContext>
    {
        /// <summary>
        /// Given the current position in the JSON stream, extract a T.
        /// </summary>
        /// <param name="input">The JSON parsing context</param>
        /// <param name="reader">The Utf8JsonReader in the System Text JSON namespace</param>
        /// <returns>An object of type T populated with data from the JSON stream.</returns>
        T Unmarshall(TJsonUnmarshallerContext input, ref StreamingUtf8JsonReader reader);
    }
}