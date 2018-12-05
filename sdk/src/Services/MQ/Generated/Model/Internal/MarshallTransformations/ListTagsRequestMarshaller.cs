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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MQ.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MQ.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTags Request Marshaller
    /// </summary>       
    public class ListTagsRequestMarshaller : IMarshaller<IRequest, ListTagsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTagsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListTagsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MQ");
            request.HttpMethod = "GET";

            string uriResourcePath = "/v1/tags/{resource-arn}";
            if (!publicRequest.IsSetResourceArn())
                throw new AmazonMQException("Request object does not have required field ResourceArn set");
            uriResourcePath = uriResourcePath.Replace("{resource-arn}", StringUtils.FromStringWithSlashEncoding(publicRequest.ResourceArn));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static ListTagsRequestMarshaller _instance = new ListTagsRequestMarshaller();        

        internal static ListTagsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListTagsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}