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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateReservedInstancesListing operation. Creates
    /// a listing for Amazon EC2 Standard Reserved Instances to be sold in the Reserved Instance
    /// Marketplace. You can submit one Standard Reserved Instance listing at a time. To get
    /// a list of your Standard Reserved Instances, you can use the <a>DescribeReservedInstances</a>
    /// operation. <note> <para> Only Standard Reserved Instances can be sold in the Reserved
    /// Instance Marketplace. Convertible Reserved Instances cannot be sold. </para> </note>
    /// <para> The Reserved Instance Marketplace matches sellers who want to resell Standard
    /// Reserved Instance capacity that they no longer need with buyers who want to purchase
    /// additional capacity. Reserved Instances bought and sold through the Reserved Instance
    /// Marketplace work like any other Reserved Instances. </para> <para> To sell your Standard
    /// Reserved Instances, you must first register as a seller in the Reserved Instance Marketplace.
    /// After completing the registration process, you can create a Reserved Instance Marketplace
    /// listing of some or all of your Standard Reserved Instances, and specify the upfront
    /// price to receive for them. Your Standard Reserved Instance listings then become available
    /// for purchase. To view the details of your Standard Reserved Instance listing, you
    /// can use the <a>DescribeReservedInstancesListings</a> operation. </para> <para> For
    /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Sell
    /// in the Reserved Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class CreateReservedInstancesListingRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of your listings.
        /// This helps avoid duplicate listings. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances that are a part of a Reserved Instance account to be listed
        /// in the Reserved Instance Marketplace. This number should be less than or equal to
        /// the instance count associated with the Reserved Instance ID specified in this call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property PriceSchedules. 
        /// <para>
        /// A list specifying the price of the Standard Reserved Instance for each month remaining
        /// in the Reserved Instance term.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PriceScheduleSpecification> PriceSchedules { get; set; } = AWSConfigs.InitializeCollections ? new List<PriceScheduleSpecification>() : null;

        /// <summary>
        /// Checks to see if the PriceSchedules property is set.
        /// </summary>
        internal bool IsSetPriceSchedules() => this.PriceSchedules != null && (this.PriceSchedules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReservedInstancesId. 
        /// <para>
        /// The ID of the active Standard Reserved Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReservedInstancesId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedInstancesId property is set.
        /// </summary>
        internal bool IsSetReservedInstancesId() => this.ReservedInstancesId != null;
    }
}
