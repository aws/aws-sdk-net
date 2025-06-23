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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines instance placement configuration for WorkSpace Instance.
    /// </summary>
    public partial class Placement
    {
        private string _affinity;
        private string _availabilityZone;
        private string _groupId;
        private string _groupName;
        private string _hostId;
        private string _hostResourceGroupArn;
        private int? _partitionNumber;
        private TenancyEnum _tenancy;

        /// <summary>
        /// Gets and sets the property Affinity. 
        /// <para>
        /// Specifies host affinity for dedicated instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string Affinity
        {
            get { return this._affinity; }
            set { this._affinity = value; }
        }

        // Check to see if Affinity property is set
        internal bool IsSetAffinity()
        {
            return this._affinity != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// Identifies the specific AWS availability zone.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// Unique identifier for placement group.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// Name of the placement group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        /// Identifies the specific dedicated host.
        /// </para>
        /// </summary>
        public string HostId
        {
            get { return this._hostId; }
            set { this._hostId = value; }
        }

        // Check to see if HostId property is set
        internal bool IsSetHostId()
        {
            return this._hostId != null;
        }

        /// <summary>
        /// Gets and sets the property HostResourceGroupArn. 
        /// <para>
        /// ARN of the host resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string HostResourceGroupArn
        {
            get { return this._hostResourceGroupArn; }
            set { this._hostResourceGroupArn = value; }
        }

        // Check to see if HostResourceGroupArn property is set
        internal bool IsSetHostResourceGroupArn()
        {
            return this._hostResourceGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionNumber. 
        /// <para>
        /// Specifies partition number for partition placement groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PartitionNumber
        {
            get { return this._partitionNumber; }
            set { this._partitionNumber = value; }
        }

        // Check to see if PartitionNumber property is set
        internal bool IsSetPartitionNumber()
        {
            return this._partitionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Defines instance tenancy configuration.
        /// </para>
        /// </summary>
        public TenancyEnum Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

    }
}