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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the valid options for additional storage volumes for a DB instance.
    /// </summary>
    public partial class ValidAdditionalStorageOptions
    {
        private bool? _supportsAdditionalStorageVolumes;
        private List<ValidVolumeOptions> _volumes = AWSConfigs.InitializeCollections ? new List<ValidVolumeOptions>() : null;

        /// <summary>
        /// Gets and sets the property SupportsAdditionalStorageVolumes. 
        /// <para>
        /// Indicates whether the DB instance supports additional storage volumes.
        /// </para>
        /// </summary>
        public bool SupportsAdditionalStorageVolumes
        {
            get { return this._supportsAdditionalStorageVolumes.GetValueOrDefault(); }
            set { this._supportsAdditionalStorageVolumes = value; }
        }

        // Check to see if SupportsAdditionalStorageVolumes property is set
        internal bool IsSetSupportsAdditionalStorageVolumes()
        {
            return this._supportsAdditionalStorageVolumes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// The valid additional storage volume options for the DB instance.
        /// </para>
        /// </summary>
        public List<ValidVolumeOptions> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && (this._volumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}