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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECRPublic.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ECRPublic.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Registry Object
    /// </summary>  
    public class RegistryUnmarshaller : IJsonUnmarshaller<Registry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Registry Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Registry unmarshalledObject = new Registry();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("aliases", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RegistryAlias, RegistryAliasUnmarshaller>(RegistryAliasUnmarshaller.Instance);
                    unmarshalledObject.Aliases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("registryArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegistryArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("registryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegistryId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("registryUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegistryUri = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("verified", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Verified = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RegistryUnmarshaller _instance = new RegistryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegistryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}