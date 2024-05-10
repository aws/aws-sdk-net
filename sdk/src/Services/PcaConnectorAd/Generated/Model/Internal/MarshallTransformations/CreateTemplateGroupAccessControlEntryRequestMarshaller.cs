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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTemplateGroupAccessControlEntry Request Marshaller
    /// </summary>       
    public class CreateTemplateGroupAccessControlEntryRequestMarshaller : IMarshaller<IRequest, CreateTemplateGroupAccessControlEntryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTemplateGroupAccessControlEntryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTemplateGroupAccessControlEntryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PcaConnectorAd");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetTemplateArn())
                throw new AmazonPcaConnectorAdException("Request object does not have required field TemplateArn set");
            request.AddPathResource("{TemplateArn}", StringUtils.FromString(publicRequest.TemplateArn));
            request.ResourcePath = "/templates/{TemplateArn}/accessControlEntries";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessRights())
                {
                    context.Writer.WritePropertyName("AccessRights");
                    context.Writer.WriteObjectStart();

                    var marshaller = AccessRightsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AccessRights, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetGroupDisplayName())
                {
                    context.Writer.WritePropertyName("GroupDisplayName");
                    context.Writer.Write(publicRequest.GroupDisplayName);
                }

                if(publicRequest.IsSetGroupSecurityIdentifier())
                {
                    context.Writer.WritePropertyName("GroupSecurityIdentifier");
                    context.Writer.Write(publicRequest.GroupSecurityIdentifier);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTemplateGroupAccessControlEntryRequestMarshaller _instance = new CreateTemplateGroupAccessControlEntryRequestMarshaller();        

        internal static CreateTemplateGroupAccessControlEntryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTemplateGroupAccessControlEntryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}