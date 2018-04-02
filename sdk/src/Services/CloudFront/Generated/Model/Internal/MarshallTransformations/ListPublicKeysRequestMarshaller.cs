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
    /// ListPublicKeys Request Marshaller
    /// </summary>       
    public class ListPublicKeysRequestMarshaller : IMarshaller<IRequest, ListPublicKeysRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPublicKeysRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListPublicKeysRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "GET";
            string uriResourcePath = "/2017-10-30/public-key";
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("MaxItems", StringUtils.FromString(publicRequest.MaxItems));
            request.ResourcePath = uriResourcePath;


            request.UseQueryString = true;
            return request;
        }
        private static ListPublicKeysRequestMarshaller _instance = new ListPublicKeysRequestMarshaller();        

        internal static ListPublicKeysRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListPublicKeysRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}