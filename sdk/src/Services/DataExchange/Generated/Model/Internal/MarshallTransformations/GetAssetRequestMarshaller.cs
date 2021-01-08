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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataExchange.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAsset Request Marshaller
    /// </summary>       
    public class GetAssetRequestMarshaller : IMarshaller<IRequest, GetAssetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAssetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAssetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataExchange");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAssetId())
                throw new AmazonDataExchangeException("Request object does not have required field AssetId set");
            request.AddPathResource("{AssetId}", StringUtils.FromString(publicRequest.AssetId));
            if (!publicRequest.IsSetDataSetId())
                throw new AmazonDataExchangeException("Request object does not have required field DataSetId set");
            request.AddPathResource("{DataSetId}", StringUtils.FromString(publicRequest.DataSetId));
            if (!publicRequest.IsSetRevisionId())
                throw new AmazonDataExchangeException("Request object does not have required field RevisionId set");
            request.AddPathResource("{RevisionId}", StringUtils.FromString(publicRequest.RevisionId));
            request.ResourcePath = "/v1/data-sets/{DataSetId}/revisions/{RevisionId}/assets/{AssetId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetAssetRequestMarshaller _instance = new GetAssetRequestMarshaller();        

        internal static GetAssetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAssetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}