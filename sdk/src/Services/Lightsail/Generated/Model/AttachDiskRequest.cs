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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the AttachDisk operation.
    /// Attaches a block storage disk to a running or stopped Lightsail instance and exposes
    /// it to the instance with the specified disk name.
    /// 
    ///  
    /// <para>
    /// The <code>attach disk</code> operation supports tag-based access control via resource
    /// tags applied to the resource identified by <code>disk name</code>. For more information,
    /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AttachDiskRequest : AmazonLightsailRequest
    {
        private bool? _autoMounting;
        private string _diskName;
        private string _diskPath;
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property AutoMounting. 
        /// <para>
        /// A Boolean value used to determine the automatic mounting of a storage volume to a
        /// virtual computer. The default value is <code>False</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This value only applies to Lightsail for Research resources.
        /// </para>
        ///  </important>
        /// </summary>
        public bool AutoMounting
        {
            get { return this._autoMounting.GetValueOrDefault(); }
            set { this._autoMounting = value; }
        }

        // Check to see if AutoMounting property is set
        internal bool IsSetAutoMounting()
        {
            return this._autoMounting.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiskName. 
        /// <para>
        /// The unique Lightsail disk name (e.g., <code>my-disk</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DiskName
        {
            get { return this._diskName; }
            set { this._diskName = value; }
        }

        // Check to see if DiskName property is set
        internal bool IsSetDiskName()
        {
            return this._diskName != null;
        }

        /// <summary>
        /// Gets and sets the property DiskPath. 
        /// <para>
        /// The disk path to expose to the instance (e.g., <code>/dev/xvdf</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DiskPath
        {
            get { return this._diskPath; }
            set { this._diskPath = value; }
        }

        // Check to see if DiskPath property is set
        internal bool IsSetDiskPath()
        {
            return this._diskPath != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the Lightsail instance where you want to utilize the storage disk.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

    }
}