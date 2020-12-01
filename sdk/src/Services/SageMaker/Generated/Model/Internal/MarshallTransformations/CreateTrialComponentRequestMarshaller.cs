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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTrialComponent Request Marshaller
    /// </summary>       
    public class CreateTrialComponentRequestMarshaller : IMarshaller<IRequest, CreateTrialComponentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrialComponentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTrialComponentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateTrialComponent";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("DisplayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetEndTime())
                {
                    context.Writer.WritePropertyName("EndTime");
                    context.Writer.Write(publicRequest.EndTime);
                }

                if(publicRequest.IsSetInputArtifacts())
                {
                    context.Writer.WritePropertyName("InputArtifacts");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestInputArtifactsKvp in publicRequest.InputArtifacts)
                    {
                        context.Writer.WritePropertyName(publicRequestInputArtifactsKvp.Key);
                        var publicRequestInputArtifactsValue = publicRequestInputArtifactsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = TrialComponentArtifactMarshaller.Instance;
                        marshaller.Marshall(publicRequestInputArtifactsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMetadataProperties())
                {
                    context.Writer.WritePropertyName("MetadataProperties");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetadataPropertiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetadataProperties, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputArtifacts())
                {
                    context.Writer.WritePropertyName("OutputArtifacts");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestOutputArtifactsKvp in publicRequest.OutputArtifacts)
                    {
                        context.Writer.WritePropertyName(publicRequestOutputArtifactsKvp.Key);
                        var publicRequestOutputArtifactsValue = publicRequestOutputArtifactsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = TrialComponentArtifactMarshaller.Instance;
                        marshaller.Marshall(publicRequestOutputArtifactsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("Parameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                    {
                        context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                        var publicRequestParametersValue = publicRequestParametersKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = TrialComponentParameterValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestParametersValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("StartTime");
                    context.Writer.Write(publicRequest.StartTime);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.WriteObjectStart();

                    var marshaller = TrialComponentStatusMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Status, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetTrialComponentName())
                {
                    context.Writer.WritePropertyName("TrialComponentName");
                    context.Writer.Write(publicRequest.TrialComponentName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTrialComponentRequestMarshaller _instance = new CreateTrialComponentRequestMarshaller();        

        internal static CreateTrialComponentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTrialComponentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}