/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFlowSource Request Marshaller
    /// </summary>       
    public class UpdateFlowSourceRequestMarshaller : IMarshaller<IRequest, UpdateFlowSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFlowSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFlowSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";            
            request.HttpMethod = "PUT";

            string uriResourcePath = "/v1/flows/{flowArn}/source/{sourceArn}";
            if (!publicRequest.IsSetFlowArn())
                throw new AmazonMediaConnectException("Request object does not have required field FlowArn set");
            uriResourcePath = uriResourcePath.Replace("{flowArn}", StringUtils.FromStringWithSlashEncoding(publicRequest.FlowArn));
            if (!publicRequest.IsSetSourceArn())
                throw new AmazonMediaConnectException("Request object does not have required field SourceArn set");
            uriResourcePath = uriResourcePath.Replace("{sourceArn}", StringUtils.FromStringWithSlashEncoding(publicRequest.SourceArn));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDecryption())
                {
                    context.Writer.WritePropertyName("decryption");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateEncryptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Decryption, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEntitlementArn())
                {
                    context.Writer.WritePropertyName("entitlementArn");
                    context.Writer.Write(publicRequest.EntitlementArn);
                }

                if(publicRequest.IsSetIngestPort())
                {
                    context.Writer.WritePropertyName("ingestPort");
                    context.Writer.Write(publicRequest.IngestPort);
                }

                if(publicRequest.IsSetMaxBitrate())
                {
                    context.Writer.WritePropertyName("maxBitrate");
                    context.Writer.Write(publicRequest.MaxBitrate);
                }

                if(publicRequest.IsSetMaxLatency())
                {
                    context.Writer.WritePropertyName("maxLatency");
                    context.Writer.Write(publicRequest.MaxLatency);
                }

                if(publicRequest.IsSetProtocol())
                {
                    context.Writer.WritePropertyName("protocol");
                    context.Writer.Write(publicRequest.Protocol);
                }

                if(publicRequest.IsSetStreamId())
                {
                    context.Writer.WritePropertyName("streamId");
                    context.Writer.Write(publicRequest.StreamId);
                }

                if(publicRequest.IsSetWhitelistCidr())
                {
                    context.Writer.WritePropertyName("whitelistCidr");
                    context.Writer.Write(publicRequest.WhitelistCidr);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFlowSourceRequestMarshaller _instance = new UpdateFlowSourceRequestMarshaller();        

        internal static UpdateFlowSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFlowSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}