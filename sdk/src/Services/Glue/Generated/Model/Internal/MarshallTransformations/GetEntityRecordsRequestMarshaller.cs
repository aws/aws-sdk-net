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

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEntityRecords Request Marshaller
    /// </summary>       
    public class GetEntityRecordsRequestMarshaller : IMarshaller<IRequest, GetEntityRecordsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEntityRecordsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetEntityRecordsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.GetEntityRecords";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCatalogId())
                {
                    context.Writer.WritePropertyName("CatalogId");
                    context.Writer.Write(publicRequest.CatalogId);
                }

                if(publicRequest.IsSetConnectionName())
                {
                    context.Writer.WritePropertyName("ConnectionName");
                    context.Writer.Write(publicRequest.ConnectionName);
                }

                if(publicRequest.IsSetConnectionOptions())
                {
                    context.Writer.WritePropertyName("ConnectionOptions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestConnectionOptionsKvp in publicRequest.ConnectionOptions)
                    {
                        context.Writer.WritePropertyName(publicRequestConnectionOptionsKvp.Key);
                        var publicRequestConnectionOptionsValue = publicRequestConnectionOptionsKvp.Value;

                            context.Writer.Write(publicRequestConnectionOptionsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataStoreApiVersion())
                {
                    context.Writer.WritePropertyName("DataStoreApiVersion");
                    context.Writer.Write(publicRequest.DataStoreApiVersion);
                }

                if(publicRequest.IsSetEntityName())
                {
                    context.Writer.WritePropertyName("EntityName");
                    context.Writer.Write(publicRequest.EntityName);
                }

                if(publicRequest.IsSetFilterPredicate())
                {
                    context.Writer.WritePropertyName("FilterPredicate");
                    context.Writer.Write(publicRequest.FilterPredicate);
                }

                if(publicRequest.IsSetLimit())
                {
                    context.Writer.WritePropertyName("Limit");
                    context.Writer.Write(publicRequest.Limit);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetOrderBy())
                {
                    context.Writer.WritePropertyName("OrderBy");
                    context.Writer.Write(publicRequest.OrderBy);
                }

                if(publicRequest.IsSetSelectedFields())
                {
                    context.Writer.WritePropertyName("SelectedFields");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSelectedFieldsListValue in publicRequest.SelectedFields)
                    {
                            context.Writer.Write(publicRequestSelectedFieldsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetEntityRecordsRequestMarshaller _instance = new GetEntityRecordsRequestMarshaller();        

        internal static GetEntityRecordsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetEntityRecordsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}