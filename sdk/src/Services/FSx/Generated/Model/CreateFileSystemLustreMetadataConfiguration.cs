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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The Lustre metadata performance configuration for the creation of an Amazon FSx for
    /// Lustre file system using a <c>PERSISTENT_2</c> deployment type. The configuration
    /// uses a Metadata IOPS value to set the maximum rate of metadata disk IOPS supported
    /// by the file system.
    /// 
    ///  
    /// <para>
    /// After creation, the file system supports increasing metadata performance. For more
    /// information on Metadata IOPS, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/managing-metadata-performance.html#metadata-configuration">Lustre
    /// metadata performance configuration</a> in the <i>Amazon FSx for Lustre User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateFileSystemLustreMetadataConfiguration
    {
        private int? _iops;
        private MetadataConfigurationMode _mode;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// (USER_PROVISIONED mode only) Specifies the number of Metadata IOPS to provision for
        /// the file system. This parameter sets the maximum rate of metadata disk IOPS supported
        /// by the file system.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For SSD file systems, valid values are <c>1500</c>, <c>3000</c>, <c>6000</c>, <c>12000</c>,
        /// and multiples of <c>12000</c> up to a maximum of <c>192000</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Intelligent-Tiering file systems, valid values are <c>6000</c> and <c>12000</c>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>Iops</c> doesn’t have a default value. If you're using USER_PROVISIONED mode,
        /// you can choose to specify a valid value. If you're using AUTOMATIC mode, you cannot
        /// specify a value because FSx for Lustre automatically sets the value based on your
        /// file system storage capacity. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1500, Max=192000)]
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The metadata configuration mode for provisioning Metadata IOPS for an FSx for Lustre
        /// file system using a <c>PERSISTENT_2</c> deployment type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In AUTOMATIC mode (supported only on SSD file systems), FSx for Lustre automatically
        /// provisions and scales the number of Metadata IOPS for your file system based on your
        /// file system storage capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In USER_PROVISIONED mode, you specify the number of Metadata IOPS to provision for
        /// your file system.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataConfigurationMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}