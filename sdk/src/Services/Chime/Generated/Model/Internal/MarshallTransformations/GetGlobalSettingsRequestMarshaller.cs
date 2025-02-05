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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
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
namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetGlobalSettings Request Marshaller
    /// </summary>       
    public class GetGlobalSettingsRequestMarshaller : IMarshaller<IRequest, GetGlobalSettingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetGlobalSettingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetGlobalSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";
            request.HttpMethod = "GET";

            request.ResourcePath = "/settings";

            return request;
        }
        private static GetGlobalSettingsRequestMarshaller _instance = new GetGlobalSettingsRequestMarshaller();        

        internal static GetGlobalSettingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetGlobalSettingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}