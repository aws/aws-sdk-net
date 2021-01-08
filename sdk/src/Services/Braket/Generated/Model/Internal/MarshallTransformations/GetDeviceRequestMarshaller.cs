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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Braket.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Braket.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDevice Request Marshaller
    /// </summary>       
    public class GetDeviceRequestMarshaller : IMarshaller<IRequest, GetDeviceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDeviceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDeviceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Braket");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-01";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDeviceArn())
                throw new AmazonBraketException("Request object does not have required field DeviceArn set");
            request.AddPathResource("{deviceArn}", StringUtils.FromString(publicRequest.DeviceArn));
            request.ResourcePath = "/device/{deviceArn}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetDeviceRequestMarshaller _instance = new GetDeviceRequestMarshaller();        

        internal static GetDeviceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDeviceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}