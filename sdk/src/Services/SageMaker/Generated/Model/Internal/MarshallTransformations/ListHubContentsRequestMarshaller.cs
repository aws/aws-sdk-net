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
    /// ListHubContents Request Marshaller
    /// </summary>       
    public class ListHubContentsRequestMarshaller : IMarshaller<IRequest, ListHubContentsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListHubContentsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListHubContentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.ListHubContents";
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
                if(publicRequest.IsSetCreationTimeAfter())
                {
                    context.Writer.WritePropertyName("CreationTimeAfter");
                    context.Writer.Write(publicRequest.CreationTimeAfter);
                }

                if(publicRequest.IsSetCreationTimeBefore())
                {
                    context.Writer.WritePropertyName("CreationTimeBefore");
                    context.Writer.Write(publicRequest.CreationTimeBefore);
                }

                if(publicRequest.IsSetHubContentType())
                {
                    context.Writer.WritePropertyName("HubContentType");
                    context.Writer.Write(publicRequest.HubContentType);
                }

                if(publicRequest.IsSetHubName())
                {
                    context.Writer.WritePropertyName("HubName");
                    context.Writer.Write(publicRequest.HubName);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetMaxSchemaVersion())
                {
                    context.Writer.WritePropertyName("MaxSchemaVersion");
                    context.Writer.Write(publicRequest.MaxSchemaVersion);
                }

                if(publicRequest.IsSetNameContains())
                {
                    context.Writer.WritePropertyName("NameContains");
                    context.Writer.Write(publicRequest.NameContains);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetSortBy())
                {
                    context.Writer.WritePropertyName("SortBy");
                    context.Writer.Write(publicRequest.SortBy);
                }

                if(publicRequest.IsSetSortOrder())
                {
                    context.Writer.WritePropertyName("SortOrder");
                    context.Writer.Write(publicRequest.SortOrder);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListHubContentsRequestMarshaller _instance = new ListHubContentsRequestMarshaller();        

        internal static ListHubContentsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListHubContentsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}