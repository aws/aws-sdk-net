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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PinpointEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutEmailIdentityMailFromAttributes Request Marshaller
    /// </summary>       
    public class PutEmailIdentityMailFromAttributesRequestMarshaller : IMarshaller<IRequest, PutEmailIdentityMailFromAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutEmailIdentityMailFromAttributesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutEmailIdentityMailFromAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointEmail");
            string target = "com.amazonaws.services.pinpoint.email.PutEmailIdentityMailFromAttributes";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-07-26";            
            request.HttpMethod = "PUT";

            string uriResourcePath = "/v1/email/identities/{EmailIdentity}/mail-from";
            if (!publicRequest.IsSetEmailIdentity())
                throw new AmazonPinpointEmailException("Request object does not have required field EmailIdentity set");
            uriResourcePath = uriResourcePath.Replace("{EmailIdentity}", StringUtils.FromStringWithSlashEncoding(publicRequest.EmailIdentity));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBehaviorOnMxFailure())
                {
                    context.Writer.WritePropertyName("BehaviorOnMxFailure");
                    context.Writer.Write(publicRequest.BehaviorOnMxFailure);
                }

                if(publicRequest.IsSetMailFromDomain())
                {
                    context.Writer.WritePropertyName("MailFromDomain");
                    context.Writer.Write(publicRequest.MailFromDomain);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutEmailIdentityMailFromAttributesRequestMarshaller _instance = new PutEmailIdentityMailFromAttributesRequestMarshaller();        

        internal static PutEmailIdentityMailFromAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutEmailIdentityMailFromAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}