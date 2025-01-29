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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
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
namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSoftwareUpdateJob Request Marshaller
    /// </summary>       
    public class CreateSoftwareUpdateJobRequestMarshaller : IMarshaller<IRequest, CreateSoftwareUpdateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSoftwareUpdateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSoftwareUpdateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";
            request.HttpMethod = "POST";

            request.ResourcePath = "/greengrass/updates";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetS3UrlSignerRole())
            {
                context.Writer.WritePropertyName("S3UrlSignerRole");
                context.Writer.WriteStringValue(publicRequest.S3UrlSignerRole);
            }

            if(publicRequest.IsSetSoftwareToUpdate())
            {
                context.Writer.WritePropertyName("SoftwareToUpdate");
                context.Writer.WriteStringValue(publicRequest.SoftwareToUpdate);
            }

            if(publicRequest.IsSetUpdateAgentLogLevel())
            {
                context.Writer.WritePropertyName("UpdateAgentLogLevel");
                context.Writer.WriteStringValue(publicRequest.UpdateAgentLogLevel);
            }

            if(publicRequest.IsSetUpdateTargets())
            {
                context.Writer.WritePropertyName("UpdateTargets");
                context.Writer.WriteStartArray();
                foreach(var publicRequestUpdateTargetsListValue in publicRequest.UpdateTargets)
                {
                        context.Writer.WriteStringValue(publicRequestUpdateTargetsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUpdateTargetsArchitecture())
            {
                context.Writer.WritePropertyName("UpdateTargetsArchitecture");
                context.Writer.WriteStringValue(publicRequest.UpdateTargetsArchitecture);
            }

            if(publicRequest.IsSetUpdateTargetsOperatingSystem())
            {
                context.Writer.WritePropertyName("UpdateTargetsOperatingSystem");
                context.Writer.WriteStringValue(publicRequest.UpdateTargetsOperatingSystem);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetAmznClientToken()) 
            {
                request.Headers["X-Amzn-Client-Token"] = publicRequest.AmznClientToken;
            }

            return request;
        }
        private static CreateSoftwareUpdateJobRequestMarshaller _instance = new CreateSoftwareUpdateJobRequestMarshaller();        

        internal static CreateSoftwareUpdateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSoftwareUpdateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}