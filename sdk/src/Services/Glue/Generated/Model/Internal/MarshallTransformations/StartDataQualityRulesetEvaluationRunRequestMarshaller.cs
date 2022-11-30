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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDataQualityRulesetEvaluationRun Request Marshaller
    /// </summary>       
    public class StartDataQualityRulesetEvaluationRunRequestMarshaller : IMarshaller<IRequest, StartDataQualityRulesetEvaluationRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDataQualityRulesetEvaluationRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartDataQualityRulesetEvaluationRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.StartDataQualityRulesetEvaluationRun";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalRunOptions())
                {
                    context.Writer.WritePropertyName("AdditionalRunOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataQualityEvaluationRunAdditionalRunOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AdditionalRunOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetDataSource())
                {
                    context.Writer.WritePropertyName("DataSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNumberOfWorkers())
                {
                    context.Writer.WritePropertyName("NumberOfWorkers");
                    context.Writer.Write(publicRequest.NumberOfWorkers);
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("Role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetRulesetNames())
                {
                    context.Writer.WritePropertyName("RulesetNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRulesetNamesListValue in publicRequest.RulesetNames)
                    {
                            context.Writer.Write(publicRequestRulesetNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTimeout())
                {
                    context.Writer.WritePropertyName("Timeout");
                    context.Writer.Write(publicRequest.Timeout);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartDataQualityRulesetEvaluationRunRequestMarshaller _instance = new StartDataQualityRulesetEvaluationRunRequestMarshaller();        

        internal static StartDataQualityRulesetEvaluationRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartDataQualityRulesetEvaluationRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}