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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StorageConfiguration Object
    /// </summary>  
    public class StorageConfigurationUnmarshaller : IUnmarshaller<StorageConfiguration, XmlUnmarshallerContext>, IUnmarshaller<StorageConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StorageConfiguration IUnmarshaller<StorageConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public StorageConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            StorageConfiguration unmarshalledObject = new StorageConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("mongoDbAtlasConfiguration", targetDepth))
                {
                    var unmarshaller = MongoDbAtlasConfigurationUnmarshaller.Instance;
                    unmarshalledObject.MongoDbAtlasConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("opensearchServerlessConfiguration", targetDepth))
                {
                    var unmarshaller = OpenSearchServerlessConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OpensearchServerlessConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pineconeConfiguration", targetDepth))
                {
                    var unmarshaller = PineconeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PineconeConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rdsConfiguration", targetDepth))
                {
                    var unmarshaller = RdsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RdsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("redisEnterpriseCloudConfiguration", targetDepth))
                {
                    var unmarshaller = RedisEnterpriseCloudConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RedisEnterpriseCloudConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StorageConfigurationUnmarshaller _instance = new StorageConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StorageConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}