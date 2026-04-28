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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectHealth.Model;
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
namespace Amazon.ConnectHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartPatientInsightsJob Request Marshaller
    /// </summary>       
    public class StartPatientInsightsJobRequestMarshaller : IMarshaller<IRequest, StartPatientInsightsJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartPatientInsightsJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartPatientInsightsJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectHealth");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-01-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainId())
                throw new AmazonConnectHealthException("Request object does not have required field DomainId set");
            request.AddPathResource("{domainId}", StringUtils.FromString(publicRequest.DomainId));
            request.ResourcePath = "/domain/{domainId}/patient-insights-job";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetEncounterContext())
            {
                context.Writer.WritePropertyName("encounterContext");
                context.Writer.WriteStartObject();

                var marshaller = PatientInsightsEncounterContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncounterContext, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputDataConfig())
            {
                context.Writer.WritePropertyName("inputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = InputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInsightsContext())
            {
                context.Writer.WritePropertyName("insightsContext");
                context.Writer.WriteStartObject();

                var marshaller = InsightsContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.InsightsContext, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("outputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = OutputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPatientContext())
            {
                context.Writer.WritePropertyName("patientContext");
                context.Writer.WriteStartObject();

                var marshaller = PatientInsightsPatientContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.PatientContext, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUserContext())
            {
                context.Writer.WritePropertyName("userContext");
                context.Writer.WriteStartObject();

                var marshaller = UserContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.UserContext, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"runtime.";

            return request;
        }
        private static StartPatientInsightsJobRequestMarshaller _instance = new StartPatientInsightsJobRequestMarshaller();        

        internal static StartPatientInsightsJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartPatientInsightsJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}