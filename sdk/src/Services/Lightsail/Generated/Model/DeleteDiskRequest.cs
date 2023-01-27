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
    /// Container for the parameters to the DeleteDisk operation.
    /// Deletes the specified block storage disk. The disk must be in the <code>available</code>
    /// state (not attached to a Lightsail instance).
    /// 
    ///  <note> 
    /// <para>
    /// The disk may remain in the <code>deleting</code> state for several minutes.
    /// </para>
    ///  </note> 
    /// <para>
    /// The <code>delete disk</code> operation supports tag-based access control via resource
    /// tags applied to the resource identified by <code>disk name</code>. For more information,
    /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class DeleteDiskRequest : AmazonLightsailRequest
    {
        private string _diskName;
        private bool? _forceDeleteAddOns;

        /// <summary>
        /// Gets and sets the property DiskName. 
        /// <para>
        /// The unique name of the disk you want to delete (e.g., <code>my-disk</code>).
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
        /// Gets and sets the property ForceDeleteAddOns. 
        /// <para>
        /// A Boolean value to indicate whether to delete all add-ons for the disk.
        /// </para>
        /// </summary>
        public bool ForceDeleteAddOns
        {
            get { return this._forceDeleteAddOns.GetValueOrDefault(); }
            set { this._forceDeleteAddOns = value; }
        }

        // Check to see if ForceDeleteAddOns property is set
        internal bool IsSetForceDeleteAddOns()
        {
            return this._forceDeleteAddOns.HasValue; 
        }

    }
}