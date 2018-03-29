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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mobile.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mobile.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeProject Request Marshaller
    /// </summary>       
    public class DescribeProjectRequestMarshaller : IMarshaller<IRequest, DescribeProjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeProjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeProjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Mobile");
            request.HttpMethod = "GET";

            string uriResourcePath = "/project";
            
            if (publicRequest.IsSetProjectId())
                request.Parameters.Add("projectId", StringUtils.FromString(publicRequest.ProjectId));
            
            if (publicRequest.IsSetSyncFromResources())
                request.Parameters.Add("syncFromResources", StringUtils.FromBool(publicRequest.SyncFromResources));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }
        private static DescribeProjectRequestMarshaller _instance = new DescribeProjectRequestMarshaller();        

        internal static DescribeProjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeProjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}