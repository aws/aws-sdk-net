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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetConsoleOutput operation.
    /// Gets the console output for the specified instance. For Linux instances, the instance
    /// console output displays the exact console output that would normally be displayed
    /// on a physical monitor attached to a computer. For Windows instances, the instance
    /// console output includes the last three system event log errors.
    /// 
    ///  
    /// <para>
    /// By default, the console output returns buffered information that was posted shortly
    /// after an instance transition state (start, stop, reboot, or terminate). This information
    /// is available for at least one hour after the most recent post. Only the most recent
    /// 64 KB of console output is available.
    /// </para>
    ///  
    /// <para>
    /// You can optionally retrieve the latest serial console output at any time during the
    /// instance lifecycle. This option is supported on instance types that use the Nitro
    /// hypervisor.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-console.html#instance-console-console-output">Instance
    /// Console Output</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetConsoleOutputRequest : AmazonEC2Request
    {
        private string _instanceId;
        private bool? _latest;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetConsoleOutputRequest() { }

        /// <summary>
        /// Instantiates GetConsoleOutputRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        public GetConsoleOutputRequest(string instanceId)
        {
            _instanceId = instanceId;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
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
        /// Gets and sets the property Latest. 
        /// <para>
        /// When enabled, retrieves the latest console output for the instance.
        /// </para>
        ///  
        /// <para>
        /// Default: disabled (<code>false</code>)
        /// </para>
        /// </summary>
        public bool Latest
        {
            get { return this._latest.GetValueOrDefault(); }
            set { this._latest = value; }
        }

        // Check to see if Latest property is set
        internal bool IsSetLatest()
        {
            return this._latest.HasValue; 
        }

    }
}