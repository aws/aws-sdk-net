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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsCodeBuildProjectEnvironment Object
    /// </summary>  
    public class AwsCodeBuildProjectEnvironmentUnmarshaller : IJsonUnmarshaller<AwsCodeBuildProjectEnvironment, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsCodeBuildProjectEnvironment Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsCodeBuildProjectEnvironment unmarshalledObject = new AwsCodeBuildProjectEnvironment();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Certificate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Certificate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnvironmentVariables", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsCodeBuildProjectEnvironmentEnvironmentVariablesDetails, AwsCodeBuildProjectEnvironmentEnvironmentVariablesDetailsUnmarshaller>(AwsCodeBuildProjectEnvironmentEnvironmentVariablesDetailsUnmarshaller.Instance);
                    unmarshalledObject.EnvironmentVariables = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImagePullCredentialsType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImagePullCredentialsType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PrivilegedMode", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.PrivilegedMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RegistryCredential", targetDepth))
                {
                    var unmarshaller = AwsCodeBuildProjectEnvironmentRegistryCredentialUnmarshaller.Instance;
                    unmarshalledObject.RegistryCredential = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsCodeBuildProjectEnvironmentUnmarshaller _instance = new AwsCodeBuildProjectEnvironmentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsCodeBuildProjectEnvironmentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}