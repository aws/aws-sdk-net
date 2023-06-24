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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateWebACL Request Marshaller
    /// </summary>       
    public class UpdateWebACLRequestMarshaller : IMarshaller<IRequest, UpdateWebACLRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateWebACLRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateWebACLRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WAFV2");
            string target = "AWSWAF_20190729.UpdateWebACL";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociationConfig())
                {
                    context.Writer.WritePropertyName("AssociationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AssociationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AssociationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCaptchaConfig())
                {
                    context.Writer.WritePropertyName("CaptchaConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = CaptchaConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CaptchaConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetChallengeConfig())
                {
                    context.Writer.WritePropertyName("ChallengeConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ChallengeConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ChallengeConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCustomResponseBodies())
                {
                    context.Writer.WritePropertyName("CustomResponseBodies");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestCustomResponseBodiesKvp in publicRequest.CustomResponseBodies)
                    {
                        context.Writer.WritePropertyName(publicRequestCustomResponseBodiesKvp.Key);
                        var publicRequestCustomResponseBodiesValue = publicRequestCustomResponseBodiesKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = CustomResponseBodyMarshaller.Instance;
                        marshaller.Marshall(publicRequestCustomResponseBodiesValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaultAction())
                {
                    context.Writer.WritePropertyName("DefaultAction");
                    context.Writer.WriteObjectStart();

                    var marshaller = DefaultActionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefaultAction, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetId())
                {
                    context.Writer.WritePropertyName("Id");
                    context.Writer.Write(publicRequest.Id);
                }

                if(publicRequest.IsSetLockToken())
                {
                    context.Writer.WritePropertyName("LockToken");
                    context.Writer.Write(publicRequest.LockToken);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRules())
                {
                    context.Writer.WritePropertyName("Rules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRulesListValue in publicRequest.Rules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestRulesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetScope())
                {
                    context.Writer.WritePropertyName("Scope");
                    context.Writer.Write(publicRequest.Scope);
                }

                if(publicRequest.IsSetTokenDomains())
                {
                    context.Writer.WritePropertyName("TokenDomains");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTokenDomainsListValue in publicRequest.TokenDomains)
                    {
                            context.Writer.Write(publicRequestTokenDomainsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVisibilityConfig())
                {
                    context.Writer.WritePropertyName("VisibilityConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VisibilityConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VisibilityConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateWebACLRequestMarshaller _instance = new UpdateWebACLRequestMarshaller();        

        internal static UpdateWebACLRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateWebACLRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}