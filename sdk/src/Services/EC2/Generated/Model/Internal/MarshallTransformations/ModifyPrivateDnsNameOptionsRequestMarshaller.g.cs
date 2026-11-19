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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyPrivateDnsNameOptions Request Marshaller
    /// </summary>
    public partial class ModifyPrivateDnsNameOptionsRequestMarshaller : IMarshaller<IRequest, ModifyPrivateDnsNameOptionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyPrivateDnsNameOptionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyPrivateDnsNameOptionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyPrivateDnsNameOptions");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEnableResourceNameDnsAAAARecord())
            {
                request.Parameters.Add("EnableResourceNameDnsAAAARecord", StringUtils.FromBool(publicRequest.EnableResourceNameDnsAAAARecord.Value));
            }
            if (publicRequest.IsSetEnableResourceNameDnsARecord())
            {
                request.Parameters.Add("EnableResourceNameDnsARecord", StringUtils.FromBool(publicRequest.EnableResourceNameDnsARecord.Value));
            }
            if (publicRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
            }
            if (publicRequest.IsSetPrivateDnsHostnameType())
            {
                request.Parameters.Add("PrivateDnsHostnameType", StringUtils.FromString(publicRequest.PrivateDnsHostnameType));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyPrivateDnsNameOptionsRequestMarshaller _instance = new();

        internal static ModifyPrivateDnsNameOptionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyPrivateDnsNameOptionsRequestMarshaller Instance => _instance;
    }
}
