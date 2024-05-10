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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSOAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SSOAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutApplicationGrant Request Marshaller
    /// </summary>       
    public class PutApplicationGrantRequestMarshaller : IMarshaller<IRequest, PutApplicationGrantRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutApplicationGrantRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutApplicationGrantRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSOAdmin");
            string target = "SWBExternalService.PutApplicationGrant";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationArn())
                {
                    context.Writer.WritePropertyName("ApplicationArn");
                    context.Writer.Write(publicRequest.ApplicationArn);
                }

                if(publicRequest.IsSetGrant())
                {
                    context.Writer.WritePropertyName("Grant");
                    context.Writer.WriteObjectStart();

                    var marshaller = GrantMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Grant, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGrantType())
                {
                    context.Writer.WritePropertyName("GrantType");
                    context.Writer.Write(publicRequest.GrantType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutApplicationGrantRequestMarshaller _instance = new PutApplicationGrantRequestMarshaller();        

        internal static PutApplicationGrantRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutApplicationGrantRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}