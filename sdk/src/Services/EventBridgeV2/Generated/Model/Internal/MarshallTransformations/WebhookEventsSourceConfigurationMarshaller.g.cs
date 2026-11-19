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
    /// WebhookEventsSourceConfiguration Marshaller
    /// </summary>
    public partial class WebhookEventsSourceConfigurationMarshaller : IRequestMarshaller<WebhookEventsSourceConfiguration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(WebhookEventsSourceConfiguration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAuthConfiguration())
            {
                context.Writer.WriteTextString("AuthConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = WebhookAuthConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthConfiguration, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetDeduplicationConfiguration())
            {
                context.Writer.WriteTextString("DeduplicationConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = WebhookDeduplicationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DeduplicationConfiguration, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetKmsKeyIdentifier())
            {
                context.Writer.WriteTextString("KmsKeyIdentifier");
                context.Writer.WriteTextString(requestObject.KmsKeyIdentifier);
            }

            if (requestObject.IsSetLogConfiguration())
            {
                context.Writer.WriteTextString("LogConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = LogConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfiguration, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetMetadataHttpHeaders())
            {
                context.Writer.WriteTextString("MetadataHttpHeaders");
                context.Writer.WriteStartArray(requestObject.MetadataHttpHeaders.Count);
                foreach (var requestObjectMetadataHttpHeadersListValue in requestObject.MetadataHttpHeaders)
                {
                    context.Writer.WriteTextString(requestObjectMetadataHttpHeadersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRoleArn())
            {
                context.Writer.WriteTextString("RoleArn");
                context.Writer.WriteTextString(requestObject.RoleArn);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static WebhookEventsSourceConfigurationMarshaller Instance = new WebhookEventsSourceConfigurationMarshaller();
    }
}
