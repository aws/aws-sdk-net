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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEngagementContext Request Marshaller
    /// </summary>       
    public class UpdateEngagementContextRequestMarshaller : IMarshaller<IRequest, UpdateEngagementContextRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEngagementContextRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEngagementContextRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralSelling");
            string target = "AWSPartnerCentralSelling.UpdateEngagementContext";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCatalog())
                {
                    context.Writer.WritePropertyName("Catalog");
                    context.Writer.Write(publicRequest.Catalog);
                }

                if(publicRequest.IsSetContextIdentifier())
                {
                    context.Writer.WritePropertyName("ContextIdentifier");
                    context.Writer.Write(publicRequest.ContextIdentifier);
                }

                if(publicRequest.IsSetEngagementIdentifier())
                {
                    context.Writer.WritePropertyName("EngagementIdentifier");
                    context.Writer.Write(publicRequest.EngagementIdentifier);
                }

                if(publicRequest.IsSetEngagementLastModifiedAt())
                {
                    context.Writer.WritePropertyName("EngagementLastModifiedAt");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EngagementLastModifiedAt));
                }

                if(publicRequest.IsSetPayload())
                {
                    context.Writer.WritePropertyName("Payload");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateEngagementContextPayloadMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Payload, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("Type");
                    context.Writer.Write(publicRequest.Type);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateEngagementContextRequestMarshaller _instance = new UpdateEngagementContextRequestMarshaller();        

        internal static UpdateEngagementContextRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEngagementContextRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}