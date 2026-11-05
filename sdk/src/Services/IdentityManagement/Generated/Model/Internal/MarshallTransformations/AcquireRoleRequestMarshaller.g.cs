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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.IdentityManagement.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AcquireRole Request Marshaller
    /// </summary>
    public partial class AcquireRoleRequestMarshaller : IMarshaller<IRequest, AcquireRoleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AcquireRoleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AcquireRoleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "AcquireRole");
            request.Parameters.Add("Version", "2010-05-08");

            if (publicRequest.IsSetReplacementValues())
            {
                int index0 = 1;
                foreach (var kvp0 in publicRequest.ReplacementValues)
                {
                    request.Parameters.Add("ReplacementValues" + ".entry" + "." + index0 + ".key", StringUtils.FromString(kvp0.Key));
                    if (kvp0.Value.IsSetValues())
                    {
                        if (kvp0.Value.Values.Count == 0)
                        {
                            request.Parameters.Add("ReplacementValues" + ".entry" + "." + index0 + ".value" + ".Values", "");
                        }
                        else
                        {
                            int index1 = 1;
                            foreach (var item1 in kvp0.Value.Values)
                            {
                                request.Parameters.Add("ReplacementValues" + ".entry" + "." + index0 + ".value" + ".Values" + ".member" + "." + index1, StringUtils.FromString(item1));
                                index1++;
                            }
                        }
                    }
                    index0++;
                }
            }
            if (publicRequest.IsSetTemplateArn())
            {
                request.Parameters.Add("TemplateArn", StringUtils.FromString(publicRequest.TemplateArn));
            }
            if (publicRequest.IsSetTemplateMinorVersion())
            {
                request.Parameters.Add("TemplateMinorVersion", StringUtils.FromInt(publicRequest.TemplateMinorVersion.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly AcquireRoleRequestMarshaller _instance = new();

        internal static AcquireRoleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AcquireRoleRequestMarshaller Instance => _instance;
    }
}
