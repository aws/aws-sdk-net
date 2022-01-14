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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutEquipment.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateInferenceScheduler Request Marshaller
    /// </summary>       
    public class CreateInferenceSchedulerRequestMarshaller : IMarshaller<IRequest, CreateInferenceSchedulerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInferenceSchedulerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInferenceSchedulerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutEquipment");
            string target = "AWSLookoutEquipmentFrontendService.CreateInferenceScheduler";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-12-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
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
                if(publicRequest.IsSetDataDelayOffsetInMinutes())
                {
                    context.Writer.WritePropertyName("DataDelayOffsetInMinutes");
                    context.Writer.Write(publicRequest.DataDelayOffsetInMinutes);
                }

                if(publicRequest.IsSetDataInputConfiguration())
                {
                    context.Writer.WritePropertyName("DataInputConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceInputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataInputConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataOutputConfiguration())
                {
                    context.Writer.WritePropertyName("DataOutputConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceOutputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataOutputConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataUploadFrequency())
                {
                    context.Writer.WritePropertyName("DataUploadFrequency");
                    context.Writer.Write(publicRequest.DataUploadFrequency);
                }

                if(publicRequest.IsSetInferenceSchedulerName())
                {
                    context.Writer.WritePropertyName("InferenceSchedulerName");
                    context.Writer.Write(publicRequest.InferenceSchedulerName);
                }

                if(publicRequest.IsSetModelName())
                {
                    context.Writer.WritePropertyName("ModelName");
                    context.Writer.Write(publicRequest.ModelName);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetServerSideKmsKeyId())
                {
                    context.Writer.WritePropertyName("ServerSideKmsKeyId");
                    context.Writer.Write(publicRequest.ServerSideKmsKeyId);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateInferenceSchedulerRequestMarshaller _instance = new CreateInferenceSchedulerRequestMarshaller();        

        internal static CreateInferenceSchedulerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInferenceSchedulerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}