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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryLineage Request Marshaller
    /// </summary>       
    public class QueryLineageRequestMarshaller : IMarshaller<IRequest, QueryLineageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryLineageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(QueryLineageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.QueryLineage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDirection())
                {
                    context.Writer.WritePropertyName("Direction");
                    context.Writer.Write(publicRequest.Direction);
                }

                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("Filters");
                    context.Writer.WriteObjectStart();

                    var marshaller = QueryFiltersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Filters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIncludeEdges())
                {
                    context.Writer.WritePropertyName("IncludeEdges");
                    context.Writer.Write(publicRequest.IncludeEdges);
                }

                if(publicRequest.IsSetMaxDepth())
                {
                    context.Writer.WritePropertyName("MaxDepth");
                    context.Writer.Write(publicRequest.MaxDepth);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetStartArns())
                {
                    context.Writer.WritePropertyName("StartArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStartArnsListValue in publicRequest.StartArns)
                    {
                            context.Writer.Write(publicRequestStartArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static QueryLineageRequestMarshaller _instance = new QueryLineageRequestMarshaller();        

        internal static QueryLineageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryLineageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}