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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruProfiler.Model;
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
namespace Amazon.CodeGuruProfiler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemovePermission Request Marshaller
    /// </summary>       
    public class RemovePermissionRequestMarshaller : IMarshaller<IRequest, RemovePermissionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemovePermissionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemovePermissionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruProfiler");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-18";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetActionGroup())
                throw new AmazonCodeGuruProfilerException("Request object does not have required field ActionGroup set");
            request.AddPathResource("{actionGroup}", StringUtils.FromString(publicRequest.ActionGroup));
            if (!publicRequest.IsSetProfilingGroupName())
                throw new AmazonCodeGuruProfilerException("Request object does not have required field ProfilingGroupName set");
            request.AddPathResource("{profilingGroupName}", StringUtils.FromString(publicRequest.ProfilingGroupName));
            
            if (publicRequest.IsSetRevisionId())
                request.Parameters.Add("revisionId", StringUtils.FromString(publicRequest.RevisionId));
            request.ResourcePath = "/profilingGroups/{profilingGroupName}/policy/{actionGroup}";
            request.UseQueryString = true;

            return request;
        }
        private static RemovePermissionRequestMarshaller _instance = new RemovePermissionRequestMarshaller();        

        internal static RemovePermissionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemovePermissionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}