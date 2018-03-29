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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGrant Request Marshaller
    /// </summary>       
    public class CreateGrantRequestMarshaller : IMarshaller<IRequest, CreateGrantRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGrantRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGrantRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KeyManagementService");
            string target = "TrentService.CreateGrant";
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
                if(publicRequest.IsSetConstraints())
                {
                    context.Writer.WritePropertyName("Constraints");
                    context.Writer.WriteObjectStart();

                    var marshaller = GrantConstraintsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Constraints, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGranteePrincipal())
                {
                    context.Writer.WritePropertyName("GranteePrincipal");
                    context.Writer.Write(publicRequest.GranteePrincipal);
                }

                if(publicRequest.IsSetGrantTokens())
                {
                    context.Writer.WritePropertyName("GrantTokens");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGrantTokensListValue in publicRequest.GrantTokens)
                    {
                            context.Writer.Write(publicRequestGrantTokensListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKeyId())
                {
                    context.Writer.WritePropertyName("KeyId");
                    context.Writer.Write(publicRequest.KeyId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOperations())
                {
                    context.Writer.WritePropertyName("Operations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOperationsListValue in publicRequest.Operations)
                    {
                            context.Writer.Write(publicRequestOperationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRetiringPrincipal())
                {
                    context.Writer.WritePropertyName("RetiringPrincipal");
                    context.Writer.Write(publicRequest.RetiringPrincipal);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateGrantRequestMarshaller _instance = new CreateGrantRequestMarshaller();        

        internal static CreateGrantRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGrantRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}