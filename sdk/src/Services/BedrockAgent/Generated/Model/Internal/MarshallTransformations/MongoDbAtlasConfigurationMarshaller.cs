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
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MongoDbAtlasConfiguration Marshaller
    /// </summary>
    public class MongoDbAtlasConfigurationMarshaller : IRequestMarshaller<MongoDbAtlasConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MongoDbAtlasConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCollectionName())
            {
                context.Writer.WritePropertyName("collectionName");
                context.Writer.WriteStringValue(requestObject.CollectionName);
            }

            if(requestObject.IsSetCredentialsSecretArn())
            {
                context.Writer.WritePropertyName("credentialsSecretArn");
                context.Writer.WriteStringValue(requestObject.CredentialsSecretArn);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("databaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetEndpoint())
            {
                context.Writer.WritePropertyName("endpoint");
                context.Writer.WriteStringValue(requestObject.Endpoint);
            }

            if(requestObject.IsSetEndpointServiceName())
            {
                context.Writer.WritePropertyName("endpointServiceName");
                context.Writer.WriteStringValue(requestObject.EndpointServiceName);
            }

            if(requestObject.IsSetFieldMapping())
            {
                context.Writer.WritePropertyName("fieldMapping");
                context.Writer.WriteStartObject();

                var marshaller = MongoDbAtlasFieldMappingMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldMapping, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTextIndexName())
            {
                context.Writer.WritePropertyName("textIndexName");
                context.Writer.WriteStringValue(requestObject.TextIndexName);
            }

            if(requestObject.IsSetVectorIndexName())
            {
                context.Writer.WritePropertyName("vectorIndexName");
                context.Writer.WriteStringValue(requestObject.VectorIndexName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MongoDbAtlasConfigurationMarshaller Instance = new MongoDbAtlasConfigurationMarshaller();

    }
}