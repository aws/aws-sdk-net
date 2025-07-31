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
    /// Container for the parameters to the TerminateInstances operation.
    /// Shuts down the specified instances. This operation is <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">idempotent</a>;
    /// if you terminate an instance more than once, each call succeeds.
    /// 
    ///  
    /// <para>
    /// If you specify multiple instances and the request fails (for example, because of a
    /// single incorrect instance ID), none of the instances are terminated.
    /// </para>
    ///  
    /// <para>
    /// If you terminate multiple instances across multiple Availability Zones, and one or
    /// more of the specified instances are enabled for termination protection, the request
    /// fails with the following results:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The specified instances that are in the same Availability Zone as the protected instance
    /// are not terminated.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The specified instances that are in different Availability Zones, where no other specified
    /// instances are protected, are successfully terminated.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example, say you have the following instances:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Instance A: <c>us-east-1a</c>; Not protected
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instance B: <c>us-east-1a</c>; Not protected
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instance C: <c>us-east-1b</c>; Protected
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instance D: <c>us-east-1b</c>; not protected
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you attempt to terminate all of these instances in the same request, the request
    /// reports failure with the following results:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Instance A and Instance B are successfully terminated because none of the specified
    /// instances in <c>us-east-1a</c> are enabled for termination protection.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instance C and Instance D fail to terminate because at least one of the specified
    /// instances in <c>us-east-1b</c> (Instance C) is enabled for termination protection.
    /// </para>
    ///  </li> </ul> 
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
    /// By default, the TerminateInstances operation includes a graceful operating system
    /// (OS) shutdown. To bypass the graceful shutdown, use the <c>skipOsShutdown</c> parameter;
    /// however, this might risk data integrity.
    /// </para>
    ///  
    /// <para>
    /// You can stop, start, and terminate EBS-backed instances. You can only terminate instance
    /// store-backed instances. What happens to an instance differs if you stop or terminate
    /// it. For example, when you stop an instance, the root device and any other devices
    /// attached to the instance persist. When you terminate an instance, any attached EBS
    /// volumes with the <c>DeleteOnTermination</c> block device mapping parameter set to
    /// <c>true</c> are automatically deleted. For more information about the differences
    /// between stopping and terminating instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Amazon
    /// EC2 instance state changes</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When you terminate an instance, we attempt to terminate it forcibly after a short
    /// while. If your instance appears stuck in the shutting-down state after a period of
    /// time, there might be an issue with the underlying host computer. For more information
    /// about terminating and troubleshooting terminating your instances, see <a href="https://docs.aws.amazon.com/">Terminate
    /// Amazon EC2 instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesShuttingDown.html">Troubleshooting
    /// terminating your instance</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TerminateInstancesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private bool? _force;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _skipOsShutdown;

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
        /// Gets and sets the property Force. 
        /// <para>
        /// Forces the instances to terminate. The instance will first attempt a graceful shutdown,
        /// which includes flushing file system caches and metadata. If the graceful shutdown
        /// fails to complete within the timeout period, the instance shuts down forcibly without
        /// flushing the file system caches and metadata.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SkipOsShutdown. 
        /// <para>
        /// Specifies whether to bypass the graceful OS shutdown process when the instance is
        /// terminated.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? SkipOsShutdown
        {
            get { return this._skipOsShutdown; }
            set { this._skipOsShutdown = value; }
        }

        // Check to see if SkipOsShutdown property is set
        internal bool IsSetSkipOsShutdown()
        {
            return this._skipOsShutdown.HasValue; 
        }

    }
}