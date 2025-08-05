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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Cluster Object
    /// </summary>  
    public class ClusterUnmarshaller : IUnmarshaller<Cluster, XmlUnmarshallerContext>, IUnmarshaller<Cluster, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Cluster IUnmarshaller<Cluster, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Cluster Unmarshall(JsonUnmarshallerContext context)
        {
            Cluster unmarshalledObject = new Cluster();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accessConfig", targetDepth))
                {
                    var unmarshaller = AccessConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.AccessConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("certificateAuthority", targetDepth))
                {
                    var unmarshaller = CertificateUnmarshaller.Instance;
                    unmarshalledObject.CertificateAuthority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientRequestToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientRequestToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("computeConfig", targetDepth))
                {
                    var unmarshaller = ComputeConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.ComputeConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorConfig", targetDepth))
                {
                    var unmarshaller = ConnectorConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.ConnectorConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deletionProtection", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeletionProtection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryptionConfig", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EncryptionConfig, EncryptionConfigUnmarshaller>(EncryptionConfigUnmarshaller.Instance);
                    unmarshalledObject.EncryptionConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("health", targetDepth))
                {
                    var unmarshaller = ClusterHealthUnmarshaller.Instance;
                    unmarshalledObject.Health = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("identity", targetDepth))
                {
                    var unmarshaller = IdentityUnmarshaller.Instance;
                    unmarshalledObject.Identity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kubernetesNetworkConfig", targetDepth))
                {
                    var unmarshaller = KubernetesNetworkConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.KubernetesNetworkConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logging", targetDepth))
                {
                    var unmarshaller = LoggingUnmarshaller.Instance;
                    unmarshalledObject.Logging = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outpostConfig", targetDepth))
                {
                    var unmarshaller = OutpostConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.OutpostConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platformVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("remoteNetworkConfig", targetDepth))
                {
                    var unmarshaller = RemoteNetworkConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.RemoteNetworkConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourcesVpcConfig", targetDepth))
                {
                    var unmarshaller = VpcConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.ResourcesVpcConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageConfig", targetDepth))
                {
                    var unmarshaller = StorageConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.StorageConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("upgradePolicy", targetDepth))
                {
                    var unmarshaller = UpgradePolicyResponseUnmarshaller.Instance;
                    unmarshalledObject.UpgradePolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zonalShiftConfig", targetDepth))
                {
                    var unmarshaller = ZonalShiftConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.ZonalShiftConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ClusterUnmarshaller _instance = new ClusterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}