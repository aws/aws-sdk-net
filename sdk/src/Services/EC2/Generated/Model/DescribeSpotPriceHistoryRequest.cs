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
    /// Container for the parameters to the DescribeSpotPriceHistory operation.
    /// Describes the Spot price history. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
    /// Instance pricing history</a> in the <i>Amazon EC2 User Guide</i>.
    /// 
    ///  
    /// <para>
    /// When you specify a start and end time, the operation returns the prices of the instance
    /// types within that time range. It also returns the last price change before the start
    /// time, which is the effective price as of the start time.
    /// </para>
    /// </summary>
    public partial class DescribeSpotPriceHistoryRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private bool? _dryRun;
        private DateTime? _endTime;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _instanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _productDescriptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// Filters the results by the specified Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> can be specified, but
        /// not both
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// Filters the results by the specified ID of the Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> can be specified, but
        /// not both
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time, up to the current date, from which to stop retrieving the price
        /// history data, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone for which prices should be returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone-id</c> - The ID of the Availability Zone for which prices should
        /// be returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-type</c> - The type of instance (for example, <c>m3.medium</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>product-description</c> - The product description for the Spot price (<c>Linux/UNIX</c>
        /// | <c>Red Hat Enterprise Linux</c> | <c>SUSE Linux</c> | <c>Windows</c> | <c>Linux/UNIX
        /// (Amazon VPC)</c> | <c>Red Hat Enterprise Linux (Amazon VPC)</c> | <c>SUSE Linux (Amazon
        /// VPC)</c> | <c>Windows (Amazon VPC)</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>spot-price</c> - The Spot price. The value must match exactly (or use wildcards;
        /// greater than or less than comparison is not supported).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>timestamp</c> - The time stamp of the Spot price history, in UTC format (for example,
        /// <i>ddd MMM dd HH</i>:<i>mm</i>:<i>ss</i> UTC <i>YYYY</i>). You can use wildcards (<c>*</c>
        /// and <c>?</c>). Greater than or less than comparison is not supported.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// Filters the results by the specified instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && (this._instanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
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
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
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
        /// Gets and sets the property ProductDescriptions. 
        /// <para>
        /// Filters the results by the specified basic product descriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProductDescriptions
        {
            get { return this._productDescriptions; }
            set { this._productDescriptions = value; }
        }

        // Check to see if ProductDescriptions property is set
        internal bool IsSetProductDescriptions()
        {
            return this._productDescriptions != null && (this._productDescriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time, up to the past 90 days, from which to start retrieving the price
        /// history data, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}