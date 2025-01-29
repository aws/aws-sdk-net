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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCalculatedAttributeForProfile Request Marshaller
    /// </summary>       
    public class GetCalculatedAttributeForProfileRequestMarshaller : IMarshaller<IRequest, GetCalculatedAttributeForProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCalculatedAttributeForProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetCalculatedAttributeForProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCalculatedAttributeName())
                throw new AmazonCustomerProfilesException("Request object does not have required field CalculatedAttributeName set");
            request.AddPathResource("{CalculatedAttributeName}", StringUtils.FromString(publicRequest.CalculatedAttributeName));
            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            if (!publicRequest.IsSetProfileId())
                throw new AmazonCustomerProfilesException("Request object does not have required field ProfileId set");
            request.AddPathResource("{ProfileId}", StringUtils.FromString(publicRequest.ProfileId));
            request.ResourcePath = "/domains/{DomainName}/profile/{ProfileId}/calculated-attributes/{CalculatedAttributeName}";

            return request;
        }
        private static GetCalculatedAttributeForProfileRequestMarshaller _instance = new GetCalculatedAttributeForProfileRequestMarshaller();        

        internal static GetCalculatedAttributeForProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCalculatedAttributeForProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}