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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppConfig.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteEnvironment Request Marshaller
    /// </summary>       
    public class DeleteEnvironmentRequestMarshaller : IMarshaller<IRequest, DeleteEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfig");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-09";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonAppConfigException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{ApplicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            if (!publicRequest.IsSetEnvironmentId())
                throw new AmazonAppConfigException("Request object does not have required field EnvironmentId set");
            request.AddPathResource("{EnvironmentId}", StringUtils.FromString(publicRequest.EnvironmentId));
            request.ResourcePath = "/applications/{ApplicationId}/environments/{EnvironmentId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DeleteEnvironmentRequestMarshaller _instance = new DeleteEnvironmentRequestMarshaller();        

        internal static DeleteEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}