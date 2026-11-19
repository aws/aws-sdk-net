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

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MskParameters Marshaller
    /// </summary>
    public partial class MskParametersMarshaller : IRequestMarshaller<MskParameters, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(MskParameters requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAcks())
            {
                context.Writer.WriteTextString("Acks");
                context.Writer.WriteTextString(requestObject.Acks);
            }

            if (requestObject.IsSetClientId())
            {
                context.Writer.WriteTextString("ClientId");
                context.Writer.WriteTextString(requestObject.ClientId);
            }

            if (requestObject.IsSetCompression())
            {
                context.Writer.WriteTextString("Compression");
                context.Writer.WriteTextString(requestObject.Compression);
            }

            if (requestObject.IsSetConnectivity())
            {
                context.Writer.WriteTextString("Connectivity");
                context.Writer.WriteTextString(requestObject.Connectivity);
            }

            if (requestObject.IsSetHeaders())
            {
                context.Writer.WriteTextString("Headers");
                context.Writer.WriteStartArray(requestObject.Headers.Count);
                foreach (var requestObjectHeadersListValue in requestObject.Headers)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = MskHeaderMarshaller.Instance;
                    marshaller.Marshall(requestObjectHeadersListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPartitionKey())
            {
                context.Writer.WriteTextString("PartitionKey");
                context.Writer.WriteTextString(requestObject.PartitionKey);
            }

            if (requestObject.IsSetTopicName())
            {
                context.Writer.WriteTextString("TopicName");
                context.Writer.WriteTextString(requestObject.TopicName);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static MskParametersMarshaller Instance = new MskParametersMarshaller();
    }
}
