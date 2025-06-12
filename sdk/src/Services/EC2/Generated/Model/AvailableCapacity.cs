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
    /// The capacity information for instances that can be launched onto the Dedicated Host.
    /// </summary>
    public partial class AvailableCapacity
    {
        private List<InstanceCapacity> _availableInstanceCapacity = AWSConfigs.InitializeCollections ? new List<InstanceCapacity>() : null;
        private int? _availableVCpus;

        /// <summary>
        /// Gets and sets the property AvailableInstanceCapacity. 
        /// <para>
        /// The number of instances that can be launched onto the Dedicated Host depending on
        /// the host's available capacity. For Dedicated Hosts that support multiple instance
        /// types, this parameter represents the number of instances for each instance size that
        /// is supported on the host.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceCapacity> AvailableInstanceCapacity
        {
            get { return this._availableInstanceCapacity; }
            set { this._availableInstanceCapacity = value; }
        }

        // Check to see if AvailableInstanceCapacity property is set
        internal bool IsSetAvailableInstanceCapacity()
        {
            return this._availableInstanceCapacity != null && (this._availableInstanceCapacity.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailableVCpus. 
        /// <para>
        /// The number of vCPUs available for launching instances onto the Dedicated Host.
        /// </para>
        /// </summary>
        public int? AvailableVCpus
        {
            get { return this._availableVCpus; }
            set { this._availableVCpus = value; }
        }

        // Check to see if AvailableVCpus property is set
        internal bool IsSetAvailableVCpus()
        {
            return this._availableVCpus.HasValue; 
        }

    }
}