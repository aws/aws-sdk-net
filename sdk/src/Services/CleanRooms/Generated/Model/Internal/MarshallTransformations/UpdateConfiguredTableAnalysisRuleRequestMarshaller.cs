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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateConfiguredTableAnalysisRule Request Marshaller
    /// </summary>       
    public class UpdateConfiguredTableAnalysisRuleRequestMarshaller : IMarshaller<IRequest, UpdateConfiguredTableAnalysisRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateConfiguredTableAnalysisRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateConfiguredTableAnalysisRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetAnalysisRuleType())
                throw new AmazonCleanRoomsException("Request object does not have required field AnalysisRuleType set");
            request.AddPathResource("{analysisRuleType}", StringUtils.FromString(publicRequest.AnalysisRuleType));
            if (!publicRequest.IsSetConfiguredTableIdentifier())
                throw new AmazonCleanRoomsException("Request object does not have required field ConfiguredTableIdentifier set");
            request.AddPathResource("{configuredTableIdentifier}", StringUtils.FromString(publicRequest.ConfiguredTableIdentifier));
            request.ResourcePath = "/configuredTables/{configuredTableIdentifier}/analysisRule/{analysisRuleType}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAnalysisRulePolicy())
                {
                    context.Writer.WritePropertyName("analysisRulePolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfiguredTableAnalysisRulePolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AnalysisRulePolicy, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateConfiguredTableAnalysisRuleRequestMarshaller _instance = new UpdateConfiguredTableAnalysisRuleRequestMarshaller();        

        internal static UpdateConfiguredTableAnalysisRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateConfiguredTableAnalysisRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}