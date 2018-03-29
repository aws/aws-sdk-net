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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectoryService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTrust Request Marshaller
    /// </summary>       
    public class CreateTrustRequestMarshaller : IMarshaller<IRequest, CreateTrustRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrustRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTrustRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectoryService");
            string target = "DirectoryService_20150416.CreateTrust";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConditionalForwarderIpAddrs())
                {
                    context.Writer.WritePropertyName("ConditionalForwarderIpAddrs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestConditionalForwarderIpAddrsListValue in publicRequest.ConditionalForwarderIpAddrs)
                    {
                            context.Writer.Write(publicRequestConditionalForwarderIpAddrsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDirectoryId())
                {
                    context.Writer.WritePropertyName("DirectoryId");
                    context.Writer.Write(publicRequest.DirectoryId);
                }

                if(publicRequest.IsSetRemoteDomainName())
                {
                    context.Writer.WritePropertyName("RemoteDomainName");
                    context.Writer.Write(publicRequest.RemoteDomainName);
                }

                if(publicRequest.IsSetTrustDirection())
                {
                    context.Writer.WritePropertyName("TrustDirection");
                    context.Writer.Write(publicRequest.TrustDirection);
                }

                if(publicRequest.IsSetTrustPassword())
                {
                    context.Writer.WritePropertyName("TrustPassword");
                    context.Writer.Write(publicRequest.TrustPassword);
                }

                if(publicRequest.IsSetTrustType())
                {
                    context.Writer.WritePropertyName("TrustType");
                    context.Writer.Write(publicRequest.TrustType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTrustRequestMarshaller _instance = new CreateTrustRequestMarshaller();        

        internal static CreateTrustRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTrustRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}