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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StorageConfiguration Object
    /// </summary>
    public partial class StorageConfigurationUnmarshaller : IJsonUnmarshaller<StorageConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public StorageConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new StorageConfiguration();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("mongoDbAtlasConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = MongoDbAtlasConfigurationUnmarshaller.Instance;
                    unmarshalledObject.MongoDbAtlasConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("neptuneAnalyticsConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = NeptuneAnalyticsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NeptuneAnalyticsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("opensearchManagedClusterConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = OpenSearchManagedClusterConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OpensearchManagedClusterConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("opensearchServerlessConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = OpenSearchServerlessConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OpensearchServerlessConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("pineconeConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = PineconeConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PineconeConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("rdsConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = RdsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RdsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("redisEnterpriseCloudConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = RedisEnterpriseCloudConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RedisEnterpriseCloudConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("s3VectorsConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = S3VectorsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3VectorsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("type", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static StorageConfigurationUnmarshaller _instance = new StorageConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StorageConfigurationUnmarshaller Instance => _instance;
    }
}
