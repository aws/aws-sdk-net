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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an instance snapshot.
    /// </summary>
    public partial class InstanceSnapshotInfo
    {
        private string _fromBlueprintId;
        private string _fromBundleId;
        private List<DiskInfo> _fromDiskInfo = AWSConfigs.InitializeCollections ? new List<DiskInfo>() : null;

        /// <summary>
        /// Gets and sets the property FromBlueprintId. 
        /// <para>
        /// The blueprint ID from which the source instance (<c>amazon_linux_2023</c>).
        /// </para>
        /// </summary>
        public string FromBlueprintId
        {
            get { return this._fromBlueprintId; }
            set { this._fromBlueprintId = value; }
        }

        // Check to see if FromBlueprintId property is set
        internal bool IsSetFromBlueprintId()
        {
            return this._fromBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property FromBundleId. 
        /// <para>
        /// The bundle ID from which the source instance was created (<c>micro_x_x</c>).
        /// </para>
        /// </summary>
        public string FromBundleId
        {
            get { return this._fromBundleId; }
            set { this._fromBundleId = value; }
        }

        // Check to see if FromBundleId property is set
        internal bool IsSetFromBundleId()
        {
            return this._fromBundleId != null;
        }

        /// <summary>
        /// Gets and sets the property FromDiskInfo. 
        /// <para>
        /// A list of objects describing the disks that were attached to the source instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DiskInfo> FromDiskInfo
        {
            get { return this._fromDiskInfo; }
            set { this._fromDiskInfo = value; }
        }

        // Check to see if FromDiskInfo property is set
        internal bool IsSetFromDiskInfo()
        {
            return this._fromDiskInfo != null && (this._fromDiskInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}