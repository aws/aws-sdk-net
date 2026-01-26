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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTemplate Request Marshaller
    /// </summary>       
    public class UpdateTemplateRequestMarshaller : IMarshaller<IRequest, UpdateTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectCases");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-03";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDomainId())
                throw new AmazonConnectCasesException("Request object does not have required field DomainId set");
            request.AddPathResource("{domainId}", StringUtils.FromString(publicRequest.DomainId));
            if (!publicRequest.IsSetTemplateId())
                throw new AmazonConnectCasesException("Request object does not have required field TemplateId set");
            request.AddPathResource("{templateId}", StringUtils.FromString(publicRequest.TemplateId));
            request.ResourcePath = "/domains/{domainId}/templates/{templateId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetLayoutConfiguration())
                {
                    context.Writer.WritePropertyName("layoutConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LayoutConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LayoutConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRequiredFields())
                {
                    context.Writer.WritePropertyName("requiredFields");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRequiredFieldsListValue in publicRequest.RequiredFields)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RequiredFieldMarshaller.Instance;
                        marshaller.Marshall(publicRequestRequiredFieldsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRules())
                {
                    context.Writer.WritePropertyName("rules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRulesListValue in publicRequest.Rules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TemplateRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestRulesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetTagPropagationConfigurations())
                {
                    context.Writer.WritePropertyName("tagPropagationConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagPropagationConfigurationsListValue in publicRequest.TagPropagationConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagPropagationConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagPropagationConfigurationsListValue, context);

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
        private static UpdateTemplateRequestMarshaller _instance = new UpdateTemplateRequestMarshaller();        

        internal static UpdateTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}