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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptunedata.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartMLModelTrainingJob Request Marshaller
    /// </summary>       
    public class StartMLModelTrainingJobRequestMarshaller : IMarshaller<IRequest, StartMLModelTrainingJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartMLModelTrainingJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartMLModelTrainingJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptunedata");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ml/modeltraining";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBaseProcessingInstanceType())
                {
                    context.Writer.WritePropertyName("baseProcessingInstanceType");
                    context.Writer.Write(publicRequest.BaseProcessingInstanceType);
                }

                if(publicRequest.IsSetCustomModelTrainingParameters())
                {
                    context.Writer.WritePropertyName("customModelTrainingParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomModelTrainingParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CustomModelTrainingParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataProcessingJobId())
                {
                    context.Writer.WritePropertyName("dataProcessingJobId");
                    context.Writer.Write(publicRequest.DataProcessingJobId);
                }

                if(publicRequest.IsSetEnableManagedSpotTraining())
                {
                    context.Writer.WritePropertyName("enableManagedSpotTraining");
                    context.Writer.Write(publicRequest.EnableManagedSpotTraining);
                }

                if(publicRequest.IsSetId())
                {
                    context.Writer.WritePropertyName("id");
                    context.Writer.Write(publicRequest.Id);
                }

                if(publicRequest.IsSetMaxHPONumberOfTrainingJobs())
                {
                    context.Writer.WritePropertyName("maxHPONumberOfTrainingJobs");
                    context.Writer.Write(publicRequest.MaxHPONumberOfTrainingJobs);
                }

                if(publicRequest.IsSetMaxHPOParallelTrainingJobs())
                {
                    context.Writer.WritePropertyName("maxHPOParallelTrainingJobs");
                    context.Writer.Write(publicRequest.MaxHPOParallelTrainingJobs);
                }

                if(publicRequest.IsSetNeptuneIamRoleArn())
                {
                    context.Writer.WritePropertyName("neptuneIamRoleArn");
                    context.Writer.Write(publicRequest.NeptuneIamRoleArn);
                }

                if(publicRequest.IsSetPreviousModelTrainingJobId())
                {
                    context.Writer.WritePropertyName("previousModelTrainingJobId");
                    context.Writer.Write(publicRequest.PreviousModelTrainingJobId);
                }

                if(publicRequest.IsSetS3OutputEncryptionKMSKey())
                {
                    context.Writer.WritePropertyName("s3OutputEncryptionKMSKey");
                    context.Writer.Write(publicRequest.S3OutputEncryptionKMSKey);
                }

                if(publicRequest.IsSetSagemakerIamRoleArn())
                {
                    context.Writer.WritePropertyName("sagemakerIamRoleArn");
                    context.Writer.Write(publicRequest.SagemakerIamRoleArn);
                }

                if(publicRequest.IsSetSecurityGroupIds())
                {
                    context.Writer.WritePropertyName("securityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSubnets())
                {
                    context.Writer.WritePropertyName("subnets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubnetsListValue in publicRequest.Subnets)
                    {
                            context.Writer.Write(publicRequestSubnetsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTrainingInstanceType())
                {
                    context.Writer.WritePropertyName("trainingInstanceType");
                    context.Writer.Write(publicRequest.TrainingInstanceType);
                }

                if(publicRequest.IsSetTrainingInstanceVolumeSizeInGB())
                {
                    context.Writer.WritePropertyName("trainingInstanceVolumeSizeInGB");
                    context.Writer.Write(publicRequest.TrainingInstanceVolumeSizeInGB);
                }

                if(publicRequest.IsSetTrainingTimeOutInSeconds())
                {
                    context.Writer.WritePropertyName("trainingTimeOutInSeconds");
                    context.Writer.Write(publicRequest.TrainingTimeOutInSeconds);
                }

                if(publicRequest.IsSetTrainModelS3Location())
                {
                    context.Writer.WritePropertyName("trainModelS3Location");
                    context.Writer.Write(publicRequest.TrainModelS3Location);
                }

                if(publicRequest.IsSetVolumeEncryptionKMSKey())
                {
                    context.Writer.WritePropertyName("volumeEncryptionKMSKey");
                    context.Writer.Write(publicRequest.VolumeEncryptionKMSKey);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartMLModelTrainingJobRequestMarshaller _instance = new StartMLModelTrainingJobRequestMarshaller();        

        internal static StartMLModelTrainingJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartMLModelTrainingJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}