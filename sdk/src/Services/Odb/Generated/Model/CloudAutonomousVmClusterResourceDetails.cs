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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Resource details of an Autonomous VM cluster.
    /// </summary>
    public partial class CloudAutonomousVmClusterResourceDetails
    {
        private string _cloudAutonomousVmClusterId;
        private double? _unallocatedAdbStorageInTBs;

        /// <summary>
        /// Gets and sets the property CloudAutonomousVmClusterId. 
        /// <para>
        /// The unique identifier of the Autonomous VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string CloudAutonomousVmClusterId
        {
            get { return this._cloudAutonomousVmClusterId; }
            set { this._cloudAutonomousVmClusterId = value; }
        }

        // Check to see if CloudAutonomousVmClusterId property is set
        internal bool IsSetCloudAutonomousVmClusterId()
        {
            return this._cloudAutonomousVmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property UnallocatedAdbStorageInTBs. 
        /// <para>
        /// The amount of unallocated Autonomous Database storage in the Autonomous VM cluster,
        /// in terabytes.
        /// </para>
        /// </summary>
        public double? UnallocatedAdbStorageInTBs
        {
            get { return this._unallocatedAdbStorageInTBs; }
            set { this._unallocatedAdbStorageInTBs = value; }
        }

        // Check to see if UnallocatedAdbStorageInTBs property is set
        internal bool IsSetUnallocatedAdbStorageInTBs()
        {
            return this._unallocatedAdbStorageInTBs.HasValue; 
        }

    }
}