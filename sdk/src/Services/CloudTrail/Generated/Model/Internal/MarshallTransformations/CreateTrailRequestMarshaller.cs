/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTrail Request Marshaller
    /// </summary>       
    public class CreateTrailRequestMarshaller : IMarshaller<IRequest, CreateTrailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTrailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudTrail");
            string target = "com.amazonaws.cloudtrail.v20131101.CloudTrail_20131101.CreateTrail";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCloudWatchLogsLogGroupArn())
                {
                    context.Writer.WritePropertyName("CloudWatchLogsLogGroupArn");
                    context.Writer.Write(publicRequest.CloudWatchLogsLogGroupArn);
                }

                if(publicRequest.IsSetCloudWatchLogsRoleArn())
                {
                    context.Writer.WritePropertyName("CloudWatchLogsRoleArn");
                    context.Writer.Write(publicRequest.CloudWatchLogsRoleArn);
                }

                if(publicRequest.IsSetEnableLogFileValidation())
                {
                    context.Writer.WritePropertyName("EnableLogFileValidation");
                    context.Writer.Write(publicRequest.EnableLogFileValidation);
                }

                if(publicRequest.IsSetIncludeGlobalServiceEvents())
                {
                    context.Writer.WritePropertyName("IncludeGlobalServiceEvents");
                    context.Writer.Write(publicRequest.IncludeGlobalServiceEvents);
                }

                if(publicRequest.IsSetIsMultiRegionTrail())
                {
                    context.Writer.WritePropertyName("IsMultiRegionTrail");
                    context.Writer.Write(publicRequest.IsMultiRegionTrail);
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("KmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetS3BucketName())
                {
                    context.Writer.WritePropertyName("S3BucketName");
                    context.Writer.Write(publicRequest.S3BucketName);
                }

                if(publicRequest.IsSetS3KeyPrefix())
                {
                    context.Writer.WritePropertyName("S3KeyPrefix");
                    context.Writer.Write(publicRequest.S3KeyPrefix);
                }

                if(publicRequest.IsSetSnsTopicName())
                {
                    context.Writer.WritePropertyName("SnsTopicName");
                    context.Writer.Write(publicRequest.SnsTopicName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTrailRequestMarshaller _instance = new CreateTrailRequestMarshaller();        

        internal static CreateTrailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTrailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}