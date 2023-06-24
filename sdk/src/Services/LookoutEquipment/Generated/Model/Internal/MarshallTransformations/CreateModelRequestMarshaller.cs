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
    /// CreateModel Request Marshaller
    /// </summary>       
    public class CreateModelRequestMarshaller : IMarshaller<IRequest, CreateModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutEquipment");
            string target = "AWSLookoutEquipmentFrontendService.CreateModel";
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
                if(publicRequest.IsSetDataPreProcessingConfiguration())
                {
                    context.Writer.WritePropertyName("DataPreProcessingConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataPreProcessingConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataPreProcessingConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDatasetName())
                {
                    context.Writer.WritePropertyName("DatasetName");
                    context.Writer.Write(publicRequest.DatasetName);
                }

                if(publicRequest.IsSetDatasetSchema())
                {
                    context.Writer.WritePropertyName("DatasetSchema");
                    context.Writer.WriteObjectStart();

                    var marshaller = DatasetSchemaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DatasetSchema, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEvaluationDataEndTime())
                {
                    context.Writer.WritePropertyName("EvaluationDataEndTime");
                    context.Writer.Write(publicRequest.EvaluationDataEndTime);
                }

                if(publicRequest.IsSetEvaluationDataStartTime())
                {
                    context.Writer.WritePropertyName("EvaluationDataStartTime");
                    context.Writer.Write(publicRequest.EvaluationDataStartTime);
                }

                if(publicRequest.IsSetLabelsInputConfiguration())
                {
                    context.Writer.WritePropertyName("LabelsInputConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LabelsInputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LabelsInputConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModelName())
                {
                    context.Writer.WritePropertyName("ModelName");
                    context.Writer.Write(publicRequest.ModelName);
                }

                if(publicRequest.IsSetOffCondition())
                {
                    context.Writer.WritePropertyName("OffCondition");
                    context.Writer.Write(publicRequest.OffCondition);
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

                if(publicRequest.IsSetTrainingDataEndTime())
                {
                    context.Writer.WritePropertyName("TrainingDataEndTime");
                    context.Writer.Write(publicRequest.TrainingDataEndTime);
                }

                if(publicRequest.IsSetTrainingDataStartTime())
                {
                    context.Writer.WritePropertyName("TrainingDataStartTime");
                    context.Writer.Write(publicRequest.TrainingDataStartTime);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateModelRequestMarshaller _instance = new CreateModelRequestMarshaller();        

        internal static CreateModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}