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
 * Do not modify this file. This file is generated from the cloudfront-keyvaluestore-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFrontKeyValueStore.Model;
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
namespace Amazon.CloudFrontKeyValueStore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeKeyValueStore Request Marshaller
    /// </summary>       
    public class DescribeKeyValueStoreRequestMarshaller : IMarshaller<IRequest, DescribeKeyValueStoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeKeyValueStoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeKeyValueStoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFrontKeyValueStore");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetKvsARN())
                throw new AmazonCloudFrontKeyValueStoreException("Request object does not have required field KvsARN set");
            request.AddPathResource("{KvsARN}", StringUtils.FromString(publicRequest.KvsARN));
            request.ResourcePath = "/key-value-stores/{KvsARN}";

            return request;
        }
        private static DescribeKeyValueStoreRequestMarshaller _instance = new DescribeKeyValueStoreRequestMarshaller();        

        internal static DescribeKeyValueStoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeKeyValueStoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}