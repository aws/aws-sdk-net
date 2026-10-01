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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EndUserMessaging.Model;
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
namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteBrandProfileAttribute Request Marshaller
    /// </summary>       
    public class DeleteBrandProfileAttributeRequestMarshaller : IMarshaller<IRequest, DeleteBrandProfileAttributeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBrandProfileAttributeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteBrandProfileAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EndUserMessaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-09-21";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAttributeName())
                throw new AmazonEndUserMessagingException("Request object does not have required field AttributeName set");
            request.AddPathResource("{attributeName}", StringUtils.FromString(publicRequest.AttributeName));
            if (!publicRequest.IsSetBrandProfileId())
                throw new AmazonEndUserMessagingException("Request object does not have required field BrandProfileId set");
            request.AddPathResource("{brandProfileId}", StringUtils.FromString(publicRequest.BrandProfileId));
            request.ResourcePath = "/v1/brand-profiles/{brandProfileId}/attributes/{attributeName}";

            return request;
        }
        private static DeleteBrandProfileAttributeRequestMarshaller _instance = new DeleteBrandProfileAttributeRequestMarshaller();        

        internal static DeleteBrandProfileAttributeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteBrandProfileAttributeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}