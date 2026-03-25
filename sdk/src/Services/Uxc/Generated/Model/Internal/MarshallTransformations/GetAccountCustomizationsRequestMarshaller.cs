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
 * Do not modify this file. This file is generated from the uxc-2024-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Uxc.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Uxc.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAccountCustomizations Request Marshaller
    /// </summary>       
    public class GetAccountCustomizationsRequestMarshaller : IMarshaller<IRequest, GetAccountCustomizationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAccountCustomizationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAccountCustomizationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Uxc");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-07-01";
            request.HttpMethod = "GET";

            request.ResourcePath = "/v1/account-customizations";

            return request;
        }
        private static GetAccountCustomizationsRequestMarshaller _instance = new GetAccountCustomizationsRequestMarshaller();        

        internal static GetAccountCustomizationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAccountCustomizationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}