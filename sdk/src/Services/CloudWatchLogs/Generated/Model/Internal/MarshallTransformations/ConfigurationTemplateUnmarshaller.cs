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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigurationTemplate Object
    /// </summary>  
    public class ConfigurationTemplateUnmarshaller : IUnmarshaller<ConfigurationTemplate, XmlUnmarshallerContext>, IUnmarshaller<ConfigurationTemplate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConfigurationTemplate IUnmarshaller<ConfigurationTemplate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ConfigurationTemplate Unmarshall(JsonUnmarshallerContext context)
        {
            ConfigurationTemplate unmarshalledObject = new ConfigurationTemplate();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allowedActionForAllowVendedLogsDeliveryForResource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AllowedActionForAllowVendedLogsDeliveryForResource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("allowedFieldDelimiters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedFieldDelimiters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("allowedFields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RecordField, RecordFieldUnmarshaller>(RecordFieldUnmarshaller.Instance);
                    unmarshalledObject.AllowedFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("allowedOutputFormats", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedOutputFormats = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("allowedSuffixPathFields", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedSuffixPathFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultDeliveryConfigValues", targetDepth))
                {
                    var unmarshaller = ConfigurationTemplateDeliveryConfigValuesUnmarshaller.Instance;
                    unmarshalledObject.DefaultDeliveryConfigValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deliveryDestinationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeliveryDestinationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("service", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Service = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConfigurationTemplateUnmarshaller _instance = new ConfigurationTemplateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigurationTemplateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}