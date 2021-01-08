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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetProfileObjectTypeTemplate Request Marshaller
    /// </summary>       
    public class GetProfileObjectTypeTemplateRequestMarshaller : IMarshaller<IRequest, GetProfileObjectTypeTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetProfileObjectTypeTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetProfileObjectTypeTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetTemplateId())
                throw new AmazonCustomerProfilesException("Request object does not have required field TemplateId set");
            request.AddPathResource("{TemplateId}", StringUtils.FromString(publicRequest.TemplateId));
            request.ResourcePath = "/templates/{TemplateId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetProfileObjectTypeTemplateRequestMarshaller _instance = new GetProfileObjectTypeTemplateRequestMarshaller();        

        internal static GetProfileObjectTypeTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetProfileObjectTypeTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}