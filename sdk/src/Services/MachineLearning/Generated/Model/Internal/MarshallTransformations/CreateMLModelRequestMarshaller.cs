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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MachineLearning.Model;
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
namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMLModel Request Marshaller
    /// </summary>       
    public class CreateMLModelRequestMarshaller : IMarshaller<IRequest, CreateMLModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMLModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMLModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MachineLearning");
            string target = "AmazonML_20141212.CreateMLModel";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-12-12";
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
            if(publicRequest.IsSetMLModelId())
            {
                context.Writer.WritePropertyName("MLModelId");
                context.Writer.WriteStringValue(publicRequest.MLModelId);
            }

            if(publicRequest.IsSetMLModelName())
            {
                context.Writer.WritePropertyName("MLModelName");
                context.Writer.WriteStringValue(publicRequest.MLModelName);
            }

            if(publicRequest.IsSetMLModelType())
            {
                context.Writer.WritePropertyName("MLModelType");
                context.Writer.WriteStringValue(publicRequest.MLModelType);
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRecipe())
            {
                context.Writer.WritePropertyName("Recipe");
                context.Writer.WriteStringValue(publicRequest.Recipe);
            }

            if(publicRequest.IsSetRecipeUri())
            {
                context.Writer.WritePropertyName("RecipeUri");
                context.Writer.WriteStringValue(publicRequest.RecipeUri);
            }

            if(publicRequest.IsSetTrainingDataSourceId())
            {
                context.Writer.WritePropertyName("TrainingDataSourceId");
                context.Writer.WriteStringValue(publicRequest.TrainingDataSourceId);
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
        private static CreateMLModelRequestMarshaller _instance = new CreateMLModelRequestMarshaller();        

        internal static CreateMLModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMLModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}