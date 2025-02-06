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
    /// ListExtensionAssociations Request Marshaller
    /// </summary>       
    public class ListExtensionAssociationsRequestMarshaller : IMarshaller<IRequest, ListExtensionAssociationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListExtensionAssociationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListExtensionAssociationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfig");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-09";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetExtensionIdentifier())
                request.Parameters.Add("extension_identifier", StringUtils.FromString(publicRequest.ExtensionIdentifier));
            
            if (publicRequest.IsSetExtensionVersionNumber())
                request.Parameters.Add("extension_version_number", StringUtils.FromInt(publicRequest.ExtensionVersionNumber));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max_results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next_token", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetResourceIdentifier())
                request.Parameters.Add("resource_identifier", StringUtils.FromString(publicRequest.ResourceIdentifier));
            request.ResourcePath = "/extensionassociations";
            request.UseQueryString = true;

            return request;
        }
        private static ListExtensionAssociationsRequestMarshaller _instance = new ListExtensionAssociationsRequestMarshaller();        

        internal static ListExtensionAssociationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListExtensionAssociationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}