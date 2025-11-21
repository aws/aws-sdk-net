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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
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
namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartProtectedJob Request Marshaller
    /// </summary>       
    public class StartProtectedJobRequestMarshaller : IMarshaller<IRequest, StartProtectedJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartProtectedJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartProtectedJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetMembershipIdentifier())
                throw new AmazonCleanRoomsException("Request object does not have required field MembershipIdentifier set");
            request.AddPathResource("{membershipIdentifier}", StringUtils.FromString(publicRequest.MembershipIdentifier));
            request.ResourcePath = "/memberships/{membershipIdentifier}/protectedJobs";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetComputeConfiguration())
            {
                context.Writer.WritePropertyName("computeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ProtectedJobComputeConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ComputeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobParameters())
            {
                context.Writer.WritePropertyName("jobParameters");
                context.Writer.WriteStartObject();

                var marshaller = ProtectedJobParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.JobParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResultConfiguration())
            {
                context.Writer.WritePropertyName("resultConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ProtectedJobResultConfigurationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.ResultConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(publicRequest.Type);
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
        private static StartProtectedJobRequestMarshaller _instance = new StartProtectedJobRequestMarshaller();        

        internal static StartProtectedJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartProtectedJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}