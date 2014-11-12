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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSpotPriceHistory operation.
    /// Describes the Spot Price history. Spot Instances are instances that Amazon EC2 starts
    /// on your behalf when the maximum price that you specify exceeds the current Spot Price.
    /// Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
    /// and current Spot Instance requests. For more information about Spot Instances, see
    /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
    /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// 
    ///  
    /// <para>
    /// When you specify an Availability Zone, this operation describes the price history
    /// for the specified Availability Zone with the most recent set of prices listed first.
    /// If you don't specify an Availability Zone, you get the prices across all Availability
    /// Zones, starting with the most recent set. However, if you're using an API version
    /// earlier than 2011-05-15, you get the lowest price across the region for the specified
    /// time period. The prices returned are listed in chronological order, from the oldest
    /// to the most recent.
    /// </para>
    ///  
    /// <para>
    /// When you specify the start and end time options, this operation returns two pieces
    /// of data: the prices of the instance types within the time range that you specified
    /// and the time when the price changed. The price is valid within the time period that
    /// you specified; the response merely indicates the last time that the price changed.
    /// </para>
    /// </summary>
    public partial class DescribeSpotPriceHistoryRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private DateTime? _endTime;
        private List<Filter> _filters = new List<Filter>();
        private List<string> _instanceTypes = new List<string>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _productDescriptions = new List<string>();
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone.
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end date and time of the Spot Price history data.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
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
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>availability-zone</code> - The Availability Zone for which prices should be
        /// returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>instance-type</code> - The type of instance (for example, <code>m1.small</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>product-description</code> - The product description for the Spot Price (<code>Linux/UNIX</code>
        /// | <code>SUSE Linux</code> | <code>Windows</code> | <code>Linux/UNIX (Amazon VPC)</code>
        /// | <code>SUSE Linux (Amazon VPC)</code> | <code>Windows (Amazon VPC)</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>spot-price</code> - The Spot Price. The value must match exactly (or use wildcards;
        /// greater than or less than comparison is not supported).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>timestamp</code> - The timestamp of the Spot Price history (for example, 2010-08-16T05:06:11.000Z).
        /// You can use wildcards (* and ?). Greater than or less than comparison is not supported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// One or more instance types.
        /// </para>
        /// </summary>
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && this._instanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of rows to return.
        /// </para>
        /// </summary>
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
        /// The next set of rows to return.
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
        /// One or more basic product descriptions.
        /// </para>
        /// </summary>
        public List<string> ProductDescriptions
        {
            get { return this._productDescriptions; }
            set { this._productDescriptions = value; }
        }

        // Check to see if ProductDescriptions property is set
        internal bool IsSetProductDescriptions()
        {
            return this._productDescriptions != null && this._productDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start date and time of the Spot Price history data.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}