/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PollForJobs Request Marshaller
    /// </summary>       
    public class PollForJobsRequestMarshaller : IMarshaller<IRequest, PollForJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PollForJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PollForJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodePipeline");
            string target = "CodePipeline_20150709.PollForJobs";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActionTypeId())
                {
                    context.Writer.WritePropertyName("actionTypeId");
                    context.Writer.WriteObjectStart();

                    var marshaller = ActionTypeIdMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ActionTypeId, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxBatchSize())
                {
                    context.Writer.WritePropertyName("maxBatchSize");
                    context.Writer.Write(publicRequest.MaxBatchSize);
                }

                if(publicRequest.IsSetQueryParam())
                {
                    context.Writer.WritePropertyName("queryParam");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestQueryParamKvp in publicRequest.QueryParam)
                    {
                        context.Writer.WritePropertyName(publicRequestQueryParamKvp.Key);
                        var publicRequestQueryParamValue = publicRequestQueryParamKvp.Value;

                            context.Writer.Write(publicRequestQueryParamValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PollForJobsRequestMarshaller _instance = new PollForJobsRequestMarshaller();        

        internal static PollForJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PollForJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}