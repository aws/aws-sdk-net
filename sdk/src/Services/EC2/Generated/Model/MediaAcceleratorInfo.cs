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
    /// Describes the media accelerators for the instance type.
    /// </summary>
    public partial class MediaAcceleratorInfo
    {
        private List<MediaDeviceInfo> _accelerators = AWSConfigs.InitializeCollections ? new List<MediaDeviceInfo>() : null;
        private int? _totalMediaMemoryInMiB;

        /// <summary>
        /// Gets and sets the property Accelerators. 
        /// <para>
        /// Describes the media accelerators for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MediaDeviceInfo> Accelerators
        {
            get { return this._accelerators; }
            set { this._accelerators = value; }
        }

        // Check to see if Accelerators property is set
        internal bool IsSetAccelerators()
        {
            return this._accelerators != null && (this._accelerators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalMediaMemoryInMiB. 
        /// <para>
        /// The total size of the memory for the media accelerators for the instance type, in
        /// MiB.
        /// </para>
        /// </summary>
        public int? TotalMediaMemoryInMiB
        {
            get { return this._totalMediaMemoryInMiB; }
            set { this._totalMediaMemoryInMiB = value; }
        }

        // Check to see if TotalMediaMemoryInMiB property is set
        internal bool IsSetTotalMediaMemoryInMiB()
        {
            return this._totalMediaMemoryInMiB.HasValue; 
        }

    }
}