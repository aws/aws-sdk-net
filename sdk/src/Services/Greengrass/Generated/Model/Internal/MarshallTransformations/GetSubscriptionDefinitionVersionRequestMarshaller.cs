/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSubscriptionDefinitionVersion Request Marshaller
    /// </summary>       
    public class GetSubscriptionDefinitionVersionRequestMarshaller : IMarshaller<IRequest, GetSubscriptionDefinitionVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSubscriptionDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSubscriptionDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.HttpMethod = "GET";

            string uriResourcePath = "/greengrass/definition/subscriptions/{SubscriptionDefinitionId}/versions/{SubscriptionDefinitionVersionId}";
            if (!publicRequest.IsSetSubscriptionDefinitionId())
                throw new AmazonGreengrassException("Request object does not have required field SubscriptionDefinitionId set");
            uriResourcePath = uriResourcePath.Replace("{SubscriptionDefinitionId}", StringUtils.FromString(publicRequest.SubscriptionDefinitionId));
            if (!publicRequest.IsSetSubscriptionDefinitionVersionId())
                throw new AmazonGreengrassException("Request object does not have required field SubscriptionDefinitionVersionId set");
            uriResourcePath = uriResourcePath.Replace("{SubscriptionDefinitionVersionId}", StringUtils.FromString(publicRequest.SubscriptionDefinitionVersionId));
            request.ResourcePath = uriResourcePath;

            return request;
        }


    }
}