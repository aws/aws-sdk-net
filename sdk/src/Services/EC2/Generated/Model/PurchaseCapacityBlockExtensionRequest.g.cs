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
    /// Container for the parameters to the PurchaseCapacityBlockExtension operation. Purchase
    /// the Capacity Block extension for use with your account. You must specify the ID of
    /// the Capacity Block extension offering you are purchasing.
    /// </summary>
    public partial class PurchaseCapacityBlockExtensionRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionOfferingId. 
        /// <para>
        /// The ID of the Capacity Block extension offering to purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CapacityBlockExtensionOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockExtensionOfferingId property is set.
        /// </summary>
        internal bool IsSetCapacityBlockExtensionOfferingId() => this.CapacityBlockExtensionOfferingId != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity reservation to be extended.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationId() => this.CapacityReservationId != null;

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
    }
}
