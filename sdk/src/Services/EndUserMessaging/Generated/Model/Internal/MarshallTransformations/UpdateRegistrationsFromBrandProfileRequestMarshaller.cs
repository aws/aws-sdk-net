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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EndUserMessaging.Model;
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
namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRegistrationsFromBrandProfile Request Marshaller
    /// </summary>       
    public class UpdateRegistrationsFromBrandProfileRequestMarshaller : IMarshaller<IRequest, UpdateRegistrationsFromBrandProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRegistrationsFromBrandProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRegistrationsFromBrandProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EndUserMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-09-21";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetBrandProfileId())
                throw new AmazonEndUserMessagingException("Request object does not have required field BrandProfileId set");
            request.AddPathResource("{brandProfileId}", StringUtils.FromString(publicRequest.BrandProfileId));
            request.ResourcePath = "/v1/brand-profiles/{brandProfileId}/update-registrations";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetOnAttributeConflict())
            {
                context.Writer.WritePropertyName("onAttributeConflict");
                context.Writer.WriteStringValue(publicRequest.OnAttributeConflict);
            }

            if(publicRequest.IsSetRegistrationIds())
            {
                context.Writer.WritePropertyName("registrationIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRegistrationIdsListValue in publicRequest.RegistrationIds)
                {
                        context.Writer.WriteStringValue(publicRequestRegistrationIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSmartMatch())
            {
                context.Writer.WritePropertyName("smartMatch");
                context.Writer.WriteBooleanValue(publicRequest.SmartMatch.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateRegistrationsFromBrandProfileRequestMarshaller _instance = new UpdateRegistrationsFromBrandProfileRequestMarshaller();        

        internal static UpdateRegistrationsFromBrandProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRegistrationsFromBrandProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}