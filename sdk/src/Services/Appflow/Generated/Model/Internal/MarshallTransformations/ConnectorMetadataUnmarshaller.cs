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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConnectorMetadata Object
    /// </summary>  
    public class ConnectorMetadataUnmarshaller : IJsonUnmarshaller<ConnectorMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ConnectorMetadata Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ConnectorMetadata unmarshalledObject = new ConnectorMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Amplitude", targetDepth, ref reader))
                {
                    var unmarshaller = AmplitudeMetadataUnmarshaller.Instance;
                    unmarshalledObject.Amplitude = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CustomerProfiles", targetDepth, ref reader))
                {
                    var unmarshaller = CustomerProfilesMetadataUnmarshaller.Instance;
                    unmarshalledObject.CustomerProfiles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Datadog", targetDepth, ref reader))
                {
                    var unmarshaller = DatadogMetadataUnmarshaller.Instance;
                    unmarshalledObject.Datadog = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Dynatrace", targetDepth, ref reader))
                {
                    var unmarshaller = DynatraceMetadataUnmarshaller.Instance;
                    unmarshalledObject.Dynatrace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EventBridge", targetDepth, ref reader))
                {
                    var unmarshaller = EventBridgeMetadataUnmarshaller.Instance;
                    unmarshalledObject.EventBridge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GoogleAnalytics", targetDepth, ref reader))
                {
                    var unmarshaller = GoogleAnalyticsMetadataUnmarshaller.Instance;
                    unmarshalledObject.GoogleAnalytics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Honeycode", targetDepth, ref reader))
                {
                    var unmarshaller = HoneycodeMetadataUnmarshaller.Instance;
                    unmarshalledObject.Honeycode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InforNexus", targetDepth, ref reader))
                {
                    var unmarshaller = InforNexusMetadataUnmarshaller.Instance;
                    unmarshalledObject.InforNexus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Marketo", targetDepth, ref reader))
                {
                    var unmarshaller = MarketoMetadataUnmarshaller.Instance;
                    unmarshalledObject.Marketo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Pardot", targetDepth, ref reader))
                {
                    var unmarshaller = PardotMetadataUnmarshaller.Instance;
                    unmarshalledObject.Pardot = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Redshift", targetDepth, ref reader))
                {
                    var unmarshaller = RedshiftMetadataUnmarshaller.Instance;
                    unmarshalledObject.Redshift = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3", targetDepth, ref reader))
                {
                    var unmarshaller = S3MetadataUnmarshaller.Instance;
                    unmarshalledObject.S3 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Salesforce", targetDepth, ref reader))
                {
                    var unmarshaller = SalesforceMetadataUnmarshaller.Instance;
                    unmarshalledObject.Salesforce = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SAPOData", targetDepth, ref reader))
                {
                    var unmarshaller = SAPODataMetadataUnmarshaller.Instance;
                    unmarshalledObject.SAPOData = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServiceNow", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceNowMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceNow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Singular", targetDepth, ref reader))
                {
                    var unmarshaller = SingularMetadataUnmarshaller.Instance;
                    unmarshalledObject.Singular = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Slack", targetDepth, ref reader))
                {
                    var unmarshaller = SlackMetadataUnmarshaller.Instance;
                    unmarshalledObject.Slack = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Snowflake", targetDepth, ref reader))
                {
                    var unmarshaller = SnowflakeMetadataUnmarshaller.Instance;
                    unmarshalledObject.Snowflake = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Trendmicro", targetDepth, ref reader))
                {
                    var unmarshaller = TrendmicroMetadataUnmarshaller.Instance;
                    unmarshalledObject.Trendmicro = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Upsolver", targetDepth, ref reader))
                {
                    var unmarshaller = UpsolverMetadataUnmarshaller.Instance;
                    unmarshalledObject.Upsolver = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Veeva", targetDepth, ref reader))
                {
                    var unmarshaller = VeevaMetadataUnmarshaller.Instance;
                    unmarshalledObject.Veeva = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Zendesk", targetDepth, ref reader))
                {
                    var unmarshaller = ZendeskMetadataUnmarshaller.Instance;
                    unmarshalledObject.Zendesk = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConnectorMetadataUnmarshaller _instance = new ConnectorMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConnectorMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}