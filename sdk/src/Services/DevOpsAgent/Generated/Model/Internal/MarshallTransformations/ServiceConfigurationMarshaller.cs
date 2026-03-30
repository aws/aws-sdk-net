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
    /// ServiceConfiguration Marshaller
    /// </summary>
    public class ServiceConfigurationMarshaller : IRequestMarshaller<ServiceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServiceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAws())
            {
                context.Writer.WritePropertyName("aws");
                context.Writer.WriteStartObject();

                var marshaller = AWSConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Aws, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAzure())
            {
                context.Writer.WritePropertyName("azure");
                context.Writer.WriteStartObject();

                var marshaller = AzureConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Azure, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAzuredevops())
            {
                context.Writer.WritePropertyName("azuredevops");
                context.Writer.WriteStartObject();

                var marshaller = AzureDevOpsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Azuredevops, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynatrace())
            {
                context.Writer.WritePropertyName("dynatrace");
                context.Writer.WriteStartObject();

                var marshaller = DynatraceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Dynatrace, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEventChannel())
            {
                context.Writer.WritePropertyName("eventChannel");
                context.Writer.WriteStartObject();

                var marshaller = EventChannelConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EventChannel, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGithub())
            {
                context.Writer.WritePropertyName("github");
                context.Writer.WriteStartObject();

                var marshaller = GitHubConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Github, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGitlab())
            {
                context.Writer.WritePropertyName("gitlab");
                context.Writer.WriteStartObject();

                var marshaller = GitLabConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Gitlab, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMcpservergrafana())
            {
                context.Writer.WritePropertyName("mcpservergrafana");
                context.Writer.WriteStartObject();

                var marshaller = MCPServerGrafanaConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Mcpservergrafana, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMcpservernewrelic())
            {
                context.Writer.WritePropertyName("mcpservernewrelic");
                context.Writer.WriteStartObject();

                var marshaller = MCPServerNewRelicConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Mcpservernewrelic, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMsteams())
            {
                context.Writer.WritePropertyName("msteams");
                context.Writer.WriteStartObject();

                var marshaller = MSTeamsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Msteams, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPagerduty())
            {
                context.Writer.WritePropertyName("pagerduty");
                context.Writer.WriteStartObject();

                var marshaller = PagerDutyConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Pagerduty, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServicenow())
            {
                context.Writer.WritePropertyName("servicenow");
                context.Writer.WriteStartObject();

                var marshaller = ServiceNowConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Servicenow, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSlack())
            {
                context.Writer.WritePropertyName("slack");
                context.Writer.WriteStartObject();

                var marshaller = SlackConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Slack, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceAws())
            {
                context.Writer.WritePropertyName("sourceAws");
                context.Writer.WriteStartObject();

                var marshaller = SourceAwsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceAws, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServiceConfigurationMarshaller Instance = new ServiceConfigurationMarshaller();

    }
}