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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListLogSources Request Marshaller
    /// </summary>       
    public class ListLogSourcesRequestMarshaller : IMarshaller<IRequest, ListLogSourcesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListLogSourcesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListLogSourcesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityLake");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/logsources/list";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetInputOrder())
                {
                    context.Writer.WritePropertyName("inputOrder");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputOrderListValue in publicRequest.InputOrder)
                    {
                            context.Writer.Write(publicRequestInputOrderListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetListAllDimensions())
                {
                    context.Writer.WritePropertyName("listAllDimensions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestListAllDimensionsKvp in publicRequest.ListAllDimensions)
                    {
                        context.Writer.WritePropertyName(publicRequestListAllDimensionsKvp.Key);
                        var publicRequestListAllDimensionsValue = publicRequestListAllDimensionsKvp.Value;

                        context.Writer.WriteObjectStart();
                        foreach (var publicRequestListAllDimensionsValueKvp in publicRequestListAllDimensionsValue)
                        {
                            context.Writer.WritePropertyName(publicRequestListAllDimensionsValueKvp.Key);
                            var publicRequestListAllDimensionsValueValue = publicRequestListAllDimensionsValueKvp.Value;

                            context.Writer.WriteArrayStart();
                            foreach(var publicRequestListAllDimensionsValueValueListValue in publicRequestListAllDimensionsValueValue)
                            {
                                    context.Writer.Write(publicRequestListAllDimensionsValueValueListValue);
                            }
                            context.Writer.WriteArrayEnd();
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetListSingleDimension())
                {
                    context.Writer.WritePropertyName("listSingleDimension");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestListSingleDimensionListValue in publicRequest.ListSingleDimension)
                    {
                            context.Writer.Write(publicRequestListSingleDimensionListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetListTwoDimensions())
                {
                    context.Writer.WritePropertyName("listTwoDimensions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestListTwoDimensionsKvp in publicRequest.ListTwoDimensions)
                    {
                        context.Writer.WritePropertyName(publicRequestListTwoDimensionsKvp.Key);
                        var publicRequestListTwoDimensionsValue = publicRequestListTwoDimensionsKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestListTwoDimensionsValueListValue in publicRequestListTwoDimensionsValue)
                        {
                                context.Writer.Write(publicRequestListTwoDimensionsValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListLogSourcesRequestMarshaller _instance = new ListLogSourcesRequestMarshaller();        

        internal static ListLogSourcesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListLogSourcesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}