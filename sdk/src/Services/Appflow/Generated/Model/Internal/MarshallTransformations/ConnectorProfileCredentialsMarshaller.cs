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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConnectorProfileCredentials Marshaller
    /// </summary>
    public class ConnectorProfileCredentialsMarshaller : IRequestMarshaller<ConnectorProfileCredentials, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectorProfileCredentials requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmplitude())
            {
                context.Writer.WritePropertyName("Amplitude");
                context.Writer.WriteStartObject();

                var marshaller = AmplitudeConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Amplitude, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomConnector())
            {
                context.Writer.WritePropertyName("CustomConnector");
                context.Writer.WriteStartObject();

                var marshaller = CustomConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomConnector, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatadog())
            {
                context.Writer.WritePropertyName("Datadog");
                context.Writer.WriteStartObject();

                var marshaller = DatadogConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Datadog, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynatrace())
            {
                context.Writer.WritePropertyName("Dynatrace");
                context.Writer.WriteStartObject();

                var marshaller = DynatraceConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Dynatrace, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGoogleAnalytics())
            {
                context.Writer.WritePropertyName("GoogleAnalytics");
                context.Writer.WriteStartObject();

                var marshaller = GoogleAnalyticsConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.GoogleAnalytics, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHoneycode())
            {
                context.Writer.WritePropertyName("Honeycode");
                context.Writer.WriteStartObject();

                var marshaller = HoneycodeConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Honeycode, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInforNexus())
            {
                context.Writer.WritePropertyName("InforNexus");
                context.Writer.WriteStartObject();

                var marshaller = InforNexusConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.InforNexus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMarketo())
            {
                context.Writer.WritePropertyName("Marketo");
                context.Writer.WriteStartObject();

                var marshaller = MarketoConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Marketo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPardot())
            {
                context.Writer.WritePropertyName("Pardot");
                context.Writer.WriteStartObject();

                var marshaller = PardotConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Pardot, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRedshift())
            {
                context.Writer.WritePropertyName("Redshift");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Redshift, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSalesforce())
            {
                context.Writer.WritePropertyName("Salesforce");
                context.Writer.WriteStartObject();

                var marshaller = SalesforceConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Salesforce, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSAPOData())
            {
                context.Writer.WritePropertyName("SAPOData");
                context.Writer.WriteStartObject();

                var marshaller = SAPODataConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.SAPOData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceNow())
            {
                context.Writer.WritePropertyName("ServiceNow");
                context.Writer.WriteStartObject();

                var marshaller = ServiceNowConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceNow, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSingular())
            {
                context.Writer.WritePropertyName("Singular");
                context.Writer.WriteStartObject();

                var marshaller = SingularConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Singular, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSlack())
            {
                context.Writer.WritePropertyName("Slack");
                context.Writer.WriteStartObject();

                var marshaller = SlackConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Slack, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnowflake())
            {
                context.Writer.WritePropertyName("Snowflake");
                context.Writer.WriteStartObject();

                var marshaller = SnowflakeConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Snowflake, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTrendmicro())
            {
                context.Writer.WritePropertyName("Trendmicro");
                context.Writer.WriteStartObject();

                var marshaller = TrendmicroConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Trendmicro, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVeeva())
            {
                context.Writer.WritePropertyName("Veeva");
                context.Writer.WriteStartObject();

                var marshaller = VeevaConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Veeva, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetZendesk())
            {
                context.Writer.WritePropertyName("Zendesk");
                context.Writer.WriteStartObject();

                var marshaller = ZendeskConnectorProfileCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Zendesk, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectorProfileCredentialsMarshaller Instance = new ConnectorProfileCredentialsMarshaller();

    }
}