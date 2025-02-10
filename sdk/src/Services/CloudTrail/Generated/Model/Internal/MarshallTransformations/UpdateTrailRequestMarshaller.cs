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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTrail Request Marshaller
    /// </summary>       
    public class UpdateTrailRequestMarshaller : IMarshaller<IRequest, UpdateTrailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTrailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTrailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudTrail");
            string target = "com.amazonaws.cloudtrail.v20131101.CloudTrail_20131101.UpdateTrail";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCloudWatchLogsLogGroupArn())
            {
                context.Writer.WritePropertyName("CloudWatchLogsLogGroupArn");
                context.Writer.WriteStringValue(publicRequest.CloudWatchLogsLogGroupArn);
            }

            if(publicRequest.IsSetCloudWatchLogsRoleArn())
            {
                context.Writer.WritePropertyName("CloudWatchLogsRoleArn");
                context.Writer.WriteStringValue(publicRequest.CloudWatchLogsRoleArn);
            }

            if(publicRequest.IsSetEnableLogFileValidation())
            {
                context.Writer.WritePropertyName("EnableLogFileValidation");
                context.Writer.WriteBooleanValue(publicRequest.EnableLogFileValidation.Value);
            }

            if(publicRequest.IsSetIncludeGlobalServiceEvents())
            {
                context.Writer.WritePropertyName("IncludeGlobalServiceEvents");
                context.Writer.WriteBooleanValue(publicRequest.IncludeGlobalServiceEvents.Value);
            }

            if(publicRequest.IsSetIsMultiRegionTrail())
            {
                context.Writer.WritePropertyName("IsMultiRegionTrail");
                context.Writer.WriteBooleanValue(publicRequest.IsMultiRegionTrail.Value);
            }

            if(publicRequest.IsSetIsOrganizationTrail())
            {
                context.Writer.WritePropertyName("IsOrganizationTrail");
                context.Writer.WriteBooleanValue(publicRequest.IsOrganizationTrail.Value);
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetS3BucketName())
            {
                context.Writer.WritePropertyName("S3BucketName");
                context.Writer.WriteStringValue(publicRequest.S3BucketName);
            }

            if(publicRequest.IsSetS3KeyPrefix())
            {
                context.Writer.WritePropertyName("S3KeyPrefix");
                context.Writer.WriteStringValue(publicRequest.S3KeyPrefix);
            }

            if(publicRequest.IsSetSnsTopicName())
            {
                context.Writer.WritePropertyName("SnsTopicName");
                context.Writer.WriteStringValue(publicRequest.SnsTopicName);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateTrailRequestMarshaller _instance = new UpdateTrailRequestMarshaller();        

        internal static UpdateTrailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTrailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}