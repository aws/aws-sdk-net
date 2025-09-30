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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SparkEmrPropertiesOutput Object
    /// </summary>  
    public class SparkEmrPropertiesOutputUnmarshaller : IUnmarshaller<SparkEmrPropertiesOutput, XmlUnmarshallerContext>, IUnmarshaller<SparkEmrPropertiesOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SparkEmrPropertiesOutput IUnmarshaller<SparkEmrPropertiesOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SparkEmrPropertiesOutput Unmarshall(JsonUnmarshallerContext context)
        {
            SparkEmrPropertiesOutput unmarshalledObject = new SparkEmrPropertiesOutput();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("certificateData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CertificateData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("computeArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComputeArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("credentials", targetDepth))
                {
                    var unmarshaller = UsernamePasswordUnmarshaller.Instance;
                    unmarshalledObject.Credentials = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("credentialsExpiration", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CredentialsExpiration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("governanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GovernanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("javaVirtualEnv", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JavaVirtualEnv = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("livyEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LivyEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("managedEndpointArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManagedEndpointArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("managedEndpointCredentials", targetDepth))
                {
                    var unmarshaller = ManagedEndpointCredentialsUnmarshaller.Instance;
                    unmarshalledObject.ManagedEndpointCredentials = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pythonVirtualEnv", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PythonVirtualEnv = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runtimeRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuntimeRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trustedCertificatesS3Uri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrustedCertificatesS3Uri = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SparkEmrPropertiesOutputUnmarshaller _instance = new SparkEmrPropertiesOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SparkEmrPropertiesOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}