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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedInstances operation.
    /// Describes one or more of the Reserved Instances that you purchased.
    /// 
    ///  
    /// <para>
    /// For more information about Reserved Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
    /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeReservedInstancesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private OfferingClassType _offeringClass;
        private OfferingTypeValues _offeringType;
        private List<string> _reservedInstancesIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone where the Reserved Instance
        /// can be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>duration</code> - The duration of the Reserved Instance (one year or three
        /// years), in seconds (<code>31536000</code> | <code>94608000</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>end</code> - The time when the Reserved Instance expires (for example, 2015-08-07T11:54:42.000Z).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fixed-price</code> - The purchase price of the Reserved Instance (for example,
        /// 9800.0).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-type</code> - The instance type that is covered by the reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>scope</code> - The scope of the Reserved Instance (<code>Region</code> or <code>Availability
        /// Zone</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>product-description</code> - The Reserved Instance product platform description.
        /// Instances that include <code>(Amazon VPC)</code> in the product platform description
        /// will only be displayed to EC2-Classic account holders and are for use with Amazon
        /// VPC (<code>Linux/UNIX</code> | <code>Linux/UNIX (Amazon VPC)</code> | <code>SUSE Linux</code>
        /// | <code>SUSE Linux (Amazon VPC)</code> | <code>Red Hat Enterprise Linux</code> | <code>Red
        /// Hat Enterprise Linux (Amazon VPC)</code> | <code>Windows</code> | <code>Windows (Amazon
        /// VPC)</code> | <code>Windows with SQL Server Standard</code> | <code>Windows with SQL
        /// Server Standard (Amazon VPC)</code> | <code>Windows with SQL Server Web</code> | <code>Windows
        /// with SQL Server Web (Amazon VPC)</code> | <code>Windows with SQL Server Enterprise</code>
        /// | <code>Windows with SQL Server Enterprise (Amazon VPC)</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>reserved-instances-id</code> - The ID of the Reserved Instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>start</code> - The time at which the Reserved Instance purchase request was
        /// placed (for example, 2014-08-07T11:54:42.000Z).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the Reserved Instance (<code>payment-pending</code>
        /// | <code>active</code> | <code>payment-failed</code> | <code>retired</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>usage-price</code> - The usage price of the Reserved Instance, per hour (for
        /// example, 0.84).
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
        /// Gets and sets the property OfferingClass. 
        /// <para>
        /// Describes whether the Reserved Instance is Standard or Convertible.
        /// </para>
        /// </summary>
        public OfferingClassType OfferingClass
        {
            get { return this._offeringClass; }
            set { this._offeringClass = value; }
        }

        // Check to see if OfferingClass property is set
        internal bool IsSetOfferingClass()
        {
            return this._offeringClass != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The Reserved Instance offering type. If you are using tools that predate the 2011-11-01
        /// API version, you only have access to the <code>Medium Utilization</code> Reserved
        /// Instance offering type.
        /// </para>
        /// </summary>
        public OfferingTypeValues OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this._offeringType != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesIds. 
        /// <para>
        /// One or more Reserved Instance IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your Reserved Instances, or only those otherwise specified.
        /// </para>
        /// </summary>
        public List<string> ReservedInstancesIds
        {
            get { return this._reservedInstancesIds; }
            set { this._reservedInstancesIds = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this._reservedInstancesIds != null && this._reservedInstancesIds.Count > 0; 
        }

    }
}