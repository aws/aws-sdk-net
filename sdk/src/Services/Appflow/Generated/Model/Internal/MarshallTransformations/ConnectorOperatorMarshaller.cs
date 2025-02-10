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
    /// ConnectorOperator Marshaller
    /// </summary>
    public class ConnectorOperatorMarshaller : IRequestMarshaller<ConnectorOperator, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectorOperator requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmplitude())
            {
                context.Writer.WritePropertyName("Amplitude");
                context.Writer.WriteStringValue(requestObject.Amplitude);
            }

            if(requestObject.IsSetCustomConnector())
            {
                context.Writer.WritePropertyName("CustomConnector");
                context.Writer.WriteStringValue(requestObject.CustomConnector);
            }

            if(requestObject.IsSetDatadog())
            {
                context.Writer.WritePropertyName("Datadog");
                context.Writer.WriteStringValue(requestObject.Datadog);
            }

            if(requestObject.IsSetDynatrace())
            {
                context.Writer.WritePropertyName("Dynatrace");
                context.Writer.WriteStringValue(requestObject.Dynatrace);
            }

            if(requestObject.IsSetGoogleAnalytics())
            {
                context.Writer.WritePropertyName("GoogleAnalytics");
                context.Writer.WriteStringValue(requestObject.GoogleAnalytics);
            }

            if(requestObject.IsSetInforNexus())
            {
                context.Writer.WritePropertyName("InforNexus");
                context.Writer.WriteStringValue(requestObject.InforNexus);
            }

            if(requestObject.IsSetMarketo())
            {
                context.Writer.WritePropertyName("Marketo");
                context.Writer.WriteStringValue(requestObject.Marketo);
            }

            if(requestObject.IsSetPardot())
            {
                context.Writer.WritePropertyName("Pardot");
                context.Writer.WriteStringValue(requestObject.Pardot);
            }

            if(requestObject.IsSetS3())
            {
                context.Writer.WritePropertyName("S3");
                context.Writer.WriteStringValue(requestObject.S3);
            }

            if(requestObject.IsSetSalesforce())
            {
                context.Writer.WritePropertyName("Salesforce");
                context.Writer.WriteStringValue(requestObject.Salesforce);
            }

            if(requestObject.IsSetSAPOData())
            {
                context.Writer.WritePropertyName("SAPOData");
                context.Writer.WriteStringValue(requestObject.SAPOData);
            }

            if(requestObject.IsSetServiceNow())
            {
                context.Writer.WritePropertyName("ServiceNow");
                context.Writer.WriteStringValue(requestObject.ServiceNow);
            }

            if(requestObject.IsSetSingular())
            {
                context.Writer.WritePropertyName("Singular");
                context.Writer.WriteStringValue(requestObject.Singular);
            }

            if(requestObject.IsSetSlack())
            {
                context.Writer.WritePropertyName("Slack");
                context.Writer.WriteStringValue(requestObject.Slack);
            }

            if(requestObject.IsSetTrendmicro())
            {
                context.Writer.WritePropertyName("Trendmicro");
                context.Writer.WriteStringValue(requestObject.Trendmicro);
            }

            if(requestObject.IsSetVeeva())
            {
                context.Writer.WritePropertyName("Veeva");
                context.Writer.WriteStringValue(requestObject.Veeva);
            }

            if(requestObject.IsSetZendesk())
            {
                context.Writer.WritePropertyName("Zendesk");
                context.Writer.WriteStringValue(requestObject.Zendesk);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectorOperatorMarshaller Instance = new ConnectorOperatorMarshaller();

    }
}