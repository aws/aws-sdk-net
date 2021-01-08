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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataExchange.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRevision Request Marshaller
    /// </summary>       
    public class UpdateRevisionRequestMarshaller : IMarshaller<IRequest, UpdateRevisionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRevisionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRevisionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataExchange");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetDataSetId())
                throw new AmazonDataExchangeException("Request object does not have required field DataSetId set");
            request.AddPathResource("{DataSetId}", StringUtils.FromString(publicRequest.DataSetId));
            if (!publicRequest.IsSetRevisionId())
                throw new AmazonDataExchangeException("Request object does not have required field RevisionId set");
            request.AddPathResource("{RevisionId}", StringUtils.FromString(publicRequest.RevisionId));
            request.ResourcePath = "/v1/data-sets/{DataSetId}/revisions/{RevisionId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComment())
                {
                    context.Writer.WritePropertyName("Comment");
                    context.Writer.Write(publicRequest.Comment);
                }

                if(publicRequest.IsSetFinalized())
                {
                    context.Writer.WritePropertyName("Finalized");
                    context.Writer.Write(publicRequest.Finalized);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateRevisionRequestMarshaller _instance = new UpdateRevisionRequestMarshaller();        

        internal static UpdateRevisionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRevisionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}