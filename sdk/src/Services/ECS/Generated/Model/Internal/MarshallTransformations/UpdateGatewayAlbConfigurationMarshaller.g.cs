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

using Amazon.ECS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGatewayAlbConfiguration Marshaller
    /// </summary>
    public partial class UpdateGatewayAlbConfigurationMarshaller : IRequestMarshaller<UpdateGatewayAlbConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(UpdateGatewayAlbConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAccessLogs())
            {
                context.Writer.WritePropertyName("accessLogs");
                context.Writer.WriteStartObject();

                var marshaller = GatewayElbAccessLogConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AccessLogs, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetHttpDesync())
            {
                context.Writer.WritePropertyName("httpDesync");
                context.Writer.WriteStringValue(requestObject.HttpDesync);
            }

            if (requestObject.IsSetMaxAlbCount())
            {
                context.Writer.WritePropertyName("maxAlbCount");
                context.Writer.WriteNumberValue(requestObject.MaxAlbCount.Value);
            }

            if (requestObject.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("networkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = UpdateGatewayNetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetTestTrafficRules())
            {
                context.Writer.WritePropertyName("testTrafficRules");
                context.Writer.WriteStartObject();

                var marshaller = GatewayAlbTestTrafficRulesMarshaller.Instance;
                marshaller.Marshall(requestObject.TestTrafficRules, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetWebACLArn())
            {
                context.Writer.WritePropertyName("webACLArn");
                context.Writer.WriteStringValue(requestObject.WebACLArn);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static UpdateGatewayAlbConfigurationMarshaller Instance = new UpdateGatewayAlbConfigurationMarshaller();
    }
}
