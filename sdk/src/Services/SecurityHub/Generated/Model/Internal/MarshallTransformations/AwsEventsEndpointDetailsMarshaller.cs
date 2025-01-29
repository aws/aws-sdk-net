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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetEndpointId())
            {
                context.Writer.WritePropertyName("EndpointId");
                context.Writer.WriteStringValue(requestObject.EndpointId);
            }

            if(requestObject.IsSetEndpointUrl())
            {
                context.Writer.WritePropertyName("EndpointUrl");
                context.Writer.WriteStringValue(requestObject.EndpointUrl);
            }

            if(requestObject.IsSetEventBuses())
            {
                context.Writer.WritePropertyName("EventBuses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEventBusesListValue in requestObject.EventBuses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEventsEndpointEventBusesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectEventBusesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetReplicationConfig())
            {
                context.Writer.WritePropertyName("ReplicationConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsEventsEndpointReplicationConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ReplicationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetRoutingConfig())
            {
                context.Writer.WritePropertyName("RoutingConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsEventsEndpointRoutingConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RoutingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStringValue(requestObject.State);
            }

            if(requestObject.IsSetStateReason())
            {
                context.Writer.WritePropertyName("StateReason");
                context.Writer.WriteStringValue(requestObject.StateReason);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEventsEndpointDetailsMarshaller Instance = new AwsEventsEndpointDetailsMarshaller();

    }
}