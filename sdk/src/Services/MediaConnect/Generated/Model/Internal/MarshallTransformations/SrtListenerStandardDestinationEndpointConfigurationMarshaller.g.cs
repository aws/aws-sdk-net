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

using Amazon.MediaConnect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SrtListenerStandardDestinationEndpointConfiguration Marshaller
    /// </summary>
    public partial class SrtListenerStandardDestinationEndpointConfigurationMarshaller : IRequestMarshaller<SrtListenerStandardDestinationEndpointConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(SrtListenerStandardDestinationEndpointConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDestinationAddress())
            {
                context.Writer.WritePropertyName("destinationAddress");
                context.Writer.WriteStringValue(requestObject.DestinationAddress);
            }

            if (requestObject.IsSetDestinationIngestPort())
            {
                context.Writer.WritePropertyName("destinationIngestPort");
                context.Writer.WriteNumberValue(requestObject.DestinationIngestPort.Value);
            }

            if (requestObject.IsSetEncryptionPassphrase())
            {
                context.Writer.WritePropertyName("encryptionPassphrase");
                context.Writer.WriteStartObject();

                var marshaller = EndpointEncryptionSecretConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionPassphrase, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetMinimumLatencyMilliseconds())
            {
                context.Writer.WritePropertyName("minimumLatencyMilliseconds");
                context.Writer.WriteNumberValue(requestObject.MinimumLatencyMilliseconds.Value);
            }

            if (requestObject.IsSetStreamId())
            {
                context.Writer.WritePropertyName("streamId");
                context.Writer.WriteStringValue(requestObject.StreamId);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SrtListenerStandardDestinationEndpointConfigurationMarshaller Instance = new SrtListenerStandardDestinationEndpointConfigurationMarshaller();
    }
}
