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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSpotPriceHistory operation.
    /// <para>Describes the Spot Price history. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
    /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
    /// Spot Instance requests. For more information about Spot Instances, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i> .</para> <para>When you specify an Availability Zone, this operation describes the price history for the specified
    /// Availability Zone with the most recent set of prices listed first. If you don't specify an Availability Zone, you get the prices across all
    /// Availability Zones, starting with the most recent set. However, if you're using an API version earlier than 2011-05-15, you get the lowest
    /// price across the region for the specified time period. The prices returned are listed in chronological order, from the oldest to the most
    /// recent.</para>
    /// </summary>
    public partial class DescribeSpotPriceHistoryRequest : AmazonEC2Request
    {
        private DateTime? startTime;
        private DateTime? endTime;
        private List<string> instanceTypes = new List<string>();
        private List<string> productDescriptions = new List<string>();
        private List<Filter> filters = new List<Filter>();
        private string availabilityZone;
        private int? maxResults;
        private string nextToken;


        /// <summary>
        /// The start date and time of the Spot Price history data.
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;
        }

        /// <summary>
        /// The end date and time of the Spot Price history data.
        ///  
        /// </summary>
        public DateTime EndTime
        {
            get { return this.endTime ?? default(DateTime); }
            set { this.endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this.endTime.HasValue;
        }

        /// <summary>
        /// One or more instance types.
        ///  
        /// </summary>
        public List<string> InstanceTypes
        {
            get { return this.instanceTypes; }
            set { this.instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this.instanceTypes.Count > 0;
        }

        /// <summary>
        /// One or more basic product descriptions.
        ///  
        /// </summary>
        public List<string> ProductDescriptions
        {
            get { return this.productDescriptions; }
            set { this.productDescriptions = value; }
        }

        // Check to see if ProductDescriptions property is set
        internal bool IsSetProductDescriptions()
        {
            return this.productDescriptions.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>availability-zone</c> - The Availability Zone for which prices should be returned. </li> <li>
        /// <c>instance-type</c> - The type of instance (for example, <c>m1.small</c>). </li> <li> <c>product-description</c> - The product description
        /// for the Spot Price (<c>Linux/UNIX</c> | <c>SUSE Linux</c> | <c>Windows</c> | <c>Linux/UNIX (Amazon VPC)</c> | <c>SUSE Linux (Amazon VPC)</c>
        /// | <c>Windows (Amazon VPC)</c>). </li> <li> <c>spot-price</c> - The Spot Price. The value must match exactly (or use wildcards; greater than
        /// or less than comparison is not supported). </li> <li> <c>timestamp</c> - The timestamp of the Spot Price history (for example,
        /// 2010-08-16T05:06:11.000Z). You can use wildcards (* and ?). Greater than or less than comparison is not supported. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

        /// <summary>
        /// The Availability Zone.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The number of rows to return.
        ///  
        /// </summary>
        public int MaxResults
        {
            get { return this.maxResults ?? default(int); }
            set { this.maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this.maxResults.HasValue;
        }

        /// <summary>
        /// The next set of rows to return.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

    }
}
    
