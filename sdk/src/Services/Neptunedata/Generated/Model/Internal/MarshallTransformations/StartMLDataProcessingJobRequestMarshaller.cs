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
    /// StartMLDataProcessingJob Request Marshaller
    /// </summary>       
    public class StartMLDataProcessingJobRequestMarshaller : IMarshaller<IRequest, StartMLDataProcessingJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartMLDataProcessingJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartMLDataProcessingJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptunedata");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ml/dataprocessing";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfigFileName())
                {
                    context.Writer.WritePropertyName("configFileName");
                    context.Writer.Write(publicRequest.ConfigFileName);
                }

                if(publicRequest.IsSetId())
                {
                    context.Writer.WritePropertyName("id");
                    context.Writer.Write(publicRequest.Id);
                }

                if(publicRequest.IsSetInputDataS3Location())
                {
                    context.Writer.WritePropertyName("inputDataS3Location");
                    context.Writer.Write(publicRequest.InputDataS3Location);
                }

                if(publicRequest.IsSetModelType())
                {
                    context.Writer.WritePropertyName("modelType");
                    context.Writer.Write(publicRequest.ModelType);
                }

                if(publicRequest.IsSetNeptuneIamRoleArn())
                {
                    context.Writer.WritePropertyName("neptuneIamRoleArn");
                    context.Writer.Write(publicRequest.NeptuneIamRoleArn);
                }

                if(publicRequest.IsSetPreviousDataProcessingJobId())
                {
                    context.Writer.WritePropertyName("previousDataProcessingJobId");
                    context.Writer.Write(publicRequest.PreviousDataProcessingJobId);
                }

                if(publicRequest.IsSetProcessedDataS3Location())
                {
                    context.Writer.WritePropertyName("processedDataS3Location");
                    context.Writer.Write(publicRequest.ProcessedDataS3Location);
                }

                if(publicRequest.IsSetProcessingInstanceType())
                {
                    context.Writer.WritePropertyName("processingInstanceType");
                    context.Writer.Write(publicRequest.ProcessingInstanceType);
                }

                if(publicRequest.IsSetProcessingInstanceVolumeSizeInGB())
                {
                    context.Writer.WritePropertyName("processingInstanceVolumeSizeInGB");
                    context.Writer.Write(publicRequest.ProcessingInstanceVolumeSizeInGB);
                }

                if(publicRequest.IsSetProcessingTimeOutInSeconds())
                {
                    context.Writer.WritePropertyName("processingTimeOutInSeconds");
                    context.Writer.Write(publicRequest.ProcessingTimeOutInSeconds);
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
        private static StartMLDataProcessingJobRequestMarshaller _instance = new StartMLDataProcessingJobRequestMarshaller();        

        internal static StartMLDataProcessingJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartMLDataProcessingJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}