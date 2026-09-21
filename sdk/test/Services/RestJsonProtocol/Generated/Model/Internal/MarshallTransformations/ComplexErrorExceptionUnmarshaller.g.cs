/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Exception Unmarshaller for ComplexErrorException
    /// </summary>
    public partial class ComplexErrorExceptionUnmarshaller : IJsonErrorResponseUnmarshaller<ComplexErrorException, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the exception from the service to the appropriate exception class
        /// </summary>
        public ComplexErrorException Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse(), ref reader);
        }

        /// <summary>
        /// Unmarshall the exception from the service to the appropriate exception class
        /// </summary>
        public ComplexErrorException Unmarshall(JsonUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ComplexErrorException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);

            if (context.Stream.Length > 0)
            {
                context.Read(ref reader);
                int targetDepth = context.CurrentDepth;
                while (context.ReadAtDepth(targetDepth, ref reader))
                {
                    if (context.TestExpression("Nested", targetDepth, ref reader))
                    {
                        var unmarshaller = ComplexNestedErrorDataUnmarshaller.Instance;
                        unmarshalledObject.Nested = unmarshaller.Unmarshall(context, ref reader);
                        continue;
                    }

                    if (context.TestExpression("TopLevel", targetDepth, ref reader))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TopLevel = unmarshaller.Unmarshall(context, ref reader);
                        continue;
                    }
                }
            }
            if (context.ResponseData.IsHeaderPresent("X-Header"))
            {
                unmarshalledObject.Header = context.ResponseData.GetHeaderValue("X-Header");
            }

            return unmarshalledObject;
        }

        private static ComplexErrorExceptionUnmarshaller _instance = new ComplexErrorExceptionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ComplexErrorExceptionUnmarshaller Instance => _instance;
    }
}
