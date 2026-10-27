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
    /// Describes a disk.
    /// </summary>
    public partial class DiskInfo
    {
        /// <summary>
        /// Gets and sets the property IsSystemDisk. 
        /// <para>
        /// A Boolean value indicating whether this disk is a system disk (has an operating system
        /// loaded on it).
        /// </para>
        /// </summary>
        public bool? IsSystemDisk { get; set; }

        /// <summary>
        /// Checks to see if the IsSystemDisk property is set.
        /// </summary>
        internal bool IsSetIsSystemDisk() => this.IsSystemDisk.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The disk name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The disk path.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size of the disk in GB (<c>32</c>).
        /// </para>
        /// </summary>
        public int? SizeInGb { get; set; }

        /// <summary>
        /// Checks to see if the SizeInGb property is set.
        /// </summary>
        internal bool IsSetSizeInGb() => this.SizeInGb.HasValue;
    }
}
