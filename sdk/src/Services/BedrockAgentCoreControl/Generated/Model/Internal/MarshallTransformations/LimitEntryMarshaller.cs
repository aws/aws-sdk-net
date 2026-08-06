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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LimitEntry Marshaller
    /// </summary>
    public class LimitEntryMarshaller : IRequestMarshaller<LimitEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LimitEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnections())
            {
                context.Writer.WritePropertyName("connections");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConnectionsListValue in requestObject.Connections)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RateConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectConnectionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("dimensions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDimensionsKvp in requestObject.Dimensions)
                {
                    context.Writer.WritePropertyName(requestObjectDimensionsKvp.Key);
                    var requestObjectDimensionsValue = requestObjectDimensionsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDimensionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequests())
            {
                context.Writer.WritePropertyName("requests");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRequestsListValue in requestObject.Requests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RateConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectRequestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTokens())
            {
                context.Writer.WritePropertyName("tokens");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTokensListValue in requestObject.Tokens)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RateConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectTokensListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LimitEntryMarshaller Instance = new LimitEntryMarshaller();

    }
}