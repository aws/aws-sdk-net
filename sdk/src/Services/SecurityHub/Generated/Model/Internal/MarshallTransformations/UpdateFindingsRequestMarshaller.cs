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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFindings Request Marshaller
    /// </summary>       
    public class UpdateFindingsRequestMarshaller : IMarshaller<IRequest, UpdateFindingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFindingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFindingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-26";            
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/findings";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("Filters");
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsSecurityFindingFiltersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Filters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNote())
                {
                    context.Writer.WritePropertyName("Note");
                    context.Writer.WriteObjectStart();

                    var marshaller = NoteUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Note, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRecordState())
                {
                    context.Writer.WritePropertyName("RecordState");
                    context.Writer.Write(publicRequest.RecordState);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFindingsRequestMarshaller _instance = new UpdateFindingsRequestMarshaller();        

        internal static UpdateFindingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFindingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}