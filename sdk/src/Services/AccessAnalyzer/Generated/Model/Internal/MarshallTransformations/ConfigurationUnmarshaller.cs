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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Configuration Object
    /// </summary>  
    public class ConfigurationUnmarshaller : IUnmarshaller<Configuration, XmlUnmarshallerContext>, IUnmarshaller<Configuration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Configuration IUnmarshaller<Configuration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Configuration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Configuration unmarshalledObject = new Configuration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ebsSnapshot", targetDepth))
                {
                    var unmarshaller = EbsSnapshotConfigurationUnmarshaller.Instance;
                    unmarshalledObject.EbsSnapshot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecrRepository", targetDepth))
                {
                    var unmarshaller = EcrRepositoryConfigurationUnmarshaller.Instance;
                    unmarshalledObject.EcrRepository = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("efsFileSystem", targetDepth))
                {
                    var unmarshaller = EfsFileSystemConfigurationUnmarshaller.Instance;
                    unmarshalledObject.EfsFileSystem = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamRole", targetDepth))
                {
                    var unmarshaller = IamRoleConfigurationUnmarshaller.Instance;
                    unmarshalledObject.IamRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kmsKey", targetDepth))
                {
                    var unmarshaller = KmsKeyConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KmsKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rdsDbClusterSnapshot", targetDepth))
                {
                    var unmarshaller = RdsDbClusterSnapshotConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RdsDbClusterSnapshot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rdsDbSnapshot", targetDepth))
                {
                    var unmarshaller = RdsDbSnapshotConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RdsDbSnapshot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3Bucket", targetDepth))
                {
                    var unmarshaller = S3BucketConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3Bucket = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("secretsManagerSecret", targetDepth))
                {
                    var unmarshaller = SecretsManagerSecretConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SecretsManagerSecret = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("snsTopic", targetDepth))
                {
                    var unmarshaller = SnsTopicConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SnsTopic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sqsQueue", targetDepth))
                {
                    var unmarshaller = SqsQueueConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SqsQueue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConfigurationUnmarshaller _instance = new ConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}