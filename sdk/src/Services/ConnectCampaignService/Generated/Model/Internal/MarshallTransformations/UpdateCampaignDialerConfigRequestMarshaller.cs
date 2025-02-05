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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignService.Model;
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
namespace Amazon.ConnectCampaignService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCampaignDialerConfig Request Marshaller
    /// </summary>       
    public class UpdateCampaignDialerConfigRequestMarshaller : IMarshaller<IRequest, UpdateCampaignDialerConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCampaignDialerConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCampaignDialerConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectCampaignService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-30";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetId())
                throw new AmazonConnectCampaignServiceException("Request object does not have required field Id set");
            request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/campaigns/{id}/dialer-config";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDialerConfig())
            {
                context.Writer.WritePropertyName("dialerConfig");
                context.Writer.WriteStartObject();

                var marshaller = DialerConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DialerConfig, context);

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
            


            return request;
        }
        private static UpdateCampaignDialerConfigRequestMarshaller _instance = new UpdateCampaignDialerConfigRequestMarshaller();        

        internal static UpdateCampaignDialerConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCampaignDialerConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}