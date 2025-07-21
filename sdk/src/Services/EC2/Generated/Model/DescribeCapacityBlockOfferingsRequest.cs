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
    /// Region that you're currently using. With Capacity Blocks, you can purchase a specific
    /// GPU instance type or EC2 UltraServer for a period of time.
    /// 
    ///  
    /// <para>
    /// To search for an available Capacity Block offering, you specify a reservation duration
    /// and instance count.
    /// </para>
    /// </summary>
    public partial class DescribeCapacityBlockOfferingsRequest : AmazonEC2Request
    {
        private int? _capacityDurationHours;
        private bool? _dryRun;
        private DateTime? _endDateRange;
        private int? _instanceCount;
        private string _instanceType;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startDateRange;
        private int? _ultraserverCount;
        private string _ultraserverType;

        /// <summary>
        /// Gets and sets the property CapacityDurationHours. 
        /// <para>
        /// The reservation duration for the Capacity Block, in hours. You must specify the duration
        /// in 1-day increments up 14 days, and in 7-day increments up to 182 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? CapacityDurationHours
        {
            get { return this._capacityDurationHours; }
            set { this._capacityDurationHours = value; }
        }

        // Check to see if CapacityDurationHours property is set
        internal bool IsSetCapacityDurationHours()
        {
            return this._capacityDurationHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDateRange. 
        /// <para>
        /// The latest end date for the Capacity Block offering.
        /// </para>
        /// </summary>
        public DateTime? EndDateRange
        {
            get { return this._endDateRange; }
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
        /// The number of instances for which to reserve capacity. Each Capacity Block can have
        /// up to 64 instances, and you can have up to 256 instances across Capacity Blocks.
        /// </para>
        /// </summary>
        public int? InstanceCount
        {
            get { return this._instanceCount; }
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
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        public DateTime? StartDateRange
        {
            get { return this._startDateRange; }
            set { this._startDateRange = value; }
        }

        // Check to see if StartDateRange property is set
        internal bool IsSetStartDateRange()
        {
            return this._startDateRange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UltraserverCount. 
        /// <para>
        /// The number of EC2 UltraServers in the offerings.
        /// </para>
        /// </summary>
        public int? UltraserverCount
        {
            get { return this._ultraserverCount; }
            set { this._ultraserverCount = value; }
        }

        // Check to see if UltraserverCount property is set
        internal bool IsSetUltraserverCount()
        {
            return this._ultraserverCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UltraserverType. 
        /// <para>
        /// The EC2 UltraServer type of the Capacity Block offerings.
        /// </para>
        /// </summary>
        public string UltraserverType
        {
            get { return this._ultraserverType; }
            set { this._ultraserverType = value; }
        }

        // Check to see if UltraserverType property is set
        internal bool IsSetUltraserverType()
        {
            return this._ultraserverType != null;
        }

    }
}