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
    /// PutPortfolioPreferences Request Marshaller
    /// </summary>       
    public class PutPortfolioPreferencesRequestMarshaller : IMarshaller<IRequest, PutPortfolioPreferencesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutPortfolioPreferencesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutPortfolioPreferencesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHubStrategyRecommendations");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-19";
            request.HttpMethod = "POST";

            request.ResourcePath = "/put-portfolio-preferences";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationMode())
                {
                    context.Writer.WritePropertyName("applicationMode");
                    context.Writer.Write(publicRequest.ApplicationMode);
                }

                if(publicRequest.IsSetApplicationPreferences())
                {
                    context.Writer.WritePropertyName("applicationPreferences");
                    context.Writer.WriteObjectStart();

                    var marshaller = ApplicationPreferencesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApplicationPreferences, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDatabasePreferences())
                {
                    context.Writer.WritePropertyName("databasePreferences");
                    context.Writer.WriteObjectStart();

                    var marshaller = DatabasePreferencesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DatabasePreferences, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPrioritizeBusinessGoals())
                {
                    context.Writer.WritePropertyName("prioritizeBusinessGoals");
                    context.Writer.WriteObjectStart();

                    var marshaller = PrioritizeBusinessGoalsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PrioritizeBusinessGoals, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutPortfolioPreferencesRequestMarshaller _instance = new PutPortfolioPreferencesRequestMarshaller();        

        internal static PutPortfolioPreferencesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutPortfolioPreferencesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}