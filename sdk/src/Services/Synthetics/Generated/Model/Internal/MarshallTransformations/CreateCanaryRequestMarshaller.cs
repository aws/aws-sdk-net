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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Synthetics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Synthetics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCanary Request Marshaller
    /// </summary>       
    public class CreateCanaryRequestMarshaller : IMarshaller<IRequest, CreateCanaryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCanaryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCanaryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Synthetics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-11";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/canary";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArtifactS3Location())
                {
                    context.Writer.WritePropertyName("ArtifactS3Location");
                    context.Writer.Write(publicRequest.ArtifactS3Location);
                }

                if(publicRequest.IsSetCode())
                {
                    context.Writer.WritePropertyName("Code");
                    context.Writer.WriteObjectStart();

                    var marshaller = CanaryCodeInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Code, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("ExecutionRoleArn");
                    context.Writer.Write(publicRequest.ExecutionRoleArn);
                }

                if(publicRequest.IsSetFailureRetentionPeriodInDays())
                {
                    context.Writer.WritePropertyName("FailureRetentionPeriodInDays");
                    context.Writer.Write(publicRequest.FailureRetentionPeriodInDays);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRunConfig())
                {
                    context.Writer.WritePropertyName("RunConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = CanaryRunConfigInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RunConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRuntimeVersion())
                {
                    context.Writer.WritePropertyName("RuntimeVersion");
                    context.Writer.Write(publicRequest.RuntimeVersion);
                }

                if(publicRequest.IsSetSchedule())
                {
                    context.Writer.WritePropertyName("Schedule");
                    context.Writer.WriteObjectStart();

                    var marshaller = CanaryScheduleInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Schedule, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSuccessRetentionPeriodInDays())
                {
                    context.Writer.WritePropertyName("SuccessRetentionPeriodInDays");
                    context.Writer.Write(publicRequest.SuccessRetentionPeriodInDays);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("VpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCanaryRequestMarshaller _instance = new CreateCanaryRequestMarshaller();        

        internal static CreateCanaryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCanaryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}