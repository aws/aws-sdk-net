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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
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
namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// The description of a block device mapping.
    /// </summary>
    public partial class InstanceBlockDeviceMapping
    {
        private string _deviceName;
        private EbsInstanceBlockDevice _ebs;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The block device name.
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Ebs. 
        /// <para>
        /// The parameters used to automatically set up Amazon Elastic Block Store (Amazon EBS)
        /// volumes when the instance is launched. 
        /// </para>
        /// </summary>
        public EbsInstanceBlockDevice Ebs
        {
            get { return this._ebs; }
            set { this._ebs = value; }
        }

        // Check to see if Ebs property is set
        internal bool IsSetEbs()
        {
            return this._ebs != null;
        }

    }
}