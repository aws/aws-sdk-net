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
    /// SendApiAsset Request Marshaller
    /// </summary>       
    public class SendApiAssetRequestMarshaller : IMarshaller<IRequest, SendApiAssetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendApiAssetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendApiAssetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataExchange");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetQueryStringParameters())
            {
                foreach(var kvp in publicRequest.QueryStringParameters)
                {
                    request.Parameters.Add(kvp.Key, kvp.Value);
                }
            }
            request.ResourcePath = "/v1";
            request.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.Body);
        
            if (publicRequest.IsSetAssetId()) 
            {
                request.Headers["x-amzn-dataexchange-asset-id"] = publicRequest.AssetId;
            }
        
            if (publicRequest.IsSetDataSetId()) 
            {
                request.Headers["x-amzn-dataexchange-data-set-id"] = publicRequest.DataSetId;
            }
        
            if (publicRequest.IsSetMethod()) 
            {
                request.Headers["x-amzn-dataexchange-http-method"] = publicRequest.Method;
            }
        
            if (publicRequest.IsSetPath()) 
            {
                request.Headers["x-amzn-dataexchange-path"] = publicRequest.Path;
            }
        
            if (publicRequest.IsSetRequestHeaders()) 
            {
                //Map of headers with prefix "x-amzn-dataexchange-header-".
                foreach (var kvpRequestHeaders in publicRequest.RequestHeaders)
                {
                     request.Headers[$"x-amzn-dataexchange-header-{kvpRequestHeaders.Key}"] = kvpRequestHeaders.Value;
                }
            }
        
            if (publicRequest.IsSetRevisionId()) 
            {
                request.Headers["x-amzn-dataexchange-revision-id"] = publicRequest.RevisionId;
            }
            request.UseQueryString = true;
            
            request.HostPrefix = $"api-fulfill.";

            return request;
        }
        private static SendApiAssetRequestMarshaller _instance = new SendApiAssetRequestMarshaller();        

        internal static SendApiAssetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendApiAssetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}