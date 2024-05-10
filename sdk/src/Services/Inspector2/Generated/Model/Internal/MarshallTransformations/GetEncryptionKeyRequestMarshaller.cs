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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEncryptionKey Request Marshaller
    /// </summary>       
    public class GetEncryptionKeyRequestMarshaller : IMarshaller<IRequest, GetEncryptionKeyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEncryptionKeyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetEncryptionKeyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Inspector2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-06-08";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetResourceType())
                request.Parameters.Add("resourceType", StringUtils.FromString(publicRequest.ResourceType));
            
            if (publicRequest.IsSetScanType())
                request.Parameters.Add("scanType", StringUtils.FromString(publicRequest.ScanType));
            request.ResourcePath = "/encryptionkey/get";
            request.UseQueryString = true;

            return request;
        }
        private static GetEncryptionKeyRequestMarshaller _instance = new GetEncryptionKeyRequestMarshaller();        

        internal static GetEncryptionKeyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetEncryptionKeyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}