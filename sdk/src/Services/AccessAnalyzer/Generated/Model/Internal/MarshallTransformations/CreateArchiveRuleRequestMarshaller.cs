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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateArchiveRule Request Marshaller
    /// </summary>       
    public class CreateArchiveRuleRequestMarshaller : IMarshaller<IRequest, CreateArchiveRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateArchiveRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateArchiveRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AccessAnalyzer");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAnalyzerName())
                throw new AmazonAccessAnalyzerException("Request object does not have required field AnalyzerName set");
            request.AddPathResource("{analyzerName}", StringUtils.FromString(publicRequest.AnalyzerName));
            request.ResourcePath = "/analyzer/{analyzerName}/archive-rule";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetFilter())
                {
                    context.Writer.WritePropertyName("filter");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFilterKvp in publicRequest.Filter)
                    {
                        context.Writer.WritePropertyName(publicRequestFilterKvp.Key);
                        var publicRequestFilterValue = publicRequestFilterKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = CriterionMarshaller.Instance;
                        marshaller.Marshall(publicRequestFilterValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRuleName())
                {
                    context.Writer.WritePropertyName("ruleName");
                    context.Writer.Write(publicRequest.RuleName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateArchiveRuleRequestMarshaller _instance = new CreateArchiveRuleRequestMarshaller();        

        internal static CreateArchiveRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateArchiveRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}