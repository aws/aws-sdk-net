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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
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
namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCampaign Request Marshaller
    /// </summary>       
    public class UpdateCampaignRequestMarshaller : IMarshaller<IRequest, UpdateCampaignRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCampaignRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCampaignRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Personalize");
            string target = "AmazonPersonalize.UpdateCampaign";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-22";
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
            if(publicRequest.IsSetCampaignArn())
            {
                context.Writer.WritePropertyName("campaignArn");
                context.Writer.WriteStringValue(publicRequest.CampaignArn);
            }

            if(publicRequest.IsSetCampaignConfig())
            {
                context.Writer.WritePropertyName("campaignConfig");
                context.Writer.WriteStartObject();

                var marshaller = CampaignConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CampaignConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMinProvisionedTPS())
            {
                context.Writer.WritePropertyName("minProvisionedTPS");
                context.Writer.WriteNumberValue(publicRequest.MinProvisionedTPS.Value);
            }

            if(publicRequest.IsSetSolutionVersionArn())
            {
                context.Writer.WritePropertyName("solutionVersionArn");
                context.Writer.WriteStringValue(publicRequest.SolutionVersionArn);
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
        private static UpdateCampaignRequestMarshaller _instance = new UpdateCampaignRequestMarshaller();        

        internal static UpdateCampaignRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCampaignRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}