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

using Amazon.Omics.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CancelAnnotationImportJob Request Marshaller
    /// </summary>
    public partial class CancelAnnotationImportJobRequestMarshaller : IMarshaller<IRequest, CancelAnnotationImportJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CancelAnnotationImportJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CancelAnnotationImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetJobId())
            {
                throw new AmazonOmicsException("Request object does not have required field JobId set");
            }
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));

            request.ResourcePath = "/import/annotation/{jobId}";

            request.HostPrefix = $"analytics-";

            return request;
        }

        private static readonly CancelAnnotationImportJobRequestMarshaller _instance = new();

        internal static CancelAnnotationImportJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CancelAnnotationImportJobRequestMarshaller Instance => _instance;
    }
}
