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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the AttachDisk operation. Attaches a block storage
    /// disk to a running or stopped Lightsail instance and exposes it to the instance with
    /// the specified disk name. <para> The <c>attach disk</c> operation supports tag-based
    /// access control via resource tags applied to the resource identified by <c>disk name</c>.
    /// For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>. </para>
    /// </summary>
    public partial class AttachDiskRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property AutoMounting. 
        /// <para>
        /// A Boolean value used to determine the automatic mounting of a storage volume to a
        /// virtual computer. The default value is <c>False</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This value only applies to Lightsail for Research resources.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? AutoMounting { get; set; }

        /// <summary>
        /// Checks to see if the AutoMounting property is set.
        /// </summary>
        internal bool IsSetAutoMounting() => this.AutoMounting.HasValue;

        /// <summary>
        /// Gets and sets the property DiskName. 
        /// <para>
        /// The unique Lightsail disk name (<c>my-disk</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DiskName { get; set; }

        /// <summary>
        /// Checks to see if the DiskName property is set.
        /// </summary>
        internal bool IsSetDiskName() => this.DiskName != null;

        /// <summary>
        /// Gets and sets the property DiskPath. 
        /// <para>
        /// The disk path to expose to the instance (<c>/dev/xvdf</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DiskPath { get; set; }

        /// <summary>
        /// Checks to see if the DiskPath property is set.
        /// </summary>
        internal bool IsSetDiskPath() => this.DiskPath != null;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the Lightsail instance where you want to utilize the storage disk.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;
    }
}
