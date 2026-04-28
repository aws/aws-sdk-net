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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServiceDetails Marshaller
    /// </summary>
    public class ServiceDetailsMarshaller : IRequestMarshaller<ServiceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServiceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAzureidentity())
            {
                context.Writer.WritePropertyName("azureidentity");
                context.Writer.WriteStartObject();

                var marshaller = RegisteredAzureIdentityDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Azureidentity, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynatrace())
            {
                context.Writer.WritePropertyName("dynatrace");
                context.Writer.WriteStartObject();

                var marshaller = DynatraceServiceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Dynatrace, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEventChannel())
            {
                context.Writer.WritePropertyName("eventChannel");
                context.Writer.WriteStartObject();

                var marshaller = EventChannelDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.EventChannel, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGitlab())
            {
                context.Writer.WritePropertyName("gitlab");
                context.Writer.WriteStartObject();

                var marshaller = GitLabDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Gitlab, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMcpserver())
            {
                context.Writer.WritePropertyName("mcpserver");
                context.Writer.WriteStartObject();

                var marshaller = MCPServerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mcpserver, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMcpserverdatadog())
            {
                context.Writer.WritePropertyName("mcpserverdatadog");
                context.Writer.WriteStartObject();

                var marshaller = DatadogServiceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mcpserverdatadog, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMcpservergrafana())
            {
                context.Writer.WritePropertyName("mcpservergrafana");
                context.Writer.WriteStartObject();

                var marshaller = GrafanaServiceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mcpservergrafana, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMcpservernewrelic())
            {
                context.Writer.WritePropertyName("mcpservernewrelic");
                context.Writer.WriteStartObject();

                var marshaller = NewRelicServiceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mcpservernewrelic, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMcpserversplunk())
            {
                context.Writer.WritePropertyName("mcpserversplunk");
                context.Writer.WriteStartObject();

                var marshaller = MCPServerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Mcpserversplunk, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPagerduty())
            {
                context.Writer.WritePropertyName("pagerduty");
                context.Writer.WriteStartObject();

                var marshaller = PagerDutyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Pagerduty, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServicenow())
            {
                context.Writer.WritePropertyName("servicenow");
                context.Writer.WriteStartObject();

                var marshaller = ServiceNowServiceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Servicenow, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServiceDetailsMarshaller Instance = new ServiceDetailsMarshaller();

    }
}