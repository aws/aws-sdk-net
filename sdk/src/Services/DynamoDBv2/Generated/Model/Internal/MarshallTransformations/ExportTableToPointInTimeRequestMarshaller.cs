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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExportTableToPointInTime Request Marshaller
    /// </summary>       
    public class ExportTableToPointInTimeRequestMarshaller : IMarshaller<IRequest, ExportTableToPointInTimeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExportTableToPointInTimeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ExportTableToPointInTimeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DynamoDBv2");
            string target = "DynamoDB_20120810.ExportTableToPointInTime";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-08-10";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetExportFormat())
                {
                    context.Writer.WritePropertyName("ExportFormat");
                    context.Writer.Write(publicRequest.ExportFormat);
                }

                if(publicRequest.IsSetExportTime())
                {
                    context.Writer.WritePropertyName("ExportTime");
                    context.Writer.Write(publicRequest.ExportTime);
                }

                if(publicRequest.IsSetS3Bucket())
                {
                    context.Writer.WritePropertyName("S3Bucket");
                    context.Writer.Write(publicRequest.S3Bucket);
                }

                if(publicRequest.IsSetS3BucketOwner())
                {
                    context.Writer.WritePropertyName("S3BucketOwner");
                    context.Writer.Write(publicRequest.S3BucketOwner);
                }

                if(publicRequest.IsSetS3Prefix())
                {
                    context.Writer.WritePropertyName("S3Prefix");
                    context.Writer.Write(publicRequest.S3Prefix);
                }

                if(publicRequest.IsSetS3SseAlgorithm())
                {
                    context.Writer.WritePropertyName("S3SseAlgorithm");
                    context.Writer.Write(publicRequest.S3SseAlgorithm);
                }

                if(publicRequest.IsSetS3SseKmsKeyId())
                {
                    context.Writer.WritePropertyName("S3SseKmsKeyId");
                    context.Writer.Write(publicRequest.S3SseKmsKeyId);
                }

                if(publicRequest.IsSetTableArn())
                {
                    context.Writer.WritePropertyName("TableArn");
                    context.Writer.Write(publicRequest.TableArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ExportTableToPointInTimeRequestMarshaller _instance = new ExportTableToPointInTimeRequestMarshaller();        

        internal static ExportTableToPointInTimeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExportTableToPointInTimeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}