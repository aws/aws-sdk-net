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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FinSpaceData.Model;
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
namespace Amazon.FinSpaceData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetChangeset Request Marshaller
    /// </summary>       
    public class GetChangesetRequestMarshaller : IMarshaller<IRequest, GetChangesetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetChangesetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetChangesetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FinSpaceData");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-13";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetChangesetId())
                throw new AmazonFinSpaceDataException("Request object does not have required field ChangesetId set");
            request.AddPathResource("{changesetId}", StringUtils.FromString(publicRequest.ChangesetId));
            if (!publicRequest.IsSetDatasetId())
                throw new AmazonFinSpaceDataException("Request object does not have required field DatasetId set");
            request.AddPathResource("{datasetId}", StringUtils.FromString(publicRequest.DatasetId));
            request.ResourcePath = "/datasets/{datasetId}/changesetsv2/{changesetId}";

            return request;
        }
        private static GetChangesetRequestMarshaller _instance = new GetChangesetRequestMarshaller();        

        internal static GetChangesetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetChangesetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}