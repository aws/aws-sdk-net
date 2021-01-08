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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkLink.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkLink.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisassociateWebsiteCertificateAuthority Request Marshaller
    /// </summary>       
    public class DisassociateWebsiteCertificateAuthorityRequestMarshaller : IMarshaller<IRequest, DisassociateWebsiteCertificateAuthorityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateWebsiteCertificateAuthorityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisassociateWebsiteCertificateAuthorityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkLink");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-25";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/disassociateWebsiteCertificateAuthority";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFleetArn())
                {
                    context.Writer.WritePropertyName("FleetArn");
                    context.Writer.Write(publicRequest.FleetArn);
                }

                if(publicRequest.IsSetWebsiteCaId())
                {
                    context.Writer.WritePropertyName("WebsiteCaId");
                    context.Writer.Write(publicRequest.WebsiteCaId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DisassociateWebsiteCertificateAuthorityRequestMarshaller _instance = new DisassociateWebsiteCertificateAuthorityRequestMarshaller();        

        internal static DisassociateWebsiteCertificateAuthorityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisassociateWebsiteCertificateAuthorityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}