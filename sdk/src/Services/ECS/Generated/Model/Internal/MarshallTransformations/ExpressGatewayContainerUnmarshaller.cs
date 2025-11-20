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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExpressGatewayContainer Object
    /// </summary>  
    public class ExpressGatewayContainerUnmarshaller : IUnmarshaller<ExpressGatewayContainer, XmlUnmarshallerContext>, IUnmarshaller<ExpressGatewayContainer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ExpressGatewayContainer IUnmarshaller<ExpressGatewayContainer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ExpressGatewayContainer Unmarshall(JsonUnmarshallerContext context)
        {
            ExpressGatewayContainer unmarshalledObject = new ExpressGatewayContainer();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("awsLogsConfiguration", targetDepth))
                {
                    var unmarshaller = ExpressGatewayServiceAwsLogsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AwsLogsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("command", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Command = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("containerPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ContainerPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environment", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeyValuePair, KeyValuePairUnmarshaller>(KeyValuePairUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("image", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("repositoryCredentials", targetDepth))
                {
                    var unmarshaller = ExpressGatewayRepositoryCredentialsUnmarshaller.Instance;
                    unmarshalledObject.RepositoryCredentials = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("secrets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Secret, SecretUnmarshaller>(SecretUnmarshaller.Instance);
                    unmarshalledObject.Secrets = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ExpressGatewayContainerUnmarshaller _instance = new ExpressGatewayContainerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExpressGatewayContainerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}