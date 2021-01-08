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
    /// Container for the parameters to the TerminateInstances operation.
    /// Shuts down the specified instances. This operation is idempotent; if you terminate
    /// an instance more than once, each call succeeds. 
    /// 
    ///  
    /// <para>
    /// If you specify multiple instances and the request fails (for example, because of a
    /// single incorrect instance ID), none of the instances are terminated.
    /// </para>
    ///  
    /// <para>
    /// Terminated instances remain visible after termination (for approximately one hour).
    /// </para>
    ///  
    /// <para>
    /// By default, Amazon EC2 deletes all EBS volumes that were attached when the instance
    /// launched. Volumes attached after instance launch continue running.
    /// </para>
    ///  
    /// <para>
    /// You can stop, start, and terminate EBS-backed instances. You can only terminate instance
    /// store-backed instances. What happens to an instance differs if you stop it or terminate
    /// it. For example, when you stop an instance, the root device and any other devices
    /// attached to the instance persist. When you terminate an instance, any attached EBS
    /// volumes with the <code>DeleteOnTermination</code> block device mapping parameter set
    /// to <code>true</code> are automatically deleted. For more information about the differences
    /// between stopping and terminating instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
    /// lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about troubleshooting, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesShuttingDown.html">Troubleshooting
    /// terminating your instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TerminateInstancesRequest : AmazonEC2Request
    {
        private List<string> _instanceIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public TerminateInstancesRequest() { }

        /// <summary>
        /// Instantiates TerminateInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceIds">The IDs of the instances. Constraints: Up to 1000 instance IDs. We recommend breaking up this request into smaller batches.</param>
        public TerminateInstancesRequest(List<string> instanceIds)
        {
            _instanceIds = instanceIds;
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 1000 instance IDs. We recommend breaking up this request into smaller
        /// batches.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }

    }
}