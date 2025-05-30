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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutforVision.Model;
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
namespace Amazon.LookoutforVision.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartModel Request Marshaller
    /// </summary>       
    public class StartModelRequestMarshaller : IMarshaller<IRequest, StartModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutforVision");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-20";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetModelVersion())
                throw new AmazonLookoutforVisionException("Request object does not have required field ModelVersion set");
            request.AddPathResource("{modelVersion}", StringUtils.FromString(publicRequest.ModelVersion));
            if (!publicRequest.IsSetProjectName())
                throw new AmazonLookoutforVisionException("Request object does not have required field ProjectName set");
            request.AddPathResource("{projectName}", StringUtils.FromString(publicRequest.ProjectName));
            request.ResourcePath = "/2020-11-20/projects/{projectName}/models/{modelVersion}/start";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetMaxInferenceUnits())
            {
                context.Writer.WritePropertyName("MaxInferenceUnits");
                context.Writer.WriteNumberValue(publicRequest.MaxInferenceUnits.Value);
            }

            if(publicRequest.IsSetMinInferenceUnits())
            {
                context.Writer.WritePropertyName("MinInferenceUnits");
                context.Writer.WriteNumberValue(publicRequest.MinInferenceUnits.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["X-Amzn-Client-Token"] = publicRequest.ClientToken;
            }

            return request;
        }
        private static StartModelRequestMarshaller _instance = new StartModelRequestMarshaller();        

        internal static StartModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}