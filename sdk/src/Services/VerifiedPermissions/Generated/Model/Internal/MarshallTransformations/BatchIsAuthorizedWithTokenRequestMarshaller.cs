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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VerifiedPermissions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.VerifiedPermissions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchIsAuthorizedWithToken Request Marshaller
    /// </summary>       
    public class BatchIsAuthorizedWithTokenRequestMarshaller : IMarshaller<IRequest, BatchIsAuthorizedWithTokenRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchIsAuthorizedWithTokenRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchIsAuthorizedWithTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.VerifiedPermissions");
            string target = "VerifiedPermissions.BatchIsAuthorizedWithToken";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessToken())
                {
                    context.Writer.WritePropertyName("accessToken");
                    context.Writer.Write(publicRequest.AccessToken);
                }

                if(publicRequest.IsSetEntities())
                {
                    context.Writer.WritePropertyName("entities");
                    context.Writer.WriteObjectStart();

                    var marshaller = EntitiesDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Entities, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIdentityToken())
                {
                    context.Writer.WritePropertyName("identityToken");
                    context.Writer.Write(publicRequest.IdentityToken);
                }

                if(publicRequest.IsSetPolicyStoreId())
                {
                    context.Writer.WritePropertyName("policyStoreId");
                    context.Writer.Write(publicRequest.PolicyStoreId);
                }

                if(publicRequest.IsSetRequests())
                {
                    context.Writer.WritePropertyName("requests");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRequestsListValue in publicRequest.Requests)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BatchIsAuthorizedWithTokenInputItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestRequestsListValue, context);

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
        private static BatchIsAuthorizedWithTokenRequestMarshaller _instance = new BatchIsAuthorizedWithTokenRequestMarshaller();        

        internal static BatchIsAuthorizedWithTokenRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchIsAuthorizedWithTokenRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}