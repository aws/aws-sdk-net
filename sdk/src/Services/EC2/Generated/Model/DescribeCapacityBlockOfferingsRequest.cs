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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCapacityBlockOfferings operation.
    /// Describes Capacity Block offerings available for purchase in the Amazon Web Services
    /// Region that you're currently using. With Capacity Blocks, you purchase a specific
    /// instance type for a period of time.
    /// </summary>
    public partial class DescribeCapacityBlockOfferingsRequest : AmazonEC2Request
    {
        private int? _capacityDurationHours;
        private DateTime? _endDateRange;
        private int? _instanceCount;
        private string _instanceType;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startDateRange;

        /// <summary>
        /// Gets and sets the property CapacityDurationHours. 
        /// <para>
        /// The number of hours for which to reserve Capacity Block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int CapacityDurationHours
        {
            get { return this._capacityDurationHours.GetValueOrDefault(); }
            set { this._capacityDurationHours = value; }
        }

        // Check to see if CapacityDurationHours property is set
        internal bool IsSetCapacityDurationHours()
        {
            return this._capacityDurationHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDateRange. 
        /// <para>
        /// The latest end date for the Capacity Block offering.
        /// </para>
        /// </summary>
        public DateTime EndDateRange
        {
            get { return this._endDateRange.GetValueOrDefault(); }
            set { this._endDateRange = value; }
        }

        // Check to see if EndDateRange property is set
        internal bool IsSetEndDateRange()
        {
            return this._endDateRange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances for which to reserve capacity.
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance for which the Capacity Block offering reserves capacity.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StartDateRange. 
        /// <para>
        /// The earliest start date for the Capacity Block offering.
        /// </para>
        /// </summary>
        public DateTime StartDateRange
        {
            get { return this._startDateRange.GetValueOrDefault(); }
            set { this._startDateRange = value; }
        }

        // Check to see if StartDateRange property is set
        internal bool IsSetStartDateRange()
        {
            return this._startDateRange.HasValue; 
        }

    }
}