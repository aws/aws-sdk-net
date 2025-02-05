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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTrialComponent Request Marshaller
    /// </summary>       
    public class UpdateTrialComponentRequestMarshaller : IMarshaller<IRequest, UpdateTrialComponentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTrialComponentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTrialComponentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.UpdateTrialComponent";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("DisplayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EndTime.Value)));
            }

            if(publicRequest.IsSetInputArtifacts())
            {
                context.Writer.WritePropertyName("InputArtifacts");
                context.Writer.WriteStartObject();
                foreach (var publicRequestInputArtifactsKvp in publicRequest.InputArtifacts)
                {
                    context.Writer.WritePropertyName(publicRequestInputArtifactsKvp.Key);
                    var publicRequestInputArtifactsValue = publicRequestInputArtifactsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = TrialComponentArtifactMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputArtifactsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputArtifactsToRemove())
            {
                context.Writer.WritePropertyName("InputArtifactsToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputArtifactsToRemoveListValue in publicRequest.InputArtifactsToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestInputArtifactsToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOutputArtifacts())
            {
                context.Writer.WritePropertyName("OutputArtifacts");
                context.Writer.WriteStartObject();
                foreach (var publicRequestOutputArtifactsKvp in publicRequest.OutputArtifacts)
                {
                    context.Writer.WritePropertyName(publicRequestOutputArtifactsKvp.Key);
                    var publicRequestOutputArtifactsValue = publicRequestOutputArtifactsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = TrialComponentArtifactMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputArtifactsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutputArtifactsToRemove())
            {
                context.Writer.WritePropertyName("OutputArtifactsToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOutputArtifactsToRemoveListValue in publicRequest.OutputArtifactsToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestOutputArtifactsToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = TrialComponentParameterValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestParametersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetParametersToRemove())
            {
                context.Writer.WritePropertyName("ParametersToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestParametersToRemoveListValue in publicRequest.ParametersToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestParametersToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartTime.Value)));
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStartObject();

                var marshaller = TrialComponentStatusMarshaller.Instance;
                marshaller.Marshall(publicRequest.Status, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTrialComponentName())
            {
                context.Writer.WritePropertyName("TrialComponentName");
                context.Writer.WriteStringValue(publicRequest.TrialComponentName);
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
        private static UpdateTrialComponentRequestMarshaller _instance = new UpdateTrialComponentRequestMarshaller();        

        internal static UpdateTrialComponentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTrialComponentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}