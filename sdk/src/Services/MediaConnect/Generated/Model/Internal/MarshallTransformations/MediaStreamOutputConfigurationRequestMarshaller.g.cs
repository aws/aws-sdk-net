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
    /// MediaStreamOutputConfigurationRequest Marshaller
    /// </summary>
    public partial class MediaStreamOutputConfigurationRequestMarshaller : IRequestMarshaller<MediaStreamOutputConfigurationRequest, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(MediaStreamOutputConfigurationRequest requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDestinationConfigurations())
            {
                context.Writer.WritePropertyName("destinationConfigurations");
                context.Writer.WriteStartArray();
                foreach (var requestObjectDestinationConfigurationsListValue in requestObject.DestinationConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DestinationConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectDestinationConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetEncodingName())
            {
                context.Writer.WritePropertyName("encodingName");
                context.Writer.WriteStringValue(requestObject.EncodingName);
            }

            if (requestObject.IsSetEncodingParameters())
            {
                context.Writer.WritePropertyName("encodingParameters");
                context.Writer.WriteStartObject();

                var marshaller = EncodingParametersRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.EncodingParameters, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetMediaStreamName())
            {
                context.Writer.WritePropertyName("mediaStreamName");
                context.Writer.WriteStringValue(requestObject.MediaStreamName);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static MediaStreamOutputConfigurationRequestMarshaller Instance = new MediaStreamOutputConfigurationRequestMarshaller();
    }
}
