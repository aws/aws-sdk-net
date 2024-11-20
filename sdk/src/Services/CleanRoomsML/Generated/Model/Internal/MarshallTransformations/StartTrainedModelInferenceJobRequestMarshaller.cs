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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartTrainedModelInferenceJob Request Marshaller
    /// </summary>       
    public class StartTrainedModelInferenceJobRequestMarshaller : IMarshaller<IRequest, StartTrainedModelInferenceJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartTrainedModelInferenceJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartTrainedModelInferenceJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRoomsML");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-06";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetMembershipIdentifier())
                throw new AmazonCleanRoomsMLException("Request object does not have required field MembershipIdentifier set");
            request.AddPathResource("{membershipIdentifier}", StringUtils.FromString(publicRequest.MembershipIdentifier));
            request.ResourcePath = "/memberships/{membershipIdentifier}/trained-model-inference-jobs";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfiguredModelAlgorithmAssociationArn())
                {
                    context.Writer.WritePropertyName("configuredModelAlgorithmAssociationArn");
                    context.Writer.Write(publicRequest.ConfiguredModelAlgorithmAssociationArn);
                }

                if(publicRequest.IsSetContainerExecutionParameters())
                {
                    context.Writer.WritePropertyName("containerExecutionParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceContainerExecutionParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContainerExecutionParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataSource())
                {
                    context.Writer.WritePropertyName("dataSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelInferenceDataSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnvironment())
                {
                    context.Writer.WritePropertyName("environment");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEnvironmentKvp in publicRequest.Environment)
                    {
                        context.Writer.WritePropertyName(publicRequestEnvironmentKvp.Key);
                        var publicRequestEnvironmentValue = publicRequestEnvironmentKvp.Value;

                            context.Writer.Write(publicRequestEnvironmentValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKmsKeyArn())
                {
                    context.Writer.WritePropertyName("kmsKeyArn");
                    context.Writer.Write(publicRequest.KmsKeyArn);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOutputConfiguration())
                {
                    context.Writer.WritePropertyName("outputConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceOutputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourceConfig())
                {
                    context.Writer.WritePropertyName("resourceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceResourceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ResourceConfig, context);

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

                if(publicRequest.IsSetTrainedModelArn())
                {
                    context.Writer.WritePropertyName("trainedModelArn");
                    context.Writer.Write(publicRequest.TrainedModelArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartTrainedModelInferenceJobRequestMarshaller _instance = new StartTrainedModelInferenceJobRequestMarshaller();        

        internal static StartTrainedModelInferenceJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartTrainedModelInferenceJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}