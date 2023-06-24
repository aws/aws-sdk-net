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
                if (context.TestExpression("authenticationConfig", targetDepth))
                {
                    var unmarshaller = AuthenticationConfigUnmarshaller.Instance;
                    unmarshalledObject.AuthenticationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
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
                if (context.TestExpression("connectorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorLabel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorMetadata", targetDepth))
                {
                    var unmarshaller = ConnectorMetadataUnmarshaller.Instance;
                    unmarshalledObject.ConnectorMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorModes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ConnectorModes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorOwner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorOwner = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorProvisioningConfig", targetDepth))
                {
                    var unmarshaller = ConnectorProvisioningConfigUnmarshaller.Instance;
                    unmarshalledObject.ConnectorProvisioningConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorProvisioningType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorProvisioningType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorRuntimeSettings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ConnectorRuntimeSetting, ConnectorRuntimeSettingUnmarshaller>(ConnectorRuntimeSettingUnmarshaller.Instance);
                    unmarshalledObject.ConnectorRuntimeSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectorVersion = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("logoURL", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogoURL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("registeredAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RegisteredAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("registeredBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegisteredBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportedApiVersions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedApiVersions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportedDataTransferApis", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataTransferApi, DataTransferApiUnmarshaller>(DataTransferApiUnmarshaller.Instance);
                    unmarshalledObject.SupportedDataTransferApis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportedDataTransferTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedDataTransferTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportedDestinationConnectors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedDestinationConnectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("supportedOperators", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedOperators = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("supportedWriteOperations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedWriteOperations = unmarshaller.Unmarshall(context);
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