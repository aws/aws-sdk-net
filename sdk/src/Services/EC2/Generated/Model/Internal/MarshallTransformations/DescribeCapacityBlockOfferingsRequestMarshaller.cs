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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeCapacityBlockOfferings Request Marshaller
    /// </summary>       
    public class DescribeCapacityBlockOfferingsRequestMarshaller : IMarshaller<IRequest, DescribeCapacityBlockOfferingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeCapacityBlockOfferingsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeCapacityBlockOfferingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "DescribeCapacityBlockOfferings");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCapacityDurationHours())
                {
                    request.Parameters.Add("CapacityDurationHours", StringUtils.FromInt(publicRequest.CapacityDurationHours));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEndDateRange())
                {
                    request.Parameters.Add("EndDateRange", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDateRange));
                }
                if(publicRequest.IsSetInstanceCount())
                {
                    request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount));
                }
                if(publicRequest.IsSetInstanceType())
                {
                    request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
                }
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetStartDateRange())
                {
                    request.Parameters.Add("StartDateRange", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartDateRange));
                }
                if(publicRequest.IsSetUltraserverCount())
                {
                    request.Parameters.Add("UltraserverCount", StringUtils.FromInt(publicRequest.UltraserverCount));
                }
                if(publicRequest.IsSetUltraserverType())
                {
                    request.Parameters.Add("UltraserverType", StringUtils.FromString(publicRequest.UltraserverType));
                }
            }
            return request;
        }
                    private static DescribeCapacityBlockOfferingsRequestMarshaller _instance = new DescribeCapacityBlockOfferingsRequestMarshaller();        

        internal static DescribeCapacityBlockOfferingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeCapacityBlockOfferingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}