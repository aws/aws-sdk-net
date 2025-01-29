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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectConnect.Model;
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
namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AcceptDirectConnectGatewayAssociationProposal Request Marshaller
    /// </summary>       
    public class AcceptDirectConnectGatewayAssociationProposalRequestMarshaller : IMarshaller<IRequest, AcceptDirectConnectGatewayAssociationProposalRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AcceptDirectConnectGatewayAssociationProposalRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AcceptDirectConnectGatewayAssociationProposalRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectConnect");
            string target = "OvertureService.AcceptDirectConnectGatewayAssociationProposal";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-10-25";
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
            if(publicRequest.IsSetAssociatedGatewayOwnerAccount())
            {
                context.Writer.WritePropertyName("associatedGatewayOwnerAccount");
                context.Writer.WriteStringValue(publicRequest.AssociatedGatewayOwnerAccount);
            }

            if(publicRequest.IsSetDirectConnectGatewayId())
            {
                context.Writer.WritePropertyName("directConnectGatewayId");
                context.Writer.WriteStringValue(publicRequest.DirectConnectGatewayId);
            }

            if(publicRequest.IsSetOverrideAllowedPrefixesToDirectConnectGateway())
            {
                context.Writer.WritePropertyName("overrideAllowedPrefixesToDirectConnectGateway");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOverrideAllowedPrefixesToDirectConnectGatewayListValue in publicRequest.OverrideAllowedPrefixesToDirectConnectGateway)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RouteFilterPrefixMarshaller.Instance;
                    marshaller.Marshall(publicRequestOverrideAllowedPrefixesToDirectConnectGatewayListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetProposalId())
            {
                context.Writer.WritePropertyName("proposalId");
                context.Writer.WriteStringValue(publicRequest.ProposalId);
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
        private static AcceptDirectConnectGatewayAssociationProposalRequestMarshaller _instance = new AcceptDirectConnectGatewayAssociationProposalRequestMarshaller();        

        internal static AcceptDirectConnectGatewayAssociationProposalRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AcceptDirectConnectGatewayAssociationProposalRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}