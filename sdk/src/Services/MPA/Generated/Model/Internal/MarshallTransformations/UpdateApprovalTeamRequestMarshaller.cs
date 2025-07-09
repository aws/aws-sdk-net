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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MPA.Model;
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
namespace Amazon.MPA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApprovalTeam Request Marshaller
    /// </summary>       
    public class UpdateApprovalTeamRequestMarshaller : IMarshaller<IRequest, UpdateApprovalTeamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApprovalTeamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApprovalTeamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MPA");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetArn())
                throw new AmazonMPAException("Request object does not have required field Arn set");
            request.AddPathResource("{Arn}", StringUtils.FromString(publicRequest.Arn));
            request.ResourcePath = "/approval-teams/{Arn}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetApprovalStrategy())
            {
                context.Writer.WritePropertyName("ApprovalStrategy");
                context.Writer.WriteStartObject();

                var marshaller = ApprovalStrategyMarshaller.Instance;
                marshaller.Marshall(publicRequest.ApprovalStrategy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetApprovers())
            {
                context.Writer.WritePropertyName("Approvers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestApproversListValue in publicRequest.Approvers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ApprovalTeamRequestApproverMarshaller.Instance;
                    marshaller.Marshall(publicRequestApproversListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
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
        private static UpdateApprovalTeamRequestMarshaller _instance = new UpdateApprovalTeamRequestMarshaller();        

        internal static UpdateApprovalTeamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApprovalTeamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}