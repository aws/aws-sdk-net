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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECR.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePullThroughCacheRule Request Marshaller
    /// </summary>       
    public class CreatePullThroughCacheRuleRequestMarshaller : IMarshaller<IRequest, CreatePullThroughCacheRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePullThroughCacheRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePullThroughCacheRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECR");
            string target = "AmazonEC2ContainerRegistry_V20150921.CreatePullThroughCacheRule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-09-21";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCredentialArn())
                {
                    context.Writer.WritePropertyName("credentialArn");
                    context.Writer.Write(publicRequest.CredentialArn);
                }

                if(publicRequest.IsSetCustomRoleArn())
                {
                    context.Writer.WritePropertyName("customRoleArn");
                    context.Writer.Write(publicRequest.CustomRoleArn);
                }

                if(publicRequest.IsSetEcrRepositoryPrefix())
                {
                    context.Writer.WritePropertyName("ecrRepositoryPrefix");
                    context.Writer.Write(publicRequest.EcrRepositoryPrefix);
                }

                if(publicRequest.IsSetRegistryId())
                {
                    context.Writer.WritePropertyName("registryId");
                    context.Writer.Write(publicRequest.RegistryId);
                }

                if(publicRequest.IsSetUpstreamRegistry())
                {
                    context.Writer.WritePropertyName("upstreamRegistry");
                    context.Writer.Write(publicRequest.UpstreamRegistry);
                }

                if(publicRequest.IsSetUpstreamRegistryUrl())
                {
                    context.Writer.WritePropertyName("upstreamRegistryUrl");
                    context.Writer.Write(publicRequest.UpstreamRegistryUrl);
                }

                if(publicRequest.IsSetUpstreamRepositoryPrefix())
                {
                    context.Writer.WritePropertyName("upstreamRepositoryPrefix");
                    context.Writer.Write(publicRequest.UpstreamRepositoryPrefix);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreatePullThroughCacheRuleRequestMarshaller _instance = new CreatePullThroughCacheRuleRequestMarshaller();        

        internal static CreatePullThroughCacheRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePullThroughCacheRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}