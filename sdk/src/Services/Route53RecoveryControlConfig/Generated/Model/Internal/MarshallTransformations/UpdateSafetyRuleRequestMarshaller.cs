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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53RecoveryControlConfig.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53RecoveryControlConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSafetyRule Request Marshaller
    /// </summary>       
    public class UpdateSafetyRuleRequestMarshaller : IMarshaller<IRequest, UpdateSafetyRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSafetyRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSafetyRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53RecoveryControlConfig");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-02";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/safetyrule";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssertionRuleUpdate())
                {
                    context.Writer.WritePropertyName("AssertionRuleUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = AssertionRuleUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AssertionRuleUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGatingRuleUpdate())
                {
                    context.Writer.WritePropertyName("GatingRuleUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = GatingRuleUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GatingRuleUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSafetyRuleRequestMarshaller _instance = new UpdateSafetyRuleRequestMarshaller();        

        internal static UpdateSafetyRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSafetyRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}