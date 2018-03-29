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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetReusableDelegationSetLimit Request Marshaller
    /// </summary>       
    public class GetReusableDelegationSetLimitRequestMarshaller : IMarshaller<IRequest, GetReusableDelegationSetLimitRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetReusableDelegationSetLimitRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetReusableDelegationSetLimitRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "GET";
            string uriResourcePath = "/2013-04-01/reusabledelegationsetlimit/{Id}/{Type}";
            if (!publicRequest.IsSetType())
                throw new AmazonRoute53Exception("Request object does not have required field Type set");
            uriResourcePath = uriResourcePath.Replace("{Type}", StringUtils.FromString(publicRequest.Type));
            if (!publicRequest.IsSetDelegationSetId())
                throw new AmazonRoute53Exception("Request object does not have required field DelegationSetId set");
            uriResourcePath = uriResourcePath.Replace("{Id}", StringUtils.FromString(publicRequest.DelegationSetId));
            request.ResourcePath = uriResourcePath;


            return request;
        }
        private static GetReusableDelegationSetLimitRequestMarshaller _instance = new GetReusableDelegationSetLimitRequestMarshaller();        

        internal static GetReusableDelegationSetLimitRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetReusableDelegationSetLimitRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}