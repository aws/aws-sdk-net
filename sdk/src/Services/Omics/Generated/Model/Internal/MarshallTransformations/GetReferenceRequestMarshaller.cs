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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetReference Request Marshaller
    /// </summary>       
    public class GetReferenceRequestMarshaller : IMarshaller<IRequest, GetReferenceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetReferenceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetReferenceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetId())
                throw new AmazonOmicsException("Request object does not have required field Id set");
            request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));
            if (!publicRequest.IsSetReferenceStoreId())
                throw new AmazonOmicsException("Request object does not have required field ReferenceStoreId set");
            request.AddPathResource("{referenceStoreId}", StringUtils.FromString(publicRequest.ReferenceStoreId));
            
            if (publicRequest.IsSetFile())
                request.Parameters.Add("file", StringUtils.FromString(publicRequest.File));
            
            if (publicRequest.IsSetPartNumber())
                request.Parameters.Add("partNumber", StringUtils.FromInt(publicRequest.PartNumber));
            request.ResourcePath = "/referencestore/{referenceStoreId}/reference/{id}";
        
            if (publicRequest.IsSetRange()) 
            {
                request.Headers["Range"] = publicRequest.Range;
            }
            request.UseQueryString = true;
            
            request.HostPrefix = $"storage-";

            return request;
        }
        private static GetReferenceRequestMarshaller _instance = new GetReferenceRequestMarshaller();        

        internal static GetReferenceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetReferenceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}