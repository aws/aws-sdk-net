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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceDiscovery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceDiscovery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePublicDnsNamespace Request Marshaller
    /// </summary>       
    public class UpdatePublicDnsNamespaceRequestMarshaller : IMarshaller<IRequest, UpdatePublicDnsNamespaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePublicDnsNamespaceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePublicDnsNamespaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceDiscovery");
            string target = "Route53AutoNaming_v20170314.UpdatePublicDnsNamespace";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetId())
                {
                    context.Writer.WritePropertyName("Id");
                    context.Writer.Write(publicRequest.Id);
                }

                if(publicRequest.IsSetNamespace())
                {
                    context.Writer.WritePropertyName("Namespace");
                    context.Writer.WriteObjectStart();

                    var marshaller = PublicDnsNamespaceChangeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Namespace, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUpdaterRequestId())
                {
                    context.Writer.WritePropertyName("UpdaterRequestId");
                    context.Writer.Write(publicRequest.UpdaterRequestId);
                }

                else if(!(publicRequest.IsSetUpdaterRequestId()))
                {
                    context.Writer.WritePropertyName("UpdaterRequestId");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdatePublicDnsNamespaceRequestMarshaller _instance = new UpdatePublicDnsNamespaceRequestMarshaller();        

        internal static UpdatePublicDnsNamespaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePublicDnsNamespaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}