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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEventsEndpointDetails Marshaller
    /// </summary>
    public class AwsEventsEndpointDetailsMarshaller : IRequestMarshaller<AwsEventsEndpointDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEventsEndpointDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.Write(requestObject.Arn);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetEndpointId())
            {
                context.Writer.WritePropertyName("EndpointId");
                context.Writer.Write(requestObject.EndpointId);
            }

            if(requestObject.IsSetEndpointUrl())
            {
                context.Writer.WritePropertyName("EndpointUrl");
                context.Writer.Write(requestObject.EndpointUrl);
            }

            if(requestObject.IsSetEventBuses())
            {
                context.Writer.WritePropertyName("EventBuses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventBusesListValue in requestObject.EventBuses)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEventsEndpointEventBusesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectEventBusesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetReplicationConfig())
            {
                context.Writer.WritePropertyName("ReplicationConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEventsEndpointReplicationConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ReplicationConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetRoutingConfig())
            {
                context.Writer.WritePropertyName("RoutingConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEventsEndpointRoutingConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RoutingConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.Write(requestObject.State);
            }

            if(requestObject.IsSetStateReason())
            {
                context.Writer.WritePropertyName("StateReason");
                context.Writer.Write(requestObject.StateReason);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEventsEndpointDetailsMarshaller Instance = new AwsEventsEndpointDetailsMarshaller();

    }
}