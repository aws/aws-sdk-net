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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceCpuOptions operation.
    /// By default, all vCPUs for the instance type are active when you launch an instance.
    /// When you configure the number of active vCPUs for the instance, it can help you save
    /// on licensing costs and optimize performance. The base cost of the instance remains
    /// unchanged.
    /// 
    ///  
    /// <para>
    /// The number of active vCPUs equals the number of threads per CPU core multiplied by
    /// the number of cores. The instance must be in a <c>Stopped</c> state before you make
    /// changes.
    /// </para>
    ///  <note> 
    /// <para>
    /// Some instance type options do not support this capability. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cpu-options-supported-instances-values.html">Supported
    /// CPU options</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyInstanceCpuOptionsRequest : AmazonEC2Request
    {
        private int? _coreCount;
        private bool? _dryRun;
        private string _instanceId;
        private int? _threadsPerCore;

        /// <summary>
        /// Gets and sets the property CoreCount. 
        /// <para>
        /// The number of CPU cores to activate for the specified instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? CoreCount
        {
            get { return this._coreCount; }
            set { this._coreCount = value; }
        }

        // Check to see if CoreCount property is set
        internal bool IsSetCoreCount()
        {
            return this._coreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        /// The number of threads to run for each CPU core.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ThreadsPerCore
        {
            get { return this._threadsPerCore; }
            set { this._threadsPerCore = value; }
        }

        // Check to see if ThreadsPerCore property is set
        internal bool IsSetThreadsPerCore()
        {
            return this._threadsPerCore.HasValue; 
        }

    }
}