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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Interconnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Interconnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConnection Request Marshaller
    /// </summary>       
    public class CreateConnectionRequestMarshaller : IMarshaller<IRequest, CreateConnectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConnectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Interconnect");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/Interconnect/operation/CreateConnection";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAttachPoint())
                {
                    context.Writer.WriteTextString("attachPoint");
                    context.Writer.WriteStartMap(null);

                    var marshaller = AttachPointMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AttachPoint, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetBandwidth())
                {
                    context.Writer.WriteTextString("bandwidth");
                    context.Writer.WriteTextString(publicRequest.Bandwidth);
                }
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("clientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else if (!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WriteTextString("clientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetEnvironmentId())
                {
                    context.Writer.WriteTextString("environmentId");
                    context.Writer.WriteTextString(publicRequest.EnvironmentId);
                }
                if (publicRequest.IsSetRemoteAccount())
                {
                    context.Writer.WriteTextString("remoteAccount");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RemoteAccountIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RemoteAccount, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("tags");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WriteTextString(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.WriteTextString(publicRequestTagsValue);
                    }
                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static CreateConnectionRequestMarshaller _instance = new CreateConnectionRequestMarshaller();        

        internal static CreateConnectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateConnectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}