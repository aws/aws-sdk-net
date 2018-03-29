/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestDNSAnswer Request Marshaller
    /// </summary>       
    public class TestDNSAnswerRequestMarshaller : IMarshaller<IRequest, TestDNSAnswerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestDNSAnswerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TestDNSAnswerRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "GET";
            string uriResourcePath = "/2013-04-01/testdnsanswer";
            
            if (publicRequest.IsSetHostedZoneId())
                request.Parameters.Add("hostedzoneid", StringUtils.FromString(publicRequest.HostedZoneId));
            
            if (publicRequest.IsSetRecordName())
                request.Parameters.Add("recordname", StringUtils.FromString(publicRequest.RecordName));
            
            if (publicRequest.IsSetRecordType())
                request.Parameters.Add("recordtype", StringUtils.FromString(publicRequest.RecordType));
            
            if (publicRequest.IsSetResolverIP())
                request.Parameters.Add("resolverip", StringUtils.FromString(publicRequest.ResolverIP));
            
            if (publicRequest.IsSetEDNS0ClientSubnetIP())
                request.Parameters.Add("edns0clientsubnetip", StringUtils.FromString(publicRequest.EDNS0ClientSubnetIP));
            
            if (publicRequest.IsSetEDNS0ClientSubnetMask())
                request.Parameters.Add("edns0clientsubnetmask", StringUtils.FromString(publicRequest.EDNS0ClientSubnetMask));
            request.ResourcePath = uriResourcePath;


            request.UseQueryString = true;
            return request;
        }
        private static TestDNSAnswerRequestMarshaller _instance = new TestDNSAnswerRequestMarshaller();        

        internal static TestDNSAnswerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestDNSAnswerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}