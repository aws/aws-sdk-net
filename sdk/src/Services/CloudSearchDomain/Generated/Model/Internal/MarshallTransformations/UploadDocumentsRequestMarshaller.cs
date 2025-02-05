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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearchDomain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudSearchDomain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UploadDocuments Request Marshaller
    /// </summary>       
    public class UploadDocumentsRequestMarshaller : IMarshaller<IRequest, UploadDocumentsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UploadDocumentsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UploadDocumentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudSearchDomain");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-01-01";
            request.HttpMethod = "POST";

            request.AddSubResource("format", "sdk");
            request.ResourcePath = "/2013-01-01/documents/batch";
            request.ContentStream =  publicRequest.Documents ?? new MemoryStream();
            if(request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }

            return request;
        }
        private static UploadDocumentsRequestMarshaller _instance = new UploadDocumentsRequestMarshaller();        

        internal static UploadDocumentsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UploadDocumentsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}