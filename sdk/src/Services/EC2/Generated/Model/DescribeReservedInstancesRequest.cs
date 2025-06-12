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
    /// Container for the parameters to the DescribeReservedInstances operation.
    /// Describes one or more of the Reserved Instances that you purchased.
    /// 
    ///  
    /// <para>
    /// For more information about Reserved Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
    /// Instances</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeReservedInstancesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private OfferingClassType _offeringClass;
        private OfferingTypeValues _offeringType;
        private List<string> _reservedInstancesIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone where the Reserved Instance can
        /// be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone-id</c> - The ID of the Availability Zone where the Reserved
        /// Instance can be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>duration</c> - The duration of the Reserved Instance (one year or three years),
        /// in seconds (<c>31536000</c> | <c>94608000</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>end</c> - The time when the Reserved Instance expires (for example, 2015-08-07T11:54:42.000Z).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fixed-price</c> - The purchase price of the Reserved Instance (for example, 9800.0).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-type</c> - The instance type that is covered by the reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>scope</c> - The scope of the Reserved Instance (<c>Region</c> or <c>Availability
        /// Zone</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>product-description</c> - The Reserved Instance product platform description (<c>Linux/UNIX</c>
        /// | <c>Linux with SQL Server Standard</c> | <c>Linux with SQL Server Web</c> | <c>Linux
        /// with SQL Server Enterprise</c> | <c>SUSE Linux</c> | <c>Red Hat Enterprise Linux</c>
        /// | <c>Red Hat Enterprise Linux with HA</c> | <c>Windows</c> | <c>Windows with SQL Server
        /// Standard</c> | <c>Windows with SQL Server Web</c> | <c>Windows with SQL Server Enterprise</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reserved-instances-id</c> - The ID of the Reserved Instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>start</c> - The time at which the Reserved Instance purchase request was placed
        /// (for example, 2014-08-07T11:54:42.000Z).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the Reserved Instance (<c>payment-pending</c> | <c>active</c>
        /// | <c>payment-failed</c> | <c>retired</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag:&lt;key&gt;</c> - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>usage-price</c> - The usage price of the Reserved Instance, per hour (for example,
        /// 0.84).
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
        /// API version, you only have access to the <c>Medium Utilization</c> Reserved Instance
        /// offering type.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReservedInstancesIds
        {
            get { return this._reservedInstancesIds; }
            set { this._reservedInstancesIds = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this._reservedInstancesIds != null && (this._reservedInstancesIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}