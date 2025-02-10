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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
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
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateReviewTemplate Request Marshaller
    /// </summary>       
    public class UpdateReviewTemplateRequestMarshaller : IMarshaller<IRequest, UpdateReviewTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateReviewTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateReviewTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetTemplateArn())
                throw new AmazonWellArchitectedException("Request object does not have required field TemplateArn set");
            request.AddPathResource("{TemplateArn}", StringUtils.FromString(publicRequest.TemplateArn));
            request.ResourcePath = "/reviewTemplates/{TemplateArn}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetLensesToAssociate())
            {
                context.Writer.WritePropertyName("LensesToAssociate");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLensesToAssociateListValue in publicRequest.LensesToAssociate)
                {
                        context.Writer.WriteStringValue(publicRequestLensesToAssociateListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLensesToDisassociate())
            {
                context.Writer.WritePropertyName("LensesToDisassociate");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLensesToDisassociateListValue in publicRequest.LensesToDisassociate)
                {
                        context.Writer.WriteStringValue(publicRequestLensesToDisassociateListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNotes())
            {
                context.Writer.WritePropertyName("Notes");
                context.Writer.WriteStringValue(publicRequest.Notes);
            }

            if(publicRequest.IsSetTemplateName())
            {
                context.Writer.WritePropertyName("TemplateName");
                context.Writer.WriteStringValue(publicRequest.TemplateName);
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
        private static UpdateReviewTemplateRequestMarshaller _instance = new UpdateReviewTemplateRequestMarshaller();        

        internal static UpdateReviewTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateReviewTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}