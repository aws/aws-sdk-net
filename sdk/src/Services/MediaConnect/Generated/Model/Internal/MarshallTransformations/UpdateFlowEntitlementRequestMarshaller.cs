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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFlowEntitlement Request Marshaller
    /// </summary>       
    public class UpdateFlowEntitlementRequestMarshaller : IMarshaller<IRequest, UpdateFlowEntitlementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFlowEntitlementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFlowEntitlementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";            
            request.HttpMethod = "PUT";

            string uriResourcePath = "/v1/flows/{flowArn}/entitlements/{entitlementArn}";
            if (!publicRequest.IsSetEntitlementArn())
                throw new AmazonMediaConnectException("Request object does not have required field EntitlementArn set");
            uriResourcePath = uriResourcePath.Replace("{entitlementArn}", StringUtils.FromStringWithSlashEncoding(publicRequest.EntitlementArn));
            if (!publicRequest.IsSetFlowArn())
                throw new AmazonMediaConnectException("Request object does not have required field FlowArn set");
            uriResourcePath = uriResourcePath.Replace("{flowArn}", StringUtils.FromStringWithSlashEncoding(publicRequest.FlowArn));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEncryption())
                {
                    context.Writer.WritePropertyName("encryption");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateEncryptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Encryption, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSubscribers())
                {
                    context.Writer.WritePropertyName("subscribers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubscribersListValue in publicRequest.Subscribers)
                    {
                            context.Writer.Write(publicRequestSubscribersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFlowEntitlementRequestMarshaller _instance = new UpdateFlowEntitlementRequestMarshaller();        

        internal static UpdateFlowEntitlementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFlowEntitlementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}