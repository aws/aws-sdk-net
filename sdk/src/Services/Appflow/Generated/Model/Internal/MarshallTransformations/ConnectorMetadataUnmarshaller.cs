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
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConnectorMetadata Object
    /// </summary>  
    public class ConnectorMetadataUnmarshaller : IUnmarshaller<ConnectorMetadata, XmlUnmarshallerContext>, IUnmarshaller<ConnectorMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConnectorMetadata IUnmarshaller<ConnectorMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConnectorMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConnectorMetadata unmarshalledObject = new ConnectorMetadata();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Amplitude", targetDepth))
                {
                    var unmarshaller = AmplitudeMetadataUnmarshaller.Instance;
                    unmarshalledObject.Amplitude = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerProfiles", targetDepth))
                {
                    var unmarshaller = CustomerProfilesMetadataUnmarshaller.Instance;
                    unmarshalledObject.CustomerProfiles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Datadog", targetDepth))
                {
                    var unmarshaller = DatadogMetadataUnmarshaller.Instance;
                    unmarshalledObject.Datadog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dynatrace", targetDepth))
                {
                    var unmarshaller = DynatraceMetadataUnmarshaller.Instance;
                    unmarshalledObject.Dynatrace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventBridge", targetDepth))
                {
                    var unmarshaller = EventBridgeMetadataUnmarshaller.Instance;
                    unmarshalledObject.EventBridge = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GoogleAnalytics", targetDepth))
                {
                    var unmarshaller = GoogleAnalyticsMetadataUnmarshaller.Instance;
                    unmarshalledObject.GoogleAnalytics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Honeycode", targetDepth))
                {
                    var unmarshaller = HoneycodeMetadataUnmarshaller.Instance;
                    unmarshalledObject.Honeycode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InforNexus", targetDepth))
                {
                    var unmarshaller = InforNexusMetadataUnmarshaller.Instance;
                    unmarshalledObject.InforNexus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Marketo", targetDepth))
                {
                    var unmarshaller = MarketoMetadataUnmarshaller.Instance;
                    unmarshalledObject.Marketo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Pardot", targetDepth))
                {
                    var unmarshaller = PardotMetadataUnmarshaller.Instance;
                    unmarshalledObject.Pardot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Redshift", targetDepth))
                {
                    var unmarshaller = RedshiftMetadataUnmarshaller.Instance;
                    unmarshalledObject.Redshift = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3", targetDepth))
                {
                    var unmarshaller = S3MetadataUnmarshaller.Instance;
                    unmarshalledObject.S3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Salesforce", targetDepth))
                {
                    var unmarshaller = SalesforceMetadataUnmarshaller.Instance;
                    unmarshalledObject.Salesforce = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SAPOData", targetDepth))
                {
                    var unmarshaller = SAPODataMetadataUnmarshaller.Instance;
                    unmarshalledObject.SAPOData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceNow", targetDepth))
                {
                    var unmarshaller = ServiceNowMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceNow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Singular", targetDepth))
                {
                    var unmarshaller = SingularMetadataUnmarshaller.Instance;
                    unmarshalledObject.Singular = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Slack", targetDepth))
                {
                    var unmarshaller = SlackMetadataUnmarshaller.Instance;
                    unmarshalledObject.Slack = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Snowflake", targetDepth))
                {
                    var unmarshaller = SnowflakeMetadataUnmarshaller.Instance;
                    unmarshalledObject.Snowflake = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Trendmicro", targetDepth))
                {
                    var unmarshaller = TrendmicroMetadataUnmarshaller.Instance;
                    unmarshalledObject.Trendmicro = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Upsolver", targetDepth))
                {
                    var unmarshaller = UpsolverMetadataUnmarshaller.Instance;
                    unmarshalledObject.Upsolver = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Veeva", targetDepth))
                {
                    var unmarshaller = VeevaMetadataUnmarshaller.Instance;
                    unmarshalledObject.Veeva = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Zendesk", targetDepth))
                {
                    var unmarshaller = ZendeskMetadataUnmarshaller.Instance;
                    unmarshalledObject.Zendesk = unmarshaller.Unmarshall(context);
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