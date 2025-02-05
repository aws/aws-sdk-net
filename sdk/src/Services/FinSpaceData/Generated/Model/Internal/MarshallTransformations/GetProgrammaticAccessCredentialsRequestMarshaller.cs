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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FinSpaceData.Model;
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
namespace Amazon.FinSpaceData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetProgrammaticAccessCredentials Request Marshaller
    /// </summary>       
    public class GetProgrammaticAccessCredentialsRequestMarshaller : IMarshaller<IRequest, GetProgrammaticAccessCredentialsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetProgrammaticAccessCredentialsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetProgrammaticAccessCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FinSpaceData");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-13";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetDurationInMinutes())
                request.Parameters.Add("durationInMinutes", StringUtils.FromLong(publicRequest.DurationInMinutes));
            
            if (publicRequest.IsSetEnvironmentId())
                request.Parameters.Add("environmentId", StringUtils.FromString(publicRequest.EnvironmentId));
            request.ResourcePath = "/credentials/programmatic";
            request.UseQueryString = true;

            return request;
        }
        private static GetProgrammaticAccessCredentialsRequestMarshaller _instance = new GetProgrammaticAccessCredentialsRequestMarshaller();        

        internal static GetProgrammaticAccessCredentialsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetProgrammaticAccessCredentialsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}