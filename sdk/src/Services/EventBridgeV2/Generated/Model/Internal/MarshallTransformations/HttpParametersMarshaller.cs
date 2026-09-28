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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpParameters Marshaller
    /// </summary>
    public class HttpParametersMarshaller : IRequestMarshaller<HttpParameters, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HttpParameters requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetHeaderParameters())
            {
                context.Writer.WriteTextString("HeaderParameters");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectHeaderParametersKvp in requestObject.HeaderParameters)
                {
                    context.Writer.WriteTextString(requestObjectHeaderParametersKvp.Key);
                    var requestObjectHeaderParametersValue = requestObjectHeaderParametersKvp.Value;

                        context.Writer.WriteTextString(requestObjectHeaderParametersValue);
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetInvocationTimeoutSeconds())
            {
                context.Writer.WriteTextString("InvocationTimeoutSeconds");
                context.Writer.WriteTextString(requestObject.InvocationTimeoutSeconds);
            }
            if (requestObject.IsSetPathParameterValues())
            {
                context.Writer.WriteTextString("PathParameterValues");
                context.Writer.WriteStartArray(requestObject.PathParameterValues.Count);
                foreach(var requestObjectPathParameterValuesListValue in requestObject.PathParameterValues)
                {
                        context.Writer.WriteTextString(requestObjectPathParameterValuesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetQueryStringParameters())
            {
                context.Writer.WriteTextString("QueryStringParameters");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectQueryStringParametersKvp in requestObject.QueryStringParameters)
                {
                    context.Writer.WriteTextString(requestObjectQueryStringParametersKvp.Key);
                    var requestObjectQueryStringParametersValue = requestObjectQueryStringParametersKvp.Value;

                        context.Writer.WriteTextString(requestObjectQueryStringParametersValue);
                }
                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HttpParametersMarshaller Instance = new HttpParametersMarshaller();

    }
}