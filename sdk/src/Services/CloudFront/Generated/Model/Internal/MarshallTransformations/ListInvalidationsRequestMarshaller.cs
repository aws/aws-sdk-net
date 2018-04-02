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

/*
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListInvalidations Request Marshaller
    /// </summary>       
    public class ListInvalidationsRequestMarshaller : IMarshaller<IRequest, ListInvalidationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListInvalidationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListInvalidationsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "GET";
            string uriResourcePath = "/2017-10-30/distribution/{DistributionId}/invalidation";
            if (!publicRequest.IsSetDistributionId())
                throw new AmazonCloudFrontException("Request object does not have required field DistributionId set");
            uriResourcePath = uriResourcePath.Replace("{DistributionId}", StringUtils.FromString(publicRequest.DistributionId));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("MaxItems", StringUtils.FromString(publicRequest.MaxItems));
            request.ResourcePath = uriResourcePath;


            request.UseQueryString = true;
            return request;
        }
        private static ListInvalidationsRequestMarshaller _instance = new ListInvalidationsRequestMarshaller();        

        internal static ListInvalidationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListInvalidationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}