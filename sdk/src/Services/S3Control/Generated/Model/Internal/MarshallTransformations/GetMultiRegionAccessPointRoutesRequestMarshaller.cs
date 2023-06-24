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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetMultiRegionAccessPointRoutes Request Marshaller
    /// </summary>       
    public class GetMultiRegionAccessPointRoutesRequestMarshaller : IMarshaller<IRequest, GetMultiRegionAccessPointRoutesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMultiRegionAccessPointRoutesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMultiRegionAccessPointRoutesRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "GET";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            if (!publicRequest.IsSetMrap())
                throw new AmazonS3ControlException("Request object does not have required field Mrap set");
            request.AddPathResource("{mrap+}", StringUtils.FromString(publicRequest.Mrap.TrimStart('/')));
            request.ResourcePath = "/v20180820/mrap/instances/{mrap+}/routes";


            return request;
        }
        private static GetMultiRegionAccessPointRoutesRequestMarshaller _instance = new GetMultiRegionAccessPointRoutesRequestMarshaller();        

        internal static GetMultiRegionAccessPointRoutesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMultiRegionAccessPointRoutesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}