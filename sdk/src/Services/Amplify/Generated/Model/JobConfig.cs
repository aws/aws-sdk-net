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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes the configuration details that apply to the jobs for an Amplify app.
    /// 
    ///  
    /// <para>
    /// Use <c>JobConfig</c> to apply configuration to jobs, such as customizing the build
    /// instance size when you create or update an Amplify app. For more information about
    /// customizable build instances, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/custom-build-instance.html">Custom
    /// build instances</a> in the <i>Amplify User Guide</i>.
    /// </para>
    /// </summary>
    public partial class JobConfig
    {
        private BuildComputeType _buildComputeType;

        /// <summary>
        /// Gets and sets the property BuildComputeType. 
        /// <para>
        /// Specifies the size of the build instance. Amplify supports three instance sizes: <c>STANDARD_8GB</c>,
        /// <c>LARGE_16GB</c>, and <c>XLARGE_72GB</c>. If you don't specify a value, Amplify uses
        /// the <c>STANDARD_8GB</c> default.
        /// </para>
        ///  
        /// <para>
        /// The following list describes the CPU, memory, and storage capacity for each build
        /// instance type:
        /// </para>
        ///  <dl> <dt>STANDARD_8GB</dt> <dd> <ul> <li> 
        /// <para>
        /// vCPUs: 4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Memory: 8 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Disk space: 128 GB
        /// </para>
        ///  </li> </ul> </dd> <dt>LARGE_16GB</dt> <dd> <ul> <li> 
        /// <para>
        /// vCPUs: 8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Memory: 16 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Disk space: 128 GB
        /// </para>
        ///  </li> </ul> </dd> <dt>XLARGE_72GB</dt> <dd> <ul> <li> 
        /// <para>
        /// vCPUs: 36
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Memory: 72 GiB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Disk space: 256 GB
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public BuildComputeType BuildComputeType
        {
            get { return this._buildComputeType; }
            set { this._buildComputeType = value; }
        }

        // Check to see if BuildComputeType property is set
        internal bool IsSetBuildComputeType()
        {
            return this._buildComputeType != null;
        }

    }
}