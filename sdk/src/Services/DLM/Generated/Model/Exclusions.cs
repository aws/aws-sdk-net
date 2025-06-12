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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
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
namespace Amazon.DLM.Model
{
    /// <summary>
    /// <b>[Default policies only]</b> Specifies exclusion parameters for volumes or instances
    /// for which you do not want to create snapshots or AMIs. The policy will not create
    /// snapshots or AMIs for target resources that match any of the specified exclusion parameters.
    /// </summary>
    public partial class Exclusions
    {
        private bool? _excludeBootVolumes;
        private List<Tag> _excludeTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<string> _excludeVolumeTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ExcludeBootVolumes. 
        /// <para>
        ///  <b>[Default policies for EBS snapshots only]</b> Indicates whether to exclude volumes
        /// that are attached to instances as the boot volume. If you exclude boot volumes, only
        /// volumes attached as data (non-boot) volumes will be backed up by the policy. To exclude
        /// boot volumes, specify <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ExcludeBootVolumes
        {
            get { return this._excludeBootVolumes; }
            set { this._excludeBootVolumes = value; }
        }

        // Check to see if ExcludeBootVolumes property is set
        internal bool IsSetExcludeBootVolumes()
        {
            return this._excludeBootVolumes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeTags. 
        /// <para>
        ///  <b>[Default policies for EBS-backed AMIs only]</b> Specifies whether to exclude volumes
        /// that have specific tags. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> ExcludeTags
        {
            get { return this._excludeTags; }
            set { this._excludeTags = value; }
        }

        // Check to see if ExcludeTags property is set
        internal bool IsSetExcludeTags()
        {
            return this._excludeTags != null && (this._excludeTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExcludeVolumeTypes. 
        /// <para>
        ///  <b>[Default policies for EBS snapshots only]</b> Specifies the volume types to exclude.
        /// Volumes of the specified types will not be targeted by the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public List<string> ExcludeVolumeTypes
        {
            get { return this._excludeVolumeTypes; }
            set { this._excludeVolumeTypes = value; }
        }

        // Check to see if ExcludeVolumeTypes property is set
        internal bool IsSetExcludeVolumeTypes()
        {
            return this._excludeVolumeTypes != null && (this._excludeVolumeTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}