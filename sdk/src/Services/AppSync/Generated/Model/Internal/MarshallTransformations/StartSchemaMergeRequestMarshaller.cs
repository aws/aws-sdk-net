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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
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
namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSchemaMerge Request Marshaller
    /// </summary>       
    public class StartSchemaMergeRequestMarshaller : IMarshaller<IRequest, StartSchemaMergeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartSchemaMergeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartSchemaMergeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAssociationId())
                throw new AmazonAppSyncException("Request object does not have required field AssociationId set");
            request.AddPathResource("{associationId}", StringUtils.FromString(publicRequest.AssociationId));
            if (!publicRequest.IsSetMergedApiIdentifier())
                throw new AmazonAppSyncException("Request object does not have required field MergedApiIdentifier set");
            request.AddPathResource("{mergedApiIdentifier}", StringUtils.FromString(publicRequest.MergedApiIdentifier));
            request.ResourcePath = "/v1/mergedApis/{mergedApiIdentifier}/sourceApiAssociations/{associationId}/merge";

            return request;
        }
        private static StartSchemaMergeRequestMarshaller _instance = new StartSchemaMergeRequestMarshaller();        

        internal static StartSchemaMergeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartSchemaMergeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}