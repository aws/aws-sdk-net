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
    /// StorageConfiguration Marshaller
    /// </summary>
    public class StorageConfigurationMarshaller : IRequestMarshaller<StorageConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StorageConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOpensearchServerlessConfiguration())
            {
                context.Writer.WritePropertyName("opensearchServerlessConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = OpenSearchServerlessConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.OpensearchServerlessConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPineconeConfiguration())
            {
                context.Writer.WritePropertyName("pineconeConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = PineconeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PineconeConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRdsConfiguration())
            {
                context.Writer.WritePropertyName("rdsConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = RdsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RdsConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRedisEnterpriseCloudConfiguration())
            {
                context.Writer.WritePropertyName("redisEnterpriseCloudConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = RedisEnterpriseCloudConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RedisEnterpriseCloudConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StorageConfigurationMarshaller Instance = new StorageConfigurationMarshaller();

    }
}