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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFlowMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFlowMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateScope Request Marshaller
    /// </summary>       
    public class UpdateScopeRequestMarshaller : IMarshaller<IRequest, UpdateScopeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateScopeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateScopeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFlowMonitor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-19";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetScopeId())
                throw new AmazonNetworkFlowMonitorException("Request object does not have required field ScopeId set");
            request.AddPathResource("{scopeId}", StringUtils.FromString(publicRequest.ScopeId));
            request.ResourcePath = "/scopes/{scopeId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetResourcesToAdd())
                {
                    context.Writer.WritePropertyName("resourcesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourcesToAddListValue in publicRequest.ResourcesToAdd)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TargetResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestResourcesToAddListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourcesToDelete())
                {
                    context.Writer.WritePropertyName("resourcesToDelete");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourcesToDeleteListValue in publicRequest.ResourcesToDelete)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TargetResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestResourcesToDeleteListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateScopeRequestMarshaller _instance = new UpdateScopeRequestMarshaller();        

        internal static UpdateScopeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateScopeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}