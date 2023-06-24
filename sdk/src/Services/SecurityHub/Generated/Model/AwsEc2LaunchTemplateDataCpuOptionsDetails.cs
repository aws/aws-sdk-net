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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the CPU options for an Amazon EC2 instance. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-optimize-cpu.html">Optimize
    /// CPU options</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataCpuOptionsDetails
    {
        private int? _coreCount;
        private int? _threadsPerCore;

        /// <summary>
        /// Gets and sets the property CoreCount. 
        /// <para>
        ///  The number of CPU cores for the instance. 
        /// </para>
        /// </summary>
        public int CoreCount
        {
            get { return this._coreCount.GetValueOrDefault(); }
            set { this._coreCount = value; }
        }

        // Check to see if CoreCount property is set
        internal bool IsSetCoreCount()
        {
            return this._coreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        ///  The number of threads per CPU core. A value of <code>1</code> disables multithreading
        /// for the instance, The default value is <code>2</code>. 
        /// </para>
        /// </summary>
        public int ThreadsPerCore
        {
            get { return this._threadsPerCore.GetValueOrDefault(); }
            set { this._threadsPerCore = value; }
        }

        // Check to see if ThreadsPerCore property is set
        internal bool IsSetThreadsPerCore()
        {
            return this._threadsPerCore.HasValue; 
        }

    }
}