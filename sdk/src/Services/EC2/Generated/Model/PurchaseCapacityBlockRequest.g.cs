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
    /// Container for the parameters to the PurchaseCapacityBlock operation. Purchase the
    /// Capacity Block for use with your account. With Capacity Blocks you ensure GPU capacity
    /// is available for machine learning (ML) workloads. You must specify the ID of the Capacity
    /// Block offering you are purchasing.
    /// </summary>
    public partial class PurchaseCapacityBlockRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CapacityBlockOfferingId. 
        /// <para>
        /// The ID of the Capacity Block offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CapacityBlockOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockOfferingId property is set.
        /// </summary>
        internal bool IsSetCapacityBlockOfferingId() => this.CapacityBlockOfferingId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InstancePlatform. 
        /// <para>
        /// The type of operating system for which to reserve capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityReservationInstancePlatform InstancePlatform { get; set; }

        /// <summary>
        /// Checks to see if the InstancePlatform property is set.
        /// </summary>
        internal bool IsSetInstancePlatform() => this.InstancePlatform != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the Capacity Block during launch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
