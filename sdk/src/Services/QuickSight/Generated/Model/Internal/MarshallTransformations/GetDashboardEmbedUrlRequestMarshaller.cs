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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDashboardEmbedUrl Request Marshaller
    /// </summary>       
    public class GetDashboardEmbedUrlRequestMarshaller : IMarshaller<IRequest, GetDashboardEmbedUrlRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDashboardEmbedUrlRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDashboardEmbedUrlRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.HttpMethod = "GET";

            string uriResourcePath = "/accounts/{AwsAccountId}/dashboards/{DashboardId}/embed-url";
            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            uriResourcePath = uriResourcePath.Replace("{AwsAccountId}", StringUtils.FromStringWithSlashEncoding(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetDashboardId())
                throw new AmazonQuickSightException("Request object does not have required field DashboardId set");
            uriResourcePath = uriResourcePath.Replace("{DashboardId}", StringUtils.FromStringWithSlashEncoding(publicRequest.DashboardId));
            
            if (publicRequest.IsSetIdentityType())
                request.Parameters.Add("creds-type", StringUtils.FromString(publicRequest.IdentityType));
            
            if (publicRequest.IsSetResetDisabled())
                request.Parameters.Add("reset-disabled", StringUtils.FromBool(publicRequest.ResetDisabled));
            
            if (publicRequest.IsSetSessionLifetimeInMinutes())
                request.Parameters.Add("session-lifetime", StringUtils.FromLong(publicRequest.SessionLifetimeInMinutes));
            
            if (publicRequest.IsSetUndoRedoDisabled())
                request.Parameters.Add("undo-redo-disabled", StringUtils.FromBool(publicRequest.UndoRedoDisabled));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }
        private static GetDashboardEmbedUrlRequestMarshaller _instance = new GetDashboardEmbedUrlRequestMarshaller();        

        internal static GetDashboardEmbedUrlRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDashboardEmbedUrlRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}