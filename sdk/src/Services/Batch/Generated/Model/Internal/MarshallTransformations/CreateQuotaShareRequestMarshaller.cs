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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateQuotaShare Request Marshaller
    /// </summary>       
    public class CreateQuotaShareRequestMarshaller : IMarshaller<IRequest, CreateQuotaShareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateQuotaShareRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateQuotaShareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/createquotashare";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapacityLimits())
                {
                    context.Writer.WritePropertyName("capacityLimits");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCapacityLimitsListValue in publicRequest.CapacityLimits)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = QuotaShareCapacityLimitMarshaller.Instance;
                        marshaller.Marshall(publicRequestCapacityLimitsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetJobQueue())
                {
                    context.Writer.WritePropertyName("jobQueue");
                    context.Writer.Write(publicRequest.JobQueue);
                }

                if(publicRequest.IsSetPreemptionConfiguration())
                {
                    context.Writer.WritePropertyName("preemptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = QuotaSharePreemptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PreemptionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetQuotaShareName())
                {
                    context.Writer.WritePropertyName("quotaShareName");
                    context.Writer.Write(publicRequest.QuotaShareName);
                }

                if(publicRequest.IsSetResourceSharingConfiguration())
                {
                    context.Writer.WritePropertyName("resourceSharingConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = QuotaShareResourceSharingConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ResourceSharingConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("state");
                    context.Writer.Write(publicRequest.State);
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
        private static CreateQuotaShareRequestMarshaller _instance = new CreateQuotaShareRequestMarshaller();        

        internal static CreateQuotaShareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateQuotaShareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}