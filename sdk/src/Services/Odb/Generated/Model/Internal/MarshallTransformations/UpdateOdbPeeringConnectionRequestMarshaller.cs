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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateOdbPeeringConnection Request Marshaller
    /// </summary>       
    public class UpdateOdbPeeringConnectionRequestMarshaller : IMarshaller<IRequest, UpdateOdbPeeringConnectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOdbPeeringConnectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOdbPeeringConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.UpdateOdbPeeringConnection";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-08-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetOdbPeeringConnectionId())
                {
                    context.Writer.WritePropertyName("odbPeeringConnectionId");
                    context.Writer.Write(publicRequest.OdbPeeringConnectionId);
                }

                if(publicRequest.IsSetPeerNetworkCidrsToBeAdded())
                {
                    context.Writer.WritePropertyName("peerNetworkCidrsToBeAdded");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPeerNetworkCidrsToBeAddedListValue in publicRequest.PeerNetworkCidrsToBeAdded)
                    {
                            context.Writer.Write(publicRequestPeerNetworkCidrsToBeAddedListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPeerNetworkCidrsToBeRemoved())
                {
                    context.Writer.WritePropertyName("peerNetworkCidrsToBeRemoved");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPeerNetworkCidrsToBeRemovedListValue in publicRequest.PeerNetworkCidrsToBeRemoved)
                    {
                            context.Writer.Write(publicRequestPeerNetworkCidrsToBeRemovedListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateOdbPeeringConnectionRequestMarshaller _instance = new UpdateOdbPeeringConnectionRequestMarshaller();        

        internal static UpdateOdbPeeringConnectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOdbPeeringConnectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}