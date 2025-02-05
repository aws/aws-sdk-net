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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContainerService Object
    /// </summary>  
    public class ContainerServiceUnmarshaller : IJsonUnmarshaller<ContainerService, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ContainerService Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ContainerService unmarshalledObject = new ContainerService();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("containerServiceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContainerServiceName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currentDeployment", targetDepth))
                {
                    var unmarshaller = ContainerServiceDeploymentUnmarshaller.Instance;
                    unmarshalledObject.CurrentDeployment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isDisabled", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsDisabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("location", targetDepth))
                {
                    var unmarshaller = ResourceLocationUnmarshaller.Instance;
                    unmarshalledObject.Location = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nextDeployment", targetDepth))
                {
                    var unmarshaller = ContainerServiceDeploymentUnmarshaller.Instance;
                    unmarshalledObject.NextDeployment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("power", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Power = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("powerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PowerId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("principalArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrincipalArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("privateDomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateDomainName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("privateRegistryAccess", targetDepth))
                {
                    var unmarshaller = PrivateRegistryAccessUnmarshaller.Instance;
                    unmarshalledObject.PrivateRegistryAccess = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("publicDomainNames", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, List<string>, StringUnmarshaller, JsonListUnmarshaller<string,StringUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.PublicDomainNames = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scale", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Scale = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stateDetail", targetDepth))
                {
                    var unmarshaller = ContainerServiceStateDetailUnmarshaller.Instance;
                    unmarshalledObject.StateDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("url", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Url = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ContainerServiceUnmarshaller _instance = new ContainerServiceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContainerServiceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}