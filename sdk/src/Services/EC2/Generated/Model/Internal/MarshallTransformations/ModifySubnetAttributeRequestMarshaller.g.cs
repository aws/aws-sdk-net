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
    /// ModifySubnetAttribute Request Marshaller
    /// </summary>
    public partial class ModifySubnetAttributeRequestMarshaller : IMarshaller<IRequest, ModifySubnetAttributeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifySubnetAttributeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifySubnetAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifySubnetAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAssignIpv6AddressOnCreation())
            {
                request.Parameters.Add("AssignIpv6AddressOnCreation.Value", StringUtils.FromBool(publicRequest.AssignIpv6AddressOnCreation.Value));
            }
            if (publicRequest.IsSetCustomerOwnedIpv4Pool())
            {
                request.Parameters.Add("CustomerOwnedIpv4Pool", StringUtils.FromString(publicRequest.CustomerOwnedIpv4Pool));
            }
            if (publicRequest.IsSetDisableLniAtDeviceIndex())
            {
                request.Parameters.Add("DisableLniAtDeviceIndex.Value", StringUtils.FromBool(publicRequest.DisableLniAtDeviceIndex.Value));
            }
            if (publicRequest.IsSetEnableDns64())
            {
                request.Parameters.Add("EnableDns64.Value", StringUtils.FromBool(publicRequest.EnableDns64.Value));
            }
            if (publicRequest.IsSetEnableLniAtDeviceIndex())
            {
                request.Parameters.Add("EnableLniAtDeviceIndex", StringUtils.FromInt(publicRequest.EnableLniAtDeviceIndex.Value));
            }
            if (publicRequest.IsSetEnableResourceNameDnsAAAARecordOnLaunch())
            {
                request.Parameters.Add("EnableResourceNameDnsAAAARecordOnLaunch.Value", StringUtils.FromBool(publicRequest.EnableResourceNameDnsAAAARecordOnLaunch.Value));
            }
            if (publicRequest.IsSetEnableResourceNameDnsARecordOnLaunch())
            {
                request.Parameters.Add("EnableResourceNameDnsARecordOnLaunch.Value", StringUtils.FromBool(publicRequest.EnableResourceNameDnsARecordOnLaunch.Value));
            }
            if (publicRequest.IsSetMapCustomerOwnedIpOnLaunch())
            {
                request.Parameters.Add("MapCustomerOwnedIpOnLaunch.Value", StringUtils.FromBool(publicRequest.MapCustomerOwnedIpOnLaunch.Value));
            }
            if (publicRequest.IsSetMapPublicIpOnLaunch())
            {
                request.Parameters.Add("MapPublicIpOnLaunch.Value", StringUtils.FromBool(publicRequest.MapPublicIpOnLaunch.Value));
            }
            if (publicRequest.IsSetPrivateDnsHostnameTypeOnLaunch())
            {
                request.Parameters.Add("PrivateDnsHostnameTypeOnLaunch", StringUtils.FromString(publicRequest.PrivateDnsHostnameTypeOnLaunch));
            }
            if (publicRequest.IsSetSubnetId())
            {
                request.Parameters.Add("SubnetId", StringUtils.FromString(publicRequest.SubnetId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifySubnetAttributeRequestMarshaller _instance = new();

        internal static ModifySubnetAttributeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifySubnetAttributeRequestMarshaller Instance => _instance;
    }
}
