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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsApiGatewayV2StageDetails Object
    /// </summary>  
    public class AwsApiGatewayV2StageDetailsUnmarshaller : IUnmarshaller<AwsApiGatewayV2StageDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsApiGatewayV2StageDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsApiGatewayV2StageDetails IUnmarshaller<AwsApiGatewayV2StageDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsApiGatewayV2StageDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsApiGatewayV2StageDetails unmarshalledObject = new AwsApiGatewayV2StageDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessLogSettings", targetDepth))
                {
                    var unmarshaller = AwsApiGatewayAccessLogSettingsUnmarshaller.Instance;
                    unmarshalledObject.AccessLogSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApiGatewayManaged", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ApiGatewayManaged = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoDeploy", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AutoDeploy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultRouteSettings", targetDepth))
                {
                    var unmarshaller = AwsApiGatewayV2RouteSettingsUnmarshaller.Instance;
                    unmarshalledObject.DefaultRouteSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeploymentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastDeploymentStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastDeploymentStatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdatedDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RouteSettings", targetDepth))
                {
                    var unmarshaller = AwsApiGatewayV2RouteSettingsUnmarshaller.Instance;
                    unmarshalledObject.RouteSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StageName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StageName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StageVariables", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.StageVariables = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsApiGatewayV2StageDetailsUnmarshaller _instance = new AwsApiGatewayV2StageDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsApiGatewayV2StageDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}