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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetKxChangeset Request Marshaller
    /// </summary>       
    public class GetKxChangesetRequestMarshaller : IMarshaller<IRequest, GetKxChangesetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetKxChangesetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetKxChangesetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Finspace");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-03-12";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetChangesetId())
                throw new AmazonFinspaceException("Request object does not have required field ChangesetId set");
            request.AddPathResource("{changesetId}", StringUtils.FromString(publicRequest.ChangesetId));
            if (!publicRequest.IsSetDatabaseName())
                throw new AmazonFinspaceException("Request object does not have required field DatabaseName set");
            request.AddPathResource("{databaseName}", StringUtils.FromString(publicRequest.DatabaseName));
            if (!publicRequest.IsSetEnvironmentId())
                throw new AmazonFinspaceException("Request object does not have required field EnvironmentId set");
            request.AddPathResource("{environmentId}", StringUtils.FromString(publicRequest.EnvironmentId));
            request.ResourcePath = "/kx/environments/{environmentId}/databases/{databaseName}/changesets/{changesetId}";

            return request;
        }
        private static GetKxChangesetRequestMarshaller _instance = new GetKxChangesetRequestMarshaller();        

        internal static GetKxChangesetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetKxChangesetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}