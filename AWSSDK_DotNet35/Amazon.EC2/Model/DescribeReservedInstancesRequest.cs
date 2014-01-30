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
    /// Container for the parameters to the DescribeReservedInstances operation.
    /// <para>Describes one or more of the Reserved Instances that you purchased.</para> <para>For more information about Reserved Instances, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html" >Reserved Instances</a> in the
    /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeReservedInstancesRequest : AmazonEC2Request
    {
        private List<string> reservedInstancesIds = new List<string>();
        private List<Filter> filters = new List<Filter>();
        private OfferingTypeValues offeringType;


        /// <summary>
        /// One or more Reserved Instance IDs. Default: Describes all your Reserved Instances, or only those otherwise specified.
        ///  
        /// </summary>
        public List<string> ReservedInstancesIds
        {
            get { return this.reservedInstancesIds; }
            set { this.reservedInstancesIds = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this.reservedInstancesIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>availability-zone</c> - The Availability Zone where the Reserved Instance can be used. </li> <li>
        /// <c>duration</c> - The duration of the Reserved Instance (one year or three years), in seconds (<c>31536000</c> | <c>94608000</c>). </li>
        /// <li> <c>end</c> - The time when the Reserved Instance expires. </li> <li> <c>fixed-price</c> - The purchase price of the Reserved Instance
        /// (for example, 9800.0). </li> <li> <c>instance-type</c> - The instance type on which the Reserved Instance can be used. </li> <li>
        /// <c>product-description</c> - The product description of the Reserved Instance (<c>Linux/UNIX</c> | <c>Linux/UNIX (Amazon VPC)</c> |
        /// <c>Windows</c> | <c>Windows (Amazon VPC)</c>). </li> <li> <c>reserved-instances-id</c> - The ID of the Reserved Instance. </li> <li>
        /// <c>start</c> - The time at which the Reserved Instance purchase request was placed. </li> <li> <c>state</c> - The state of the Reserved
        /// Instance (<c>pending-payment</c> | <c>active</c> | <c>payment-failed</c> | <c>retired</c>). </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> -
        /// The key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a tag assigned to the resource. This
        /// filter is independent of the <c>tag-value</c> filter. For example, if you use both the filter "tag-key=Purpose" and the filter
        /// "tag-value=X", you get any resources assigned both the tag key Purpose (regardless of what the tag's value is), and the tag value X
        /// (regardless of what the tag's key is). If you want to list only resources where Purpose is X, see the <c>tag</c>:<i>key</i>=<i>value</i>
        /// filter. </li> <li> <c>tag-value</c> - The value of a tag assigned to the resource. This filter is independent of the <c>tag-key</c> filter.
        /// </li> <li> <c>usage-price</c> - The usage price of the Reserved Instance, per hour (for example, 0.84). </li> </ul>
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
        /// The Reserved Instance offering type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Heavy Utilization, Medium Utilization, Light Utilization</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public OfferingTypeValues OfferingType
        {
            get { return this.offeringType; }
            set { this.offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this.offeringType != null;
        }

    }
}
    
