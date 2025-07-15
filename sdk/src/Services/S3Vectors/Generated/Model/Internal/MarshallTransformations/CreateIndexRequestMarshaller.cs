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
 * Do not modify this file. This file is generated from the s3vectors-2025-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Vectors.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Vectors.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIndex Request Marshaller
    /// </summary>       
    public class CreateIndexRequestMarshaller : IMarshaller<IRequest, CreateIndexRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIndexRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIndexRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Vectors");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-07-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateIndex";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDataType())
                {
                    context.Writer.WritePropertyName("dataType");
                    context.Writer.Write(publicRequest.DataType);
                }

                if(publicRequest.IsSetDimension())
                {
                    context.Writer.WritePropertyName("dimension");
                    context.Writer.Write(publicRequest.Dimension);
                }

                if(publicRequest.IsSetDistanceMetric())
                {
                    context.Writer.WritePropertyName("distanceMetric");
                    context.Writer.Write(publicRequest.DistanceMetric);
                }

                if(publicRequest.IsSetIndexName())
                {
                    context.Writer.WritePropertyName("indexName");
                    context.Writer.Write(publicRequest.IndexName);
                }

                if(publicRequest.IsSetMetadataConfiguration())
                {
                    context.Writer.WritePropertyName("metadataConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetadataConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetadataConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVectorBucketArn())
                {
                    context.Writer.WritePropertyName("vectorBucketArn");
                    context.Writer.Write(publicRequest.VectorBucketArn);
                }

                if(publicRequest.IsSetVectorBucketName())
                {
                    context.Writer.WritePropertyName("vectorBucketName");
                    context.Writer.Write(publicRequest.VectorBucketName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateIndexRequestMarshaller _instance = new CreateIndexRequestMarshaller();        

        internal static CreateIndexRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIndexRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}