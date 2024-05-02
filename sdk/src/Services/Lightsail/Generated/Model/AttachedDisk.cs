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
    /// Describes a block storage disk that is attached to an instance, and is included in
    /// an automatic snapshot.
    /// </summary>
    public partial class AttachedDisk
    {
        private string _path;
        private int? _sizeInGb;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path of the disk (<c>/dev/xvdf</c>).
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size of the disk in GB.
        /// </para>
        /// </summary>
        public int? SizeInGb
        {
            get { return this._sizeInGb; }
            set { this._sizeInGb = value; }
        }

        // Check to see if SizeInGb property is set
        internal bool IsSetSizeInGb()
        {
            return this._sizeInGb.HasValue; 
        }

    }
}