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
    /// UpdateIdentitySource Request Marshaller
    /// </summary>       
    public class UpdateIdentitySourceRequestMarshaller : IMarshaller<IRequest, UpdateIdentitySourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIdentitySourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateIdentitySourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.VerifiedPermissions");
            string target = "VerifiedPermissions.UpdateIdentitySource";
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
                if(publicRequest.IsSetIdentitySourceId())
                {
                    context.Writer.WritePropertyName("identitySourceId");
                    context.Writer.Write(publicRequest.IdentitySourceId);
                }

                if(publicRequest.IsSetPolicyStoreId())
                {
                    context.Writer.WritePropertyName("policyStoreId");
                    context.Writer.Write(publicRequest.PolicyStoreId);
                }

                if(publicRequest.IsSetPrincipalEntityType())
                {
                    context.Writer.WritePropertyName("principalEntityType");
                    context.Writer.Write(publicRequest.PrincipalEntityType);
                }

                if(publicRequest.IsSetUpdateConfiguration())
                {
                    context.Writer.WritePropertyName("updateConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UpdateConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateIdentitySourceRequestMarshaller _instance = new UpdateIdentitySourceRequestMarshaller();        

        internal static UpdateIdentitySourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateIdentitySourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}