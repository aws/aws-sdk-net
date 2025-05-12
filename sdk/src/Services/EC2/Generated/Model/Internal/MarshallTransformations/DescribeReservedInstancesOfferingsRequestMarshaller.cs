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
    /// DescribeReservedInstancesOfferings Request Marshaller
    /// </summary>       
    public class DescribeReservedInstancesOfferingsRequestMarshaller : IMarshaller<IRequest, DescribeReservedInstancesOfferingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeReservedInstancesOfferingsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeReservedInstancesOfferingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "DescribeReservedInstancesOfferings");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAvailabilityZone())
                {
                    request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
                }
                if(publicRequest.IsSetAvailabilityZoneId())
                {
                    request.Parameters.Add("AvailabilityZoneId", StringUtils.FromString(publicRequest.AvailabilityZoneId));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetFilters())
                {
                    if (publicRequest.Filters.Count == 0)
                        request.Parameters.Add("Filter", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Filters)
                         {
                            if(publicRequestlistValue.IsSetName())
                            {
                                request.Parameters.Add("Filter" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                            }
                            if(publicRequestlistValue.IsSetValues())
                            {
                                if (publicRequestlistValue.Values.Count == 0)
                                    request.Parameters.Add("Filter" + "." + publicRequestlistValueIndex + "." + "Value", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Values)
                                     {
                                         request.Parameters.Add("Filter" + "." + publicRequestlistValueIndex + "." + "Value" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetIncludeMarketplace())
                {
                    request.Parameters.Add("IncludeMarketplace", StringUtils.FromBool(publicRequest.IncludeMarketplace));
                }
                if(publicRequest.IsSetInstanceTenancy())
                {
                    request.Parameters.Add("InstanceTenancy", StringUtils.FromString(publicRequest.InstanceTenancy));
                }
                if(publicRequest.IsSetInstanceType())
                {
                    request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
                }
                if(publicRequest.IsSetMaxDuration())
                {
                    request.Parameters.Add("MaxDuration", StringUtils.FromLong(publicRequest.MaxDuration));
                }
                if(publicRequest.IsSetMaxInstanceCount())
                {
                    request.Parameters.Add("MaxInstanceCount", StringUtils.FromInt(publicRequest.MaxInstanceCount));
                }
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetMinDuration())
                {
                    request.Parameters.Add("MinDuration", StringUtils.FromLong(publicRequest.MinDuration));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetOfferingClass())
                {
                    request.Parameters.Add("OfferingClass", StringUtils.FromString(publicRequest.OfferingClass));
                }
                if(publicRequest.IsSetOfferingType())
                {
                    request.Parameters.Add("OfferingType", StringUtils.FromString(publicRequest.OfferingType));
                }
                if(publicRequest.IsSetProductDescription())
                {
                    request.Parameters.Add("ProductDescription", StringUtils.FromString(publicRequest.ProductDescription));
                }
                if(publicRequest.IsSetReservedInstancesOfferingIds())
                {
                    if (publicRequest.ReservedInstancesOfferingIds.Count == 0)
                        request.Parameters.Add("ReservedInstancesOfferingId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ReservedInstancesOfferingIds)
                         {
                             request.Parameters.Add("ReservedInstancesOfferingId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static DescribeReservedInstancesOfferingsRequestMarshaller _instance = new DescribeReservedInstancesOfferingsRequestMarshaller();        

        internal static DescribeReservedInstancesOfferingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeReservedInstancesOfferingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}