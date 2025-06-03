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
    /// The Lustre metadata performance configuration update for an Amazon FSx for Lustre
    /// file system using a <c>PERSISTENT_2</c> deployment type. You can request an increase
    /// in your file system's Metadata IOPS and/or switch your file system's metadata configuration
    /// mode. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/managing-metadata-performance.html">Managing
    /// metadata performance</a> in the <i>Amazon FSx for Lustre User Guide</i>.
    /// </summary>
    public partial class UpdateFileSystemLustreMetadataConfiguration
    {
        private int? _iops;
        private MetadataConfigurationMode _mode;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// (USER_PROVISIONED mode only) Specifies the number of Metadata IOPS to provision for
        /// your file system.
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
        ///  </li> </ul> 
        /// <para>
        /// The value you provide must be greater than or equal to the current number of Metadata
        /// IOPS provisioned for the file system.
        /// </para>
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
        /// To increase the Metadata IOPS or to switch an SSD file system from AUTOMATIC, specify
        /// <c>USER_PROVISIONED</c> as the value for this parameter. Then use the Iops parameter
        /// to provide a Metadata IOPS value that is greater than or equal to the current number
        /// of Metadata IOPS provisioned for the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To switch from USER_PROVISIONED mode on an SSD file system, specify <c>AUTOMATIC</c>
        /// as the value for this parameter, but do not input a value for Iops.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// If you request to switch from USER_PROVISIONED to AUTOMATIC mode and the current Metadata
        /// IOPS value is greater than the automated default, FSx for Lustre rejects the request
        /// because downscaling Metadata IOPS is not supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AUTOMATIC mode is not supported on Intelligent-Tiering file systems. For Intelligent-Tiering
        /// file systems, use USER_PROVISIONED mode.
        /// </para>
        ///  </li> </ul> </note> </li> </ul>
        /// </summary>
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