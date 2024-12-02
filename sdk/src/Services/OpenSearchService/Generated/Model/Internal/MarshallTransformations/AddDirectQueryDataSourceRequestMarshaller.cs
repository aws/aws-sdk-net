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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddDirectQueryDataSource Request Marshaller
    /// </summary>       
    public class AddDirectQueryDataSourceRequestMarshaller : IMarshaller<IRequest, AddDirectQueryDataSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddDirectQueryDataSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AddDirectQueryDataSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpenSearchService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2021-01-01/opensearch/directQueryDataSource";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDataSourceName())
                {
                    context.Writer.WritePropertyName("DataSourceName");
                    context.Writer.Write(publicRequest.DataSourceName);
                }

                if(publicRequest.IsSetDataSourceType())
                {
                    context.Writer.WritePropertyName("DataSourceType");
                    context.Writer.WriteObjectStart();

                    var marshaller = DirectQueryDataSourceTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSourceType, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetOpenSearchArns())
                {
                    context.Writer.WritePropertyName("OpenSearchArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOpenSearchArnsListValue in publicRequest.OpenSearchArns)
                    {
                            context.Writer.Write(publicRequestOpenSearchArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTagList())
                {
                    context.Writer.WritePropertyName("TagList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagListListValue in publicRequest.TagList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AddDirectQueryDataSourceRequestMarshaller _instance = new AddDirectQueryDataSourceRequestMarshaller();        

        internal static AddDirectQueryDataSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddDirectQueryDataSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}