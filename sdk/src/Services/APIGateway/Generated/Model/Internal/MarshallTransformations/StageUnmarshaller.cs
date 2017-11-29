/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Stage Object
    /// </summary>  
    public class StageUnmarshaller : IUnmarshaller<Stage, XmlUnmarshallerContext>, IUnmarshaller<Stage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Stage IUnmarshaller<Stage, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Stage Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Stage unmarshalledObject = new Stage();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accessLogSettings", targetDepth))
                {
                    var unmarshaller = AccessLogSettingsUnmarshaller.Instance;
                    unmarshalledObject.AccessLogSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cacheClusterEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CacheClusterEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cacheClusterSize", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CacheClusterSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cacheClusterStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CacheClusterStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("canarySettings", targetDepth))
                {
                    var unmarshaller = CanarySettingsUnmarshaller.Instance;
                    unmarshalledObject.CanarySettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientCertificateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientCertificateId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("documentationVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentationVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("methodSettings", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, MethodSetting, StringUnmarshaller, MethodSettingUnmarshaller>(StringUnmarshaller.Instance, MethodSettingUnmarshaller.Instance);
                    unmarshalledObject.MethodSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stageName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StageName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("variables", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Variables = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StageUnmarshaller _instance = new StageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}