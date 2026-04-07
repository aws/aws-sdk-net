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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Files.Model;
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
namespace Amazon.S3Files.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteMountTarget Request Marshaller
    /// </summary>       
    public class DeleteMountTargetRequestMarshaller : IMarshaller<IRequest, DeleteMountTargetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteMountTargetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteMountTargetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Files");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-05-05";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetMountTargetId())
                throw new AmazonS3FilesException("Request object does not have required field MountTargetId set");
            request.AddPathResource("{mountTargetId}", StringUtils.FromString(publicRequest.MountTargetId));
            request.ResourcePath = "/mount-targets/{mountTargetId}";

            return request;
        }
        private static DeleteMountTargetRequestMarshaller _instance = new DeleteMountTargetRequestMarshaller();        

        internal static DeleteMountTargetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteMountTargetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}