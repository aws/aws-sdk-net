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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCostCategoryDefinition Request Marshaller
    /// </summary>       
    public class CreateCostCategoryDefinitionRequestMarshaller : IMarshaller<IRequest, CreateCostCategoryDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCostCategoryDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCostCategoryDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CostExplorer");
            string target = "AWSInsightsIndexService.CreateCostCategoryDefinition";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefaultValue())
                {
                    context.Writer.WritePropertyName("DefaultValue");
                    context.Writer.Write(publicRequest.DefaultValue);
                }

                if(publicRequest.IsSetEffectiveStart())
                {
                    context.Writer.WritePropertyName("EffectiveStart");
                    context.Writer.Write(publicRequest.EffectiveStart);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetResourceTags())
                {
                    context.Writer.WritePropertyName("ResourceTags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceTagsListValue in publicRequest.ResourceTags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ResourceTagMarshaller.Instance;
                        marshaller.Marshall(publicRequestResourceTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRules())
                {
                    context.Writer.WritePropertyName("Rules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRulesListValue in publicRequest.Rules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CostCategoryRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestRulesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRuleVersion())
                {
                    context.Writer.WritePropertyName("RuleVersion");
                    context.Writer.Write(publicRequest.RuleVersion);
                }

                if(publicRequest.IsSetSplitChargeRules())
                {
                    context.Writer.WritePropertyName("SplitChargeRules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSplitChargeRulesListValue in publicRequest.SplitChargeRules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CostCategorySplitChargeRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestSplitChargeRulesListValue, context);

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
        private static CreateCostCategoryDefinitionRequestMarshaller _instance = new CreateCostCategoryDefinitionRequestMarshaller();        

        internal static CreateCostCategoryDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCostCategoryDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}