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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeTapeArchives Request Marshaller
    /// </summary>       
    public class DescribeTapeArchivesRequestMarshaller : IMarshaller<IRequest, DescribeTapeArchivesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeTapeArchivesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeTapeArchivesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.DescribeTapeArchives";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-06-30";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLimit())
                {
                    context.Writer.WritePropertyName("Limit");
                    context.Writer.Write(publicRequest.Limit);
                }

                if(publicRequest.IsSetMarker())
                {
                    context.Writer.WritePropertyName("Marker");
                    context.Writer.Write(publicRequest.Marker);
                }

                if(publicRequest.IsSetTapeARNs())
                {
                    context.Writer.WritePropertyName("TapeARNs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTapeARNsListValue in publicRequest.TapeARNs)
                    {
                            context.Writer.Write(publicRequestTapeARNsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeTapeArchivesRequestMarshaller _instance = new DescribeTapeArchivesRequestMarshaller();        

        internal static DescribeTapeArchivesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTapeArchivesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}