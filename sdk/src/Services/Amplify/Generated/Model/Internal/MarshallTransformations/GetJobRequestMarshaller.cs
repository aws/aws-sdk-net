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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Amplify.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Amplify.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetJob Request Marshaller
    /// </summary>       
    public class GetJobRequestMarshaller : IMarshaller<IRequest, GetJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Amplify");
            request.HttpMethod = "GET";

            string uriResourcePath = "/apps/{appId}/branches/{branchName}/jobs/{jobId}";
            if (!publicRequest.IsSetAppId())
                throw new AmazonAmplifyException("Request object does not have required field AppId set");
            uriResourcePath = uriResourcePath.Replace("{appId}", StringUtils.FromStringWithSlashEncoding(publicRequest.AppId));
            if (!publicRequest.IsSetBranchName())
                throw new AmazonAmplifyException("Request object does not have required field BranchName set");
            uriResourcePath = uriResourcePath.Replace("{branchName}", StringUtils.FromStringWithSlashEncoding(publicRequest.BranchName));
            if (!publicRequest.IsSetJobId())
                throw new AmazonAmplifyException("Request object does not have required field JobId set");
            uriResourcePath = uriResourcePath.Replace("{jobId}", StringUtils.FromStringWithSlashEncoding(publicRequest.JobId));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static GetJobRequestMarshaller _instance = new GetJobRequestMarshaller();        

        internal static GetJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}