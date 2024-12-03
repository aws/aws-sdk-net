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
    /// The interface for unmarshalling a json error response.
    /// </summary>
    /// <typeparam name="T">The type to unmarshall.</typeparam>
    /// <typeparam name="TJsonUnmarshallerContext">The json unmarshaller context</typeparam>
    public interface IJsonErrorResponseUnmarshaller<T, TJsonUnmarshallerContext>
    {
        /// <summary>
        /// The unmarshall method accepts a context, the error response and a StreamingUTf8JsonReader and returns the modeled exception.
        /// </summary>
        /// <param name="context">The JSON Unmarshaller context</param>
        /// <param name="errorResponse">The error response</param>
        /// <param name="reader">The JSON reader</param>
        /// <returns>T, the error shape that is unmarshalled from the JSON context</returns>
        T Unmarshall(TJsonUnmarshallerContext context, ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader);
    }
}
