/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.CloudSearchDomain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UploadDocuments Request Marshaller
    /// </summary>       
    public class UploadDocumentsRequestMarshaller : IMarshaller<IRequest, UploadDocumentsRequest> 
    {
        public IRequest Marshall(UploadDocumentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudSearchDomain");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/2013-01-01/documents/batch?format=sdk";
            request.ContentStream =  publicRequest.Documents;
            request.Headers["Content-Type"] = "binary/octet-stream";
        
            if(publicRequest.IsSetContentType())     
                request.Headers["Content-Type"] = publicRequest.ContentType;
            request.ResourcePath = uriResourcePath;

            return request;
        }


    }
}