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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchGetJobEntity Request Marshaller
    /// </summary>       
    public class BatchGetJobEntityRequestMarshaller : IMarshaller<IRequest, BatchGetJobEntityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchGetJobEntityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchGetJobEntityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            if (!publicRequest.IsSetFleetId())
                throw new AmazonDeadlineException("Request object does not have required field FleetId set");
            request.AddPathResource("{fleetId}", StringUtils.FromString(publicRequest.FleetId));
            if (!publicRequest.IsSetWorkerId())
                throw new AmazonDeadlineException("Request object does not have required field WorkerId set");
            request.AddPathResource("{workerId}", StringUtils.FromString(publicRequest.WorkerId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/fleets/{fleetId}/workers/{workerId}/batchGetJobEntity";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIdentifiers())
                {
                    context.Writer.WritePropertyName("identifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIdentifiersListValue in publicRequest.Identifiers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = JobEntityIdentifiersUnionMarshaller.Instance;
                        marshaller.Marshall(publicRequestIdentifiersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"scheduling.";

            return request;
        }
        private static BatchGetJobEntityRequestMarshaller _instance = new BatchGetJobEntityRequestMarshaller();        

        internal static BatchGetJobEntityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchGetJobEntityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}