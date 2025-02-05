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
    /// DeleteAssetModelCompositeModel Request Marshaller
    /// </summary>       
    public class DeleteAssetModelCompositeModelRequestMarshaller : IMarshaller<IRequest, DeleteAssetModelCompositeModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAssetModelCompositeModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteAssetModelCompositeModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAssetModelCompositeModelId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field AssetModelCompositeModelId set");
            request.AddPathResource("{assetModelCompositeModelId}", StringUtils.FromString(publicRequest.AssetModelCompositeModelId));
            if (!publicRequest.IsSetAssetModelId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field AssetModelId set");
            request.AddPathResource("{assetModelId}", StringUtils.FromString(publicRequest.AssetModelId));
            
            if (publicRequest.IsSetClientToken())
                request.Parameters.Add("clientToken", StringUtils.FromString(publicRequest.ClientToken));
            else            
                request.Parameters.Add("clientToken", System.Guid.NewGuid().ToString());
                
            request.ResourcePath = "/asset-models/{assetModelId}/composite-models/{assetModelCompositeModelId}";
        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }
        
            if (publicRequest.IsSetIfNoneMatch()) 
            {
                request.Headers["If-None-Match"] = publicRequest.IfNoneMatch;
            }
        
            if (publicRequest.IsSetMatchForVersionType()) 
            {
                request.Headers["Match-For-Version-Type"] = publicRequest.MatchForVersionType;
            }
            request.UseQueryString = true;
            
            request.HostPrefix = $"api.";

            return request;
        }
        private static DeleteAssetModelCompositeModelRequestMarshaller _instance = new DeleteAssetModelCompositeModelRequestMarshaller();        

        internal static DeleteAssetModelCompositeModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteAssetModelCompositeModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}