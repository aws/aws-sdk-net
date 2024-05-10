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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutConfiguredAudienceModelPolicy Request Marshaller
    /// </summary>       
    public class PutConfiguredAudienceModelPolicyRequestMarshaller : IMarshaller<IRequest, PutConfiguredAudienceModelPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutConfiguredAudienceModelPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutConfiguredAudienceModelPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRoomsML");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-06";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetConfiguredAudienceModelArn())
                throw new AmazonCleanRoomsMLException("Request object does not have required field ConfiguredAudienceModelArn set");
            request.AddPathResource("{configuredAudienceModelArn}", StringUtils.FromString(publicRequest.ConfiguredAudienceModelArn));
            request.ResourcePath = "/configured-audience-model/{configuredAudienceModelArn}/policy";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfiguredAudienceModelPolicy())
                {
                    context.Writer.WritePropertyName("configuredAudienceModelPolicy");
                    context.Writer.Write(publicRequest.ConfiguredAudienceModelPolicy);
                }

                if(publicRequest.IsSetPolicyExistenceCondition())
                {
                    context.Writer.WritePropertyName("policyExistenceCondition");
                    context.Writer.Write(publicRequest.PolicyExistenceCondition);
                }

                if(publicRequest.IsSetPreviousPolicyHash())
                {
                    context.Writer.WritePropertyName("previousPolicyHash");
                    context.Writer.Write(publicRequest.PreviousPolicyHash);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutConfiguredAudienceModelPolicyRequestMarshaller _instance = new PutConfiguredAudienceModelPolicyRequestMarshaller();        

        internal static PutConfiguredAudienceModelPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutConfiguredAudienceModelPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}