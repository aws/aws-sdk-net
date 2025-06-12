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
    /// Container for the parameters to the DescribeReservedInstancesListings operation.
    /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
    /// 
    ///  
    /// <para>
    /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
    /// capacity that they no longer need with buyers who want to purchase additional capacity.
    /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
    /// like any other Reserved Instances.
    /// </para>
    ///  
    /// <para>
    /// As a seller, you choose to list some or all of your Reserved Instances, and you specify
    /// the upfront price to receive for them. Your Reserved Instances are then listed in
    /// the Reserved Instance Marketplace and are available for purchase.
    /// </para>
    ///  
    /// <para>
    /// As a buyer, you specify the configuration of the Reserved Instance to purchase, and
    /// the Marketplace matches what you're searching for with what's available. The Marketplace
    /// first sells the lowest priced Reserved Instances to you, and continues to sell available
    /// Reserved Instance listings to you until your demand is met. You are charged based
    /// on the total price of all of the listings that you purchase.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Sell
    /// in the Reserved Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeReservedInstancesListingsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _reservedInstancesId;
        private string _reservedInstancesListingId;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>reserved-instances-id</c> - The ID of the Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reserved-instances-listing-id</c> - The ID of the Reserved Instances listing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> - The status of the Reserved Instance listing (<c>pending</c> | <c>active</c>
        /// | <c>cancelled</c> | <c>closed</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status-message</c> - The reason for the status.
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
        /// Gets and sets the property ReservedInstancesId. 
        /// <para>
        /// One or more Reserved Instance IDs.
        /// </para>
        /// </summary>
        public string ReservedInstancesId
        {
            get { return this._reservedInstancesId; }
            set { this._reservedInstancesId = value; }
        }

        // Check to see if ReservedInstancesId property is set
        internal bool IsSetReservedInstancesId()
        {
            return this._reservedInstancesId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesListingId. 
        /// <para>
        /// One or more Reserved Instance listing IDs.
        /// </para>
        /// </summary>
        public string ReservedInstancesListingId
        {
            get { return this._reservedInstancesListingId; }
            set { this._reservedInstancesListingId = value; }
        }

        // Check to see if ReservedInstancesListingId property is set
        internal bool IsSetReservedInstancesListingId()
        {
            return this._reservedInstancesListingId != null;
        }

    }
}