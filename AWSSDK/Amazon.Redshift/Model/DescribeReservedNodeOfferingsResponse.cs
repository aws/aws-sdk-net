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

using System;
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns information about the DescribeReservedNodeOfferingsResult response and response metadata.
    /// </summary>
    public class DescribeReservedNodeOfferingsResponse : AmazonWebServiceResponse
    {
        private DescribeReservedNodeOfferingsResult _describeReservedNodeOfferingsResult;

        /// <summary>
        /// Gets and sets the DescribeReservedNodeOfferingsResult property.
        /// Represents the output of a DescribeReservedNodeOfferings operation.
        /// </summary>
        public DescribeReservedNodeOfferingsResult DescribeReservedNodeOfferingsResult
        {
            get
            {
                if(this._describeReservedNodeOfferingsResult == null)
                {
                    this._describeReservedNodeOfferingsResult = new DescribeReservedNodeOfferingsResult();
                }
                return this._describeReservedNodeOfferingsResult;
            }
            set { this._describeReservedNodeOfferingsResult = value; }
        }
    }
}