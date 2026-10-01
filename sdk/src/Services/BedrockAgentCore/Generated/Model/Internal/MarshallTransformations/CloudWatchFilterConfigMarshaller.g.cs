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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CloudWatchFilterConfig Marshaller
    /// </summary>
    public partial class CloudWatchFilterConfigMarshaller : IRequestMarshaller<CloudWatchFilterConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CloudWatchFilterConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetSessionIds())
            {
                context.Writer.WritePropertyName("sessionIds");
                context.Writer.WriteStartArray();
                foreach (var requestObjectSessionIdsListValue in requestObject.SessionIds)
                {
                    context.Writer.WriteStringValue(requestObjectSessionIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSessionTraceIds())
            {
                context.Writer.WritePropertyName("sessionTraceIds");
                context.Writer.WriteStartArray();
                foreach (var requestObjectSessionTraceIdsListValue in requestObject.SessionTraceIds)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SessionTraceIdsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSessionTraceIdsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetTimeRange())
            {
                context.Writer.WritePropertyName("timeRange");
                context.Writer.WriteStartObject();

                var marshaller = SessionFilterConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeRange, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CloudWatchFilterConfigMarshaller Instance = new CloudWatchFilterConfigMarshaller();
    }
}
