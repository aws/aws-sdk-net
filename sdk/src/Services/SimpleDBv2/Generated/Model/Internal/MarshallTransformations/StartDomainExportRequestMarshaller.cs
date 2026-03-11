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
 * Do not modify this file. This file is generated from the simpledbv2-2025-09-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDomainExport Request Marshaller
    /// </summary>       
    public class StartDomainExportRequestMarshaller : IMarshaller<IRequest, StartDomainExportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDomainExportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartDomainExportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleDBv2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v2/StartDomainExport";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDomainName())
                {
                    context.Writer.WritePropertyName("domainName");
                    context.Writer.Write(publicRequest.DomainName);
                }

                if(publicRequest.IsSetS3Bucket())
                {
                    context.Writer.WritePropertyName("s3Bucket");
                    context.Writer.Write(publicRequest.S3Bucket);
                }

                if(publicRequest.IsSetS3BucketOwner())
                {
                    context.Writer.WritePropertyName("s3BucketOwner");
                    context.Writer.Write(publicRequest.S3BucketOwner);
                }

                if(publicRequest.IsSetS3KeyPrefix())
                {
                    context.Writer.WritePropertyName("s3KeyPrefix");
                    context.Writer.Write(publicRequest.S3KeyPrefix);
                }

                if(publicRequest.IsSetS3SseAlgorithm())
                {
                    context.Writer.WritePropertyName("s3SseAlgorithm");
                    context.Writer.Write(publicRequest.S3SseAlgorithm);
                }

                if(publicRequest.IsSetS3SseKmsKeyId())
                {
                    context.Writer.WritePropertyName("s3SseKmsKeyId");
                    context.Writer.Write(publicRequest.S3SseKmsKeyId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartDomainExportRequestMarshaller _instance = new StartDomainExportRequestMarshaller();        

        internal static StartDomainExportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartDomainExportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}