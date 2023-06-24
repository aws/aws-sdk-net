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
    /// Response Unmarshaller for SourceConnectorProperties Object
    /// </summary>  
    public class SourceConnectorPropertiesUnmarshaller : IUnmarshaller<SourceConnectorProperties, XmlUnmarshallerContext>, IUnmarshaller<SourceConnectorProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SourceConnectorProperties IUnmarshaller<SourceConnectorProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SourceConnectorProperties Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SourceConnectorProperties unmarshalledObject = new SourceConnectorProperties();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Amplitude", targetDepth))
                {
                    var unmarshaller = AmplitudeSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Amplitude = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomConnector", targetDepth))
                {
                    var unmarshaller = CustomConnectorSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.CustomConnector = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Datadog", targetDepth))
                {
                    var unmarshaller = DatadogSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Datadog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dynatrace", targetDepth))
                {
                    var unmarshaller = DynatraceSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Dynatrace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GoogleAnalytics", targetDepth))
                {
                    var unmarshaller = GoogleAnalyticsSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.GoogleAnalytics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InforNexus", targetDepth))
                {
                    var unmarshaller = InforNexusSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.InforNexus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Marketo", targetDepth))
                {
                    var unmarshaller = MarketoSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Marketo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Pardot", targetDepth))
                {
                    var unmarshaller = PardotSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Pardot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3", targetDepth))
                {
                    var unmarshaller = S3SourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.S3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Salesforce", targetDepth))
                {
                    var unmarshaller = SalesforceSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Salesforce = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SAPOData", targetDepth))
                {
                    var unmarshaller = SAPODataSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.SAPOData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceNow", targetDepth))
                {
                    var unmarshaller = ServiceNowSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.ServiceNow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Singular", targetDepth))
                {
                    var unmarshaller = SingularSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Singular = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Slack", targetDepth))
                {
                    var unmarshaller = SlackSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Slack = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Trendmicro", targetDepth))
                {
                    var unmarshaller = TrendmicroSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Trendmicro = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Veeva", targetDepth))
                {
                    var unmarshaller = VeevaSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Veeva = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Zendesk", targetDepth))
                {
                    var unmarshaller = ZendeskSourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Zendesk = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SourceConnectorPropertiesUnmarshaller _instance = new SourceConnectorPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SourceConnectorPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}