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
    /// BatchPutLimitEntry Marshaller
    /// </summary>
    public class BatchPutLimitEntryMarshaller : IRequestMarshaller<BatchPutLimitEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchPutLimitEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDimensionKeys())
            {
                context.Writer.WritePropertyName("dimensionKeys");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDimensionKeysListValue in requestObject.DimensionKeys)
                {
                        context.Writer.WriteStringValue(requestObjectDimensionKeysListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEntries())
            {
                context.Writer.WritePropertyName("entries");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEntriesListValue in requestObject.Entries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LimitEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectEntriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRateLimitId())
            {
                context.Writer.WritePropertyName("rateLimitId");
                context.Writer.WriteStringValue(requestObject.RateLimitId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchPutLimitEntryMarshaller Instance = new BatchPutLimitEntryMarshaller();

    }
}