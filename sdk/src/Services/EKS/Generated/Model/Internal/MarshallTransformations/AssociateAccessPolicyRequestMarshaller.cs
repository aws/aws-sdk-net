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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateAccessPolicy Request Marshaller
    /// </summary>       
    public class AssociateAccessPolicyRequestMarshaller : IMarshaller<IRequest, AssociateAccessPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateAccessPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateAccessPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetClusterName())
                throw new AmazonEKSException("Request object does not have required field ClusterName set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.ClusterName));
            if (!publicRequest.IsSetPrincipalArn())
                throw new AmazonEKSException("Request object does not have required field PrincipalArn set");
            request.AddPathResource("{principalArn}", StringUtils.FromString(publicRequest.PrincipalArn));
            request.ResourcePath = "/clusters/{name}/access-entries/{principalArn}/access-policies";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessScope())
                {
                    context.Writer.WritePropertyName("accessScope");
                    context.Writer.WriteObjectStart();

                    var marshaller = AccessScopeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AccessScope, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPolicyArn())
                {
                    context.Writer.WritePropertyName("policyArn");
                    context.Writer.Write(publicRequest.PolicyArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AssociateAccessPolicyRequestMarshaller _instance = new AssociateAccessPolicyRequestMarshaller();        

        internal static AssociateAccessPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateAccessPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}