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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartJobRun Request Marshaller
    /// </summary>       
    public class StartJobRunRequestMarshaller : IMarshaller<IRequest, StartJobRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartJobRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartJobRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRContainers");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetVirtualClusterId())
                throw new AmazonEMRContainersException("Request object does not have required field VirtualClusterId set");
            request.AddPathResource("{virtualClusterId}", StringUtils.FromString(publicRequest.VirtualClusterId));
            request.ResourcePath = "/virtualclusters/{virtualClusterId}/jobruns";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
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
                if(publicRequest.IsSetConfigurationOverrides())
                {
                    context.Writer.WritePropertyName("configurationOverrides");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfigurationOverridesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConfigurationOverrides, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("executionRoleArn");
                    context.Writer.Write(publicRequest.ExecutionRoleArn);
                }

                if(publicRequest.IsSetJobDriver())
                {
                    context.Writer.WritePropertyName("jobDriver");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobDriverMarshaller.Instance;
                    marshaller.Marshall(publicRequest.JobDriver, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobTemplateId())
                {
                    context.Writer.WritePropertyName("jobTemplateId");
                    context.Writer.Write(publicRequest.JobTemplateId);
                }

                if(publicRequest.IsSetJobTemplateParameters())
                {
                    context.Writer.WritePropertyName("jobTemplateParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestJobTemplateParametersKvp in publicRequest.JobTemplateParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestJobTemplateParametersKvp.Key);
                        var publicRequestJobTemplateParametersValue = publicRequestJobTemplateParametersKvp.Value;

                            context.Writer.Write(publicRequestJobTemplateParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetReleaseLabel())
                {
                    context.Writer.WritePropertyName("releaseLabel");
                    context.Writer.Write(publicRequest.ReleaseLabel);
                }

                if(publicRequest.IsSetRetryPolicyConfiguration())
                {
                    context.Writer.WritePropertyName("retryPolicyConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetryPolicyConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetryPolicyConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartJobRunRequestMarshaller _instance = new StartJobRunRequestMarshaller();        

        internal static StartJobRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartJobRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}