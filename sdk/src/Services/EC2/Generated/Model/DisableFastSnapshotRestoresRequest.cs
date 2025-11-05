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
    /// Container for the parameters to the DisableFastSnapshotRestores operation.
    /// Disables fast snapshot restores for the specified snapshots in the specified Availability
    /// Zones.
    /// </summary>
    public partial class DisableFastSnapshotRestoresRequest : AmazonEC2Request
    {
        private List<string> _availabilityZoneIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sourceSnapshotIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        /// One or more Availability Zone IDs. For example, <c>use2-az1</c>.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified in the
        /// request, but not both.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZoneIds
        {
            get { return this._availabilityZoneIds; }
            set { this._availabilityZoneIds = value; }
        }

        // Check to see if AvailabilityZoneIds property is set
        internal bool IsSetAvailabilityZoneIds()
        {
            return this._availabilityZoneIds != null && (this._availabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// One or more Availability Zones. For example, <c>us-east-2a</c>.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified in the
        /// request, but not both.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotIds. 
        /// <para>
        /// The IDs of one or more snapshots. For example, <c>snap-1234567890abcdef0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SourceSnapshotIds
        {
            get { return this._sourceSnapshotIds; }
            set { this._sourceSnapshotIds = value; }
        }

        // Check to see if SourceSnapshotIds property is set
        internal bool IsSetSourceSnapshotIds()
        {
            return this._sourceSnapshotIds != null && (this._sourceSnapshotIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}