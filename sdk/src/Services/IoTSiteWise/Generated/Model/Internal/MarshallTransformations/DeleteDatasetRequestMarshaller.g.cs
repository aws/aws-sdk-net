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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.IoTSiteWise.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteDataset Request Marshaller
    /// </summary>
    public partial class DeleteDatasetRequestMarshaller : IMarshaller<IRequest, DeleteDatasetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteDatasetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteDatasetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("clientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("clientToken", Guid.NewGuid().ToString());
            }

            if (publicRequest.IsSetWorkspaceName())
            {
                request.Parameters.Add("workspaceName", StringUtils.FromString(publicRequest.WorkspaceName));
            }

            if (!publicRequest.IsSetDatasetId())
            {
                throw new AmazonIoTSiteWiseException("Request object does not have required field DatasetId set");
            }
            request.AddPathResource("{datasetId}", StringUtils.FromString(publicRequest.DatasetId));

            request.ResourcePath = "/datasets/{datasetId}";

            request.UseQueryString = true;

            request.HostPrefix = $"api.";

            return request;
        }

        private static readonly DeleteDatasetRequestMarshaller _instance = new();

        internal static DeleteDatasetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteDatasetRequestMarshaller Instance => _instance;
    }
}
