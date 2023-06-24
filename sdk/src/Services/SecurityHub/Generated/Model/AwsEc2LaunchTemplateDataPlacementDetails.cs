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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about the placement of an Amazon EC2 instance.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataPlacementDetails
    {
        private string _affinity;
        private string _availabilityZone;
        private string _groupName;
        private string _hostId;
        private string _hostResourceGroupArn;
        private int? _partitionNumber;
        private string _spreadDomain;
        private string _tenancy;

        /// <summary>
        /// Gets and sets the property Affinity. 
        /// <para>
        ///  The affinity setting for an instance on an EC2 Dedicated Host. 
        /// </para>
        /// </summary>
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
        ///  The Availability Zone for the instance. 
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
        /// Gets and sets the property GroupName. 
        /// <para>
        ///  The name of the placement group for the instance. 
        /// </para>
        /// </summary>
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
        ///  The ID of the Dedicated Host for the instance. 
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
        ///  The Amazon Resource Name (ARN) of the host resource group in which to launch the
        /// instances. 
        /// </para>
        /// </summary>
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
        ///  The number of the partition the instance should launch in. 
        /// </para>
        /// </summary>
        public int PartitionNumber
        {
            get { return this._partitionNumber.GetValueOrDefault(); }
            set { this._partitionNumber = value; }
        }

        // Check to see if PartitionNumber property is set
        internal bool IsSetPartitionNumber()
        {
            return this._partitionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpreadDomain. 
        /// <para>
        ///  Reserved for future use. 
        /// </para>
        /// </summary>
        public string SpreadDomain
        {
            get { return this._spreadDomain; }
            set { this._spreadDomain = value; }
        }

        // Check to see if SpreadDomain property is set
        internal bool IsSetSpreadDomain()
        {
            return this._spreadDomain != null;
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        ///  The tenancy of the instance (if the instance is running in a VPC). An instance with
        /// a tenancy of dedicated runs on single-tenant hardware. 
        /// </para>
        /// </summary>
        public string Tenancy
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