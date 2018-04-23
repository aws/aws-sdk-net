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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CancelPipelineReprocessing Request Marshaller
    /// </summary>       
    public class CancelPipelineReprocessingRequestMarshaller : IMarshaller<IRequest, CancelPipelineReprocessingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CancelPipelineReprocessingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CancelPipelineReprocessingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTAnalytics");
            request.HttpMethod = "DELETE";

            string uriResourcePath = "/pipelines/{pipelineName}/reprocessing/{reprocessingId}";
            if (!publicRequest.IsSetPipelineName())
                throw new AmazonIoTAnalyticsException("Request object does not have required field PipelineName set");
            uriResourcePath = uriResourcePath.Replace("{pipelineName}", StringUtils.FromString(publicRequest.PipelineName));
            if (!publicRequest.IsSetReprocessingId())
                throw new AmazonIoTAnalyticsException("Request object does not have required field ReprocessingId set");
            uriResourcePath = uriResourcePath.Replace("{reprocessingId}", StringUtils.FromString(publicRequest.ReprocessingId));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static CancelPipelineReprocessingRequestMarshaller _instance = new CancelPipelineReprocessingRequestMarshaller();        

        internal static CancelPipelineReprocessingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CancelPipelineReprocessingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}