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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetExport Request Marshaller
    /// </summary>       
    public class GetExportRequestMarshaller : IMarshaller<IRequest, GetExportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetExportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetExportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.HttpMethod = "GET";

            string uriResourcePath = "/restapis/{restapi_id}/stages/{stage_name}/exports/{export_type}";
            if (!publicRequest.IsSetExportType())
                throw new AmazonAPIGatewayException("Request object does not have required field ExportType set");
            uriResourcePath = uriResourcePath.Replace("{export_type}", StringUtils.FromString(publicRequest.ExportType));
            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            uriResourcePath = uriResourcePath.Replace("{restapi_id}", StringUtils.FromString(publicRequest.RestApiId));
            if (!publicRequest.IsSetStageName())
                throw new AmazonAPIGatewayException("Request object does not have required field StageName set");
            uriResourcePath = uriResourcePath.Replace("{stage_name}", StringUtils.FromString(publicRequest.StageName));
            
            if (publicRequest.IsSetParameters())
            {
                foreach(var kvp in publicRequest.Parameters)
                {
                    request.Parameters.Add(kvp.Key, kvp.Value);
                }
            }
            request.ResourcePath = uriResourcePath;
        
            if(publicRequest.IsSetAccepts())
                request.Headers["Accept"] = publicRequest.Accepts;
            request.UseQueryString = true;

            return request;
        }
        private static GetExportRequestMarshaller _instance = new GetExportRequestMarshaller();        

        internal static GetExportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetExportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}