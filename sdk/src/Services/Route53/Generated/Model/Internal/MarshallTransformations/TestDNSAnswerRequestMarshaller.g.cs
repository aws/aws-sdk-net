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
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.Route53.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestDNSAnswer Request Marshaller
    /// </summary>
    public partial class TestDNSAnswerRequestMarshaller : IMarshaller<IRequest, TestDNSAnswerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestDNSAnswerRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(TestDNSAnswerRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";

            request.ResourcePath = "/2013-04-01/testdnsanswer";

            if (string.IsNullOrEmpty(publicRequest.HostedZoneId))
            {
                throw new AmazonRoute53Exception("Request object does not have required field HostedZoneId set");
            }

            if (publicRequest.IsSetHostedZoneId())
            {
                request.Parameters.Add("hostedzoneid", StringUtils.FromString(publicRequest.HostedZoneId));
            }

            if (string.IsNullOrEmpty(publicRequest.RecordName))
            {
                throw new AmazonRoute53Exception("Request object does not have required field RecordName set");
            }

            if (publicRequest.IsSetRecordName())
            {
                request.Parameters.Add("recordname", StringUtils.FromString(publicRequest.RecordName));
            }

            if (string.IsNullOrEmpty(publicRequest.RecordType))
            {
                throw new AmazonRoute53Exception("Request object does not have required field RecordType set");
            }

            if (publicRequest.IsSetRecordType())
            {
                request.Parameters.Add("recordtype", StringUtils.FromString(publicRequest.RecordType));
            }

            if (publicRequest.IsSetResolverIP())
            {
                request.Parameters.Add("resolverip", StringUtils.FromString(publicRequest.ResolverIP));
            }

            if (publicRequest.IsSetEDNS0ClientSubnetIP())
            {
                request.Parameters.Add("edns0clientsubnetip", StringUtils.FromString(publicRequest.EDNS0ClientSubnetIP));
            }

            if (publicRequest.IsSetEDNS0ClientSubnetMask())
            {
                request.Parameters.Add("edns0clientsubnetmask", StringUtils.FromString(publicRequest.EDNS0ClientSubnetMask));
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly TestDNSAnswerRequestMarshaller _instance = new();

        internal static TestDNSAnswerRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TestDNSAnswerRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, TestDNSAnswerRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, TestDNSAnswerRequest publicRequest);
    }
}
