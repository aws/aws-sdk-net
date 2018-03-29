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
    /// DescribeConfigurationRevision Request Marshaller
    /// </summary>       
    public class DescribeConfigurationRevisionRequestMarshaller : IMarshaller<IRequest, DescribeConfigurationRevisionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeConfigurationRevisionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeConfigurationRevisionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MQ");
            request.HttpMethod = "GET";

            string uriResourcePath = "/v1/configurations/{configuration-id}/revisions/{configuration-revision}";
            if (!publicRequest.IsSetConfigurationId())
                throw new AmazonMQException("Request object does not have required field ConfigurationId set");
            uriResourcePath = uriResourcePath.Replace("{configuration-id}", StringUtils.FromString(publicRequest.ConfigurationId));
            if (!publicRequest.IsSetConfigurationRevision())
                throw new AmazonMQException("Request object does not have required field ConfigurationRevision set");
            uriResourcePath = uriResourcePath.Replace("{configuration-revision}", StringUtils.FromString(publicRequest.ConfigurationRevision));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static DescribeConfigurationRevisionRequestMarshaller _instance = new DescribeConfigurationRevisionRequestMarshaller();        

        internal static DescribeConfigurationRevisionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeConfigurationRevisionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}