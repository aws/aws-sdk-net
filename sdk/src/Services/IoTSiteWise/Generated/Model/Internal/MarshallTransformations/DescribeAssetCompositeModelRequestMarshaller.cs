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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
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
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeAssetCompositeModel Request Marshaller
    /// </summary>       
    public class DescribeAssetCompositeModelRequestMarshaller : IMarshaller<IRequest, DescribeAssetCompositeModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAssetCompositeModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAssetCompositeModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAssetCompositeModelId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field AssetCompositeModelId set");
            request.AddPathResource("{assetCompositeModelId}", StringUtils.FromString(publicRequest.AssetCompositeModelId));
            if (!publicRequest.IsSetAssetId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field AssetId set");
            request.AddPathResource("{assetId}", StringUtils.FromString(publicRequest.AssetId));
            request.ResourcePath = "/assets/{assetId}/composite-models/{assetCompositeModelId}";
            
            request.HostPrefix = $"api.";

            return request;
        }
        private static DescribeAssetCompositeModelRequestMarshaller _instance = new DescribeAssetCompositeModelRequestMarshaller();        

        internal static DescribeAssetCompositeModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAssetCompositeModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}