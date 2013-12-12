/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Reserved Instances Listing Request Marshaller
    /// </summary>       
    public class CreateReservedInstancesListingRequestMarshaller : IMarshaller<IRequest, CreateReservedInstancesListingRequest>
    {
        public IRequest Marshall(CreateReservedInstancesListingRequest createReservedInstancesListingRequest)
        {
            IRequest request = new DefaultRequest(createReservedInstancesListingRequest, "AmazonEC2");
            request.Parameters.Add("Action", "CreateReservedInstancesListing");
            request.Parameters.Add("Version", "2013-10-15");
            if (createReservedInstancesListingRequest != null && createReservedInstancesListingRequest.IsSetReservedInstancesId())
            {
                request.Parameters.Add("ReservedInstancesId", StringUtils.FromString(createReservedInstancesListingRequest.ReservedInstancesId));
            }
            if (createReservedInstancesListingRequest != null && createReservedInstancesListingRequest.IsSetInstanceCount())
            {
                request.Parameters.Add("InstanceCount", StringUtils.FromInt(createReservedInstancesListingRequest.InstanceCount));
            }

            if (createReservedInstancesListingRequest != null)
            {
                List<PriceScheduleSpecification> priceSchedulesList = createReservedInstancesListingRequest.PriceSchedules;
                int priceSchedulesListIndex = 1;
                foreach (PriceScheduleSpecification priceSchedulesListValue in priceSchedulesList)
                {
                    if (priceSchedulesListValue != null && priceSchedulesListValue.IsSetTerm())
                    {
                        request.Parameters.Add("PriceSchedules." + priceSchedulesListIndex + ".Term", StringUtils.FromLong(priceSchedulesListValue.Term));
                    }
                    if (priceSchedulesListValue != null && priceSchedulesListValue.IsSetPrice())
                    {
                        request.Parameters.Add("PriceSchedules." + priceSchedulesListIndex + ".Price", StringUtils.FromDouble(priceSchedulesListValue.Price));
                    }
                    if (priceSchedulesListValue != null && priceSchedulesListValue.IsSetCurrencyCode())
                    {
                        request.Parameters.Add("PriceSchedules." + priceSchedulesListIndex + ".CurrencyCode", StringUtils.FromString(priceSchedulesListValue.CurrencyCode));
                    }

                    priceSchedulesListIndex++;
                }
            }
            if (createReservedInstancesListingRequest != null && createReservedInstancesListingRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(createReservedInstancesListingRequest.ClientToken));
            }

            return request;
        }
    }
}
