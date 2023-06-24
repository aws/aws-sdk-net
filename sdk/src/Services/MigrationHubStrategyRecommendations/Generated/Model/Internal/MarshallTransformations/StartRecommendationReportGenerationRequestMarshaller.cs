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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubStrategyRecommendations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartRecommendationReportGeneration Request Marshaller
    /// </summary>       
    public class StartRecommendationReportGenerationRequestMarshaller : IMarshaller<IRequest, StartRecommendationReportGenerationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartRecommendationReportGenerationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartRecommendationReportGenerationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHubStrategyRecommendations");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-19";
            request.HttpMethod = "POST";

            request.ResourcePath = "/start-recommendation-report-generation";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetGroupIdFilter())
                {
                    context.Writer.WritePropertyName("groupIdFilter");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGroupIdFilterListValue in publicRequest.GroupIdFilter)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GroupMarshaller.Instance;
                        marshaller.Marshall(publicRequestGroupIdFilterListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOutputFormat())
                {
                    context.Writer.WritePropertyName("outputFormat");
                    context.Writer.Write(publicRequest.OutputFormat);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartRecommendationReportGenerationRequestMarshaller _instance = new StartRecommendationReportGenerationRequestMarshaller();        

        internal static StartRecommendationReportGenerationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartRecommendationReportGenerationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}