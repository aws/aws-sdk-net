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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppConfigData.Model;
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
namespace Amazon.AppConfigData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetLatestConfiguration Request Marshaller
    /// </summary>       
    public class GetLatestConfigurationRequestMarshaller : IMarshaller<IRequest, GetLatestConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetLatestConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetLatestConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfigData");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-11";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetConfigurationToken())
                request.Parameters.Add("configuration_token", StringUtils.FromString(publicRequest.ConfigurationToken));
            request.ResourcePath = "/configuration";
            request.UseQueryString = true;

            return request;
        }
        private static GetLatestConfigurationRequestMarshaller _instance = new GetLatestConfigurationRequestMarshaller();        

        internal static GetLatestConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetLatestConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}