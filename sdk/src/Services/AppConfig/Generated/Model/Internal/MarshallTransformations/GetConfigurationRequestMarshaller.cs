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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.AppConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetConfiguration Request Marshaller
    /// </summary>       
    public class GetConfigurationRequestMarshaller : IMarshaller<IRequest, GetConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfig");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-09";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetApplication())
                throw new AmazonAppConfigException("Request object does not have required field Application set");
            request.AddPathResource("{Application}", StringUtils.FromString(publicRequest.Application));
            if (!publicRequest.IsSetConfiguration())
                throw new AmazonAppConfigException("Request object does not have required field Configuration set");
            request.AddPathResource("{Configuration}", StringUtils.FromString(publicRequest.Configuration));
            if (!publicRequest.IsSetEnvironment())
                throw new AmazonAppConfigException("Request object does not have required field Environment set");
            request.AddPathResource("{Environment}", StringUtils.FromString(publicRequest.Environment));
            
            if (publicRequest.IsSetClientConfigurationVersion())
                request.Parameters.Add("client_configuration_version", StringUtils.FromString(publicRequest.ClientConfigurationVersion));
            
            if (publicRequest.IsSetClientId())
                request.Parameters.Add("client_id", StringUtils.FromString(publicRequest.ClientId));
            request.ResourcePath = "/applications/{Application}/environments/{Environment}/configurations/{Configuration}";
            request.UseQueryString = true;

            return request;
        }
        private static GetConfigurationRequestMarshaller _instance = new GetConfigurationRequestMarshaller();        

        internal static GetConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}