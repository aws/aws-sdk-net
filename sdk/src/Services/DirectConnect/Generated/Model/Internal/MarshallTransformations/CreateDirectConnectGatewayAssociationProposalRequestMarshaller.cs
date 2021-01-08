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
using ThirdParty.Json.LitJson;

namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDirectConnectGatewayAssociationProposal Request Marshaller
    /// </summary>       
    public class CreateDirectConnectGatewayAssociationProposalRequestMarshaller : IMarshaller<IRequest, CreateDirectConnectGatewayAssociationProposalRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDirectConnectGatewayAssociationProposalRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDirectConnectGatewayAssociationProposalRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectConnect");
            string target = "OvertureService.CreateDirectConnectGatewayAssociationProposal";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-10-25";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddAllowedPrefixesToDirectConnectGateway())
                {
                    context.Writer.WritePropertyName("addAllowedPrefixesToDirectConnectGateway");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddAllowedPrefixesToDirectConnectGatewayListValue in publicRequest.AddAllowedPrefixesToDirectConnectGateway)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RouteFilterPrefixMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddAllowedPrefixesToDirectConnectGatewayListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDirectConnectGatewayId())
                {
                    context.Writer.WritePropertyName("directConnectGatewayId");
                    context.Writer.Write(publicRequest.DirectConnectGatewayId);
                }

                if(publicRequest.IsSetDirectConnectGatewayOwnerAccount())
                {
                    context.Writer.WritePropertyName("directConnectGatewayOwnerAccount");
                    context.Writer.Write(publicRequest.DirectConnectGatewayOwnerAccount);
                }

                if(publicRequest.IsSetGatewayId())
                {
                    context.Writer.WritePropertyName("gatewayId");
                    context.Writer.Write(publicRequest.GatewayId);
                }

                if(publicRequest.IsSetRemoveAllowedPrefixesToDirectConnectGateway())
                {
                    context.Writer.WritePropertyName("removeAllowedPrefixesToDirectConnectGateway");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoveAllowedPrefixesToDirectConnectGatewayListValue in publicRequest.RemoveAllowedPrefixesToDirectConnectGateway)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RouteFilterPrefixMarshaller.Instance;
                        marshaller.Marshall(publicRequestRemoveAllowedPrefixesToDirectConnectGatewayListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDirectConnectGatewayAssociationProposalRequestMarshaller _instance = new CreateDirectConnectGatewayAssociationProposalRequestMarshaller();        

        internal static CreateDirectConnectGatewayAssociationProposalRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDirectConnectGatewayAssociationProposalRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}