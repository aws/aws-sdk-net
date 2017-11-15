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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DetachDisk operation.
    /// Detaches a stopped block storage disk from a Lightsail instance. Make sure to unmount
    /// any file systems on the device within your operating system before stopping the instance
    /// and detaching the disk.
    /// </summary>
    public partial class DetachDiskRequest : AmazonLightsailRequest
    {
        private string _diskName;

        /// <summary>
        /// Gets and sets the property DiskName. 
        /// <para>
        /// The unique name of the disk you want to detach from your instance (e.g., <code>my-disk</code>).
        /// </para>
        /// </summary>
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

    }
}