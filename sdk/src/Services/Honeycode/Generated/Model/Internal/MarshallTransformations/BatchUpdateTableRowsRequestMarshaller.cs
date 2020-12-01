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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Honeycode.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Honeycode.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateTableRows Request Marshaller
    /// </summary>       
    public class BatchUpdateTableRowsRequestMarshaller : IMarshaller<IRequest, BatchUpdateTableRowsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchUpdateTableRowsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchUpdateTableRowsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Honeycode");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-01";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetTableId())
                throw new AmazonHoneycodeException("Request object does not have required field TableId set");
            request.AddPathResource("{tableId}", StringUtils.FromString(publicRequest.TableId));
            if (!publicRequest.IsSetWorkbookId())
                throw new AmazonHoneycodeException("Request object does not have required field WorkbookId set");
            request.AddPathResource("{workbookId}", StringUtils.FromString(publicRequest.WorkbookId));
            request.ResourcePath = "/workbooks/{workbookId}/tables/{tableId}/rows/batchupdate";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                if(publicRequest.IsSetRowsToUpdate())
                {
                    context.Writer.WritePropertyName("rowsToUpdate");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRowsToUpdateListValue in publicRequest.RowsToUpdate)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = UpdateRowDataMarshaller.Instance;
                        marshaller.Marshall(publicRequestRowsToUpdateListValue, context);

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
        private static BatchUpdateTableRowsRequestMarshaller _instance = new BatchUpdateTableRowsRequestMarshaller();        

        internal static BatchUpdateTableRowsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchUpdateTableRowsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}