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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBaseProcessingInstanceType())
            {
                context.Writer.WritePropertyName("baseProcessingInstanceType");
                context.Writer.WriteStringValue(publicRequest.BaseProcessingInstanceType);
            }

            if(publicRequest.IsSetCustomModelTrainingParameters())
            {
                context.Writer.WritePropertyName("customModelTrainingParameters");
                context.Writer.WriteStartObject();

                var marshaller = CustomModelTrainingParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomModelTrainingParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataProcessingJobId())
            {
                context.Writer.WritePropertyName("dataProcessingJobId");
                context.Writer.WriteStringValue(publicRequest.DataProcessingJobId);
            }

            if(publicRequest.IsSetEnableManagedSpotTraining())
            {
                context.Writer.WritePropertyName("enableManagedSpotTraining");
                context.Writer.WriteBooleanValue(publicRequest.EnableManagedSpotTraining.Value);
            }

            if(publicRequest.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(publicRequest.Id);
            }

            if(publicRequest.IsSetMaxHPONumberOfTrainingJobs())
            {
                context.Writer.WritePropertyName("maxHPONumberOfTrainingJobs");
                context.Writer.WriteNumberValue(publicRequest.MaxHPONumberOfTrainingJobs.Value);
            }

            if(publicRequest.IsSetMaxHPOParallelTrainingJobs())
            {
                context.Writer.WritePropertyName("maxHPOParallelTrainingJobs");
                context.Writer.WriteNumberValue(publicRequest.MaxHPOParallelTrainingJobs.Value);
            }

            if(publicRequest.IsSetNeptuneIamRoleArn())
            {
                context.Writer.WritePropertyName("neptuneIamRoleArn");
                context.Writer.WriteStringValue(publicRequest.NeptuneIamRoleArn);
            }

            if(publicRequest.IsSetPreviousModelTrainingJobId())
            {
                context.Writer.WritePropertyName("previousModelTrainingJobId");
                context.Writer.WriteStringValue(publicRequest.PreviousModelTrainingJobId);
            }

            if(publicRequest.IsSetS3OutputEncryptionKMSKey())
            {
                context.Writer.WritePropertyName("s3OutputEncryptionKMSKey");
                context.Writer.WriteStringValue(publicRequest.S3OutputEncryptionKMSKey);
            }

            if(publicRequest.IsSetSagemakerIamRoleArn())
            {
                context.Writer.WritePropertyName("sagemakerIamRoleArn");
                context.Writer.WriteStringValue(publicRequest.SagemakerIamRoleArn);
            }

            if(publicRequest.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("securityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSubnets())
            {
                context.Writer.WritePropertyName("subnets");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubnetsListValue in publicRequest.Subnets)
                {
                        context.Writer.WriteStringValue(publicRequestSubnetsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTrainingInstanceType())
            {
                context.Writer.WritePropertyName("trainingInstanceType");
                context.Writer.WriteStringValue(publicRequest.TrainingInstanceType);
            }

            if(publicRequest.IsSetTrainingInstanceVolumeSizeInGB())
            {
                context.Writer.WritePropertyName("trainingInstanceVolumeSizeInGB");
                context.Writer.WriteNumberValue(publicRequest.TrainingInstanceVolumeSizeInGB.Value);
            }

            if(publicRequest.IsSetTrainingTimeOutInSeconds())
            {
                context.Writer.WritePropertyName("trainingTimeOutInSeconds");
                context.Writer.WriteNumberValue(publicRequest.TrainingTimeOutInSeconds.Value);
            }

            if(publicRequest.IsSetTrainModelS3Location())
            {
                context.Writer.WritePropertyName("trainModelS3Location");
                context.Writer.WriteStringValue(publicRequest.TrainModelS3Location);
            }

            if(publicRequest.IsSetVolumeEncryptionKMSKey())
            {
                context.Writer.WritePropertyName("volumeEncryptionKMSKey");
                context.Writer.WriteStringValue(publicRequest.VolumeEncryptionKMSKey);
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