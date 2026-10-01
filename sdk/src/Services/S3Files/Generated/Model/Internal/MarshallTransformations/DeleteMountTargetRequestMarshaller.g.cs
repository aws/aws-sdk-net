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

using Amazon.S3Files.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Files.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteMountTarget Request Marshaller
    /// </summary>
    public partial class DeleteMountTargetRequestMarshaller : IMarshaller<IRequest, DeleteMountTargetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteMountTargetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteMountTargetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Files");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-05-05";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetMountTargetId())
            {
                throw new AmazonS3FilesException("Request object does not have required field MountTargetId set");
            }
            request.AddPathResource("{mountTargetId}", StringUtils.FromString(publicRequest.MountTargetId));

            request.ResourcePath = "/mount-targets/{mountTargetId}";

            return request;
        }

        private static readonly DeleteMountTargetRequestMarshaller _instance = new();

        internal static DeleteMountTargetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteMountTargetRequestMarshaller Instance => _instance;
    }
}
