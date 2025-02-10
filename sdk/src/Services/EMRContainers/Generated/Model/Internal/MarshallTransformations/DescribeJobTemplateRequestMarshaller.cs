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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
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
namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeJobTemplate Request Marshaller
    /// </summary>       
    public class DescribeJobTemplateRequestMarshaller : IMarshaller<IRequest, DescribeJobTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeJobTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeJobTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRContainers");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetId())
                throw new AmazonEMRContainersException("Request object does not have required field Id set");
            request.AddPathResource("{templateId}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/jobtemplates/{templateId}";

            return request;
        }
        private static DescribeJobTemplateRequestMarshaller _instance = new DescribeJobTemplateRequestMarshaller();        

        internal static DescribeJobTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeJobTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}