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
    /// Container for the parameters to the PurchaseCapacityBlock operation.
    /// Purchase the Capacity Block for use with your account. With Capacity Blocks you ensure
    /// GPU capacity is available for machine learning (ML) workloads. You must specify the
    /// ID of the Capacity Block offering you are purchasing.
    /// </summary>
    public partial class PurchaseCapacityBlockRequest : AmazonEC2Request
    {
        private string _capacityBlockOfferingId;
        private CapacityReservationInstancePlatform _instancePlatform;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property CapacityBlockOfferingId. 
        /// <para>
        /// The ID of the Capacity Block offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapacityBlockOfferingId
        {
            get { return this._capacityBlockOfferingId; }
            set { this._capacityBlockOfferingId = value; }
        }

        // Check to see if CapacityBlockOfferingId property is set
        internal bool IsSetCapacityBlockOfferingId()
        {
            return this._capacityBlockOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property InstancePlatform. 
        /// <para>
        /// The type of operating system for which to reserve capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityReservationInstancePlatform InstancePlatform
        {
            get { return this._instancePlatform; }
            set { this._instancePlatform = value; }
        }

        // Check to see if InstancePlatform property is set
        internal bool IsSetInstancePlatform()
        {
            return this._instancePlatform != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the Capacity Block during launch.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}