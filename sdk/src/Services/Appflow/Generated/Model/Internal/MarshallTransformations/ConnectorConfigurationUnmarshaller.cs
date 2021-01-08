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
    /// Response Unmarshaller for ConnectorConfiguration Object
    /// </summary>  
    public class ConnectorConfigurationUnmarshaller : IUnmarshaller<ConnectorConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ConnectorConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConnectorConfiguration IUnmarshaller<ConnectorConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConnectorConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConnectorConfiguration unmarshalledObject = new ConnectorConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("canUseAsDestination", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CanUseAsDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("canUseAsSource", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CanUseAsSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorMetadata", targetDepth))
                {
                    var unmarshaller = ConnectorMetadataUnmarshaller.Instance;
                    unmarshalledObject.ConnectorMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isPrivateLinkEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsPrivateLinkEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isPrivateLinkEndpointUrlRequired", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsPrivateLinkEndpointUrlRequired = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportedDestinationConnectors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedDestinationConnectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportedSchedulingFrequencies", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedSchedulingFrequencies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportedTriggerTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedTriggerTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConnectorConfigurationUnmarshaller _instance = new ConnectorConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConnectorConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}