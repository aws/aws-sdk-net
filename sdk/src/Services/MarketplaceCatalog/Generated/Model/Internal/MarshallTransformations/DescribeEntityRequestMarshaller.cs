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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeEntity Request Marshaller
    /// </summary>       
    public class DescribeEntityRequestMarshaller : IMarshaller<IRequest, DescribeEntityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeEntityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeEntityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceCatalog");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-17";            
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetCatalog())
                request.Parameters.Add("catalog", StringUtils.FromString(publicRequest.Catalog));
            
            if (publicRequest.IsSetEntityId())
                request.Parameters.Add("entityId", StringUtils.FromString(publicRequest.EntityId));
            request.ResourcePath = "/DescribeEntity";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static DescribeEntityRequestMarshaller _instance = new DescribeEntityRequestMarshaller();        

        internal static DescribeEntityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeEntityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}