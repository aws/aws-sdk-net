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
    /// Describes a block storage disk mapping.
    /// </summary>
    public partial class DiskMap
    {
        private string _newDiskName;
        private string _originalDiskPath;

        /// <summary>
        /// Gets and sets the property NewDiskName. 
        /// <para>
        /// The new disk name (<c>my-new-disk</c>).
        /// </para>
        /// </summary>
        public string NewDiskName
        {
            get { return this._newDiskName; }
            set { this._newDiskName = value; }
        }

        // Check to see if NewDiskName property is set
        internal bool IsSetNewDiskName()
        {
            return this._newDiskName != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalDiskPath. 
        /// <para>
        /// The original disk path exposed to the instance (for example, <c>/dev/sdh</c>).
        /// </para>
        /// </summary>
        public string OriginalDiskPath
        {
            get { return this._originalDiskPath; }
            set { this._originalDiskPath = value; }
        }

        // Check to see if OriginalDiskPath property is set
        internal bool IsSetOriginalDiskPath()
        {
            return this._originalDiskPath != null;
        }

    }
}