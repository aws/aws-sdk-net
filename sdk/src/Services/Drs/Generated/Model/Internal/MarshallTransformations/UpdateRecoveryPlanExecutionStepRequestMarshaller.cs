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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
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
namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRecoveryPlanExecutionStep Request Marshaller
    /// </summary>       
    public class UpdateRecoveryPlanExecutionStepRequestMarshaller : IMarshaller<IRequest, UpdateRecoveryPlanExecutionStepRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRecoveryPlanExecutionStepRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRecoveryPlanExecutionStepRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Drs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateRecoveryPlanExecutionStep";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetRecoveryPlanExecutionStepArn())
            {
                context.Writer.WritePropertyName("recoveryPlanExecutionStepArn");
                context.Writer.WriteStringValue(publicRequest.RecoveryPlanExecutionStepArn);
            }

            if(publicRequest.IsSetServers())
            {
                context.Writer.WritePropertyName("servers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestServersListValue in publicRequest.Servers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RecoveryPlanServerMarshaller.Instance;
                    marshaller.Marshall(publicRequestServersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }

            if(publicRequest.IsSetWaitDurationMinutes())
            {
                context.Writer.WritePropertyName("waitDurationMinutes");
                context.Writer.WriteNumberValue(publicRequest.WaitDurationMinutes.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateRecoveryPlanExecutionStepRequestMarshaller _instance = new UpdateRecoveryPlanExecutionStepRequestMarshaller();        

        internal static UpdateRecoveryPlanExecutionStepRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRecoveryPlanExecutionStepRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}