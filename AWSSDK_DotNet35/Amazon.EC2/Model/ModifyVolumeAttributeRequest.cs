/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVolumeAttribute operation.
    /// Modifies a volume attribute.
    /// 
    ///  
    /// <para>
    /// By default, all I/O operations for the volume are suspended when the data on the volume
    /// is determined to be potentially inconsistent, to prevent undetectable, latent data
    /// corruption. The I/O access to the volume can be resumed by first enabling I/O access
    /// and then checking the data consistency on your volume.
    /// </para>
    ///  
    /// <para>
    /// You can change the default behavior to resume I/O operations. We recommend that you
    /// change this only for boot volumes or for volumes that are stateless or disposable.
    /// </para>
    /// </summary>
    public partial class ModifyVolumeAttributeRequest : AmazonEC2Request
    {
        private bool? _autoEnableIO;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property AutoEnableIO. 
        /// <para>
        /// Indicates whether the volume should be auto-enabled for I/O operations.
        /// </para>
        /// </summary>
        public bool AutoEnableIO
        {
            get { return this._autoEnableIO.GetValueOrDefault(); }
            set { this._autoEnableIO = value; }
        }

        // Check to see if AutoEnableIO property is set
        internal bool IsSetAutoEnableIO()
        {
            return this._autoEnableIO.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}