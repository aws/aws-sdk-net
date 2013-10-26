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
    /// Container for the parameters to the DescribeSpotInstanceRequests operation.
    /// <para> Describes Spot Instance requests. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
    /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
    /// spot instance requests. For conceptual information about Spot Instances, refer to the <a
    /// href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/DeveloperGuide/" > Amazon Elastic Compute Cloud Developer Guide</a> or <a
    /// href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/UserGuide/" > Amazon Elastic Compute Cloud User Guide</a> .
    /// </para> <para> You can filter the results to return information only about Spot Instance requests that match criteria you specify. For
    /// example, you could get information about requests where the Spot Price you specified is a certain value (you can't use greater than or less
    /// than comparison, but you can use <c>*</c> and <c>?</c> wildcards). You can specify multiple values for a filter. A Spot Instance request
    /// must match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g.,
    /// the Spot Price is equal to a particular value, and the instance type is <c>m1.small</c> ). The result includes information for a particular
    /// request only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty. </para>
    /// <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
    /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
    /// for the literal string <c>*amazon?\</c> .
    /// </para>
    /// </summary>
    public partial class DescribeSpotInstanceRequestsRequest : AmazonEC2Request
    {
        private List<string> spotInstanceRequestIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// The ID of the request.
        ///  
        /// </summary>
        public List<string> SpotInstanceRequestIds
        {
            get { return this.spotInstanceRequestIds; }
            set { this.spotInstanceRequestIds = value; }
        }

        // Check to see if SpotInstanceRequestIds property is set
        internal bool IsSetSpotInstanceRequestIds()
        {
            return this.spotInstanceRequestIds.Count > 0;
        }

        /// <summary>
        /// A list of filters used to match properties for SpotInstances. For a complete reference to the available filter keys for this operation, see
        /// the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
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

    }
}
    
