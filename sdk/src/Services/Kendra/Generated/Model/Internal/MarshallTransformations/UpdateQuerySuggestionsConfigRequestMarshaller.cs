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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateQuerySuggestionsConfig Request Marshaller
    /// </summary>       
    public class UpdateQuerySuggestionsConfigRequestMarshaller : IMarshaller<IRequest, UpdateQuerySuggestionsConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateQuerySuggestionsConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateQuerySuggestionsConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kendra");
            string target = "AWSKendraFrontendService.UpdateQuerySuggestionsConfig";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-02-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIncludeQueriesWithoutUserInformation())
                {
                    context.Writer.WritePropertyName("IncludeQueriesWithoutUserInformation");
                    context.Writer.Write(publicRequest.IncludeQueriesWithoutUserInformation);
                }

                if(publicRequest.IsSetIndexId())
                {
                    context.Writer.WritePropertyName("IndexId");
                    context.Writer.Write(publicRequest.IndexId);
                }

                if(publicRequest.IsSetMinimumNumberOfQueryingUsers())
                {
                    context.Writer.WritePropertyName("MinimumNumberOfQueryingUsers");
                    context.Writer.Write(publicRequest.MinimumNumberOfQueryingUsers);
                }

                if(publicRequest.IsSetMinimumQueryCount())
                {
                    context.Writer.WritePropertyName("MinimumQueryCount");
                    context.Writer.Write(publicRequest.MinimumQueryCount);
                }

                if(publicRequest.IsSetMode())
                {
                    context.Writer.WritePropertyName("Mode");
                    context.Writer.Write(publicRequest.Mode);
                }

                if(publicRequest.IsSetQueryLogLookBackWindowInDays())
                {
                    context.Writer.WritePropertyName("QueryLogLookBackWindowInDays");
                    context.Writer.Write(publicRequest.QueryLogLookBackWindowInDays);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateQuerySuggestionsConfigRequestMarshaller _instance = new UpdateQuerySuggestionsConfigRequestMarshaller();        

        internal static UpdateQuerySuggestionsConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateQuerySuggestionsConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}