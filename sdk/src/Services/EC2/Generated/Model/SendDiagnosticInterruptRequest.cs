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
    /// Container for the parameters to the SendDiagnosticInterrupt operation.
    /// Sends a diagnostic interrupt to the specified Amazon EC2 instance to trigger a <i>kernel
    /// panic</i> (on Linux instances), or a <i>blue screen</i>/<i>stop error</i> (on Windows
    /// instances). For instances based on Intel and AMD processors, the interrupt is received
    /// as a <i>non-maskable interrupt</i> (NMI).
    /// 
    ///  
    /// <para>
    /// In general, the operating system crashes and reboots when a kernel panic or stop error
    /// is triggered. The operating system can also be configured to perform diagnostic tasks,
    /// such as generating a memory dump file, loading a secondary kernel, or obtaining a
    /// call trace.
    /// </para>
    ///  
    /// <para>
    /// Before sending a diagnostic interrupt to your instance, ensure that its operating
    /// system is configured to perform the required diagnostic tasks.
    /// </para>
    ///  
    /// <para>
    /// For more information about configuring your operating system to generate a crash dump
    /// when a kernel panic or stop error occurs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/diagnostic-interrupt.html">Send
    /// a diagnostic interrupt (for advanced users)</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class SendDiagnosticInterruptRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _instanceId;

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

    }
}