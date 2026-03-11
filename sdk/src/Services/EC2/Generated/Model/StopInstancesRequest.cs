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
    /// Container for the parameters to the StopInstances operation.
    /// Stops an Amazon EBS-backed instance. You can restart your instance at any time using
    /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_StartInstances.html">StartInstances</a>
    /// API. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html">Stop
    /// and start Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
    /// 
    ///  
    /// <para>
    /// When you stop or hibernate an instance, we shut it down. By default, this includes
    /// a graceful operating system (OS) shutdown. To bypass the graceful shutdown, use the
    /// <c>skipOsShutdown</c> parameter; however, this might risk data integrity.
    /// </para>
    ///  
    /// <para>
    /// You can use the StopInstances operation together with the <c>Hibernate</c> parameter
    /// to hibernate an instance if the instance is <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/enabling-hibernation.html">enabled
    /// for hibernation</a> and meets the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hibernating-prerequisites.html">hibernation
    /// prerequisites</a>. Stopping an instance doesn't preserve data stored in RAM, while
    /// hibernation does. If hibernation fails, a normal shutdown occurs. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
    /// your Amazon EC2 instance</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If your instance appears stuck in the <c>stopping</c> state, there might be an issue
    /// with the underlying host computer. You can use the StopInstances operation together
    /// with the Force parameter to force stop your instance. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesStopping.html">Troubleshoot
    /// Amazon EC2 instance stop issues</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Stopping and hibernating an instance differs from rebooting or terminating it. For
    /// example, a stopped or hibernated instance retains its root volume and any data volumes,
    /// unlike terminated instances where these volumes are automatically deleted. For more
    /// information about the differences between stopping, hibernating, rebooting, and terminating
    /// instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Amazon
    /// EC2 instance state changes</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// We don't charge for instance usage or data transfer fees when an instance is stopped.
    /// However, the root volume and any data volumes remain and continue to persist your
    /// data, and you're charged for volume usage. Every time you start your instance, Amazon
    /// EC2 charges a one-minute minimum for instance usage, followed by per-second billing.
    /// </para>
    ///  
    /// <para>
    /// You can't stop or hibernate instance store-backed instances.
    /// </para>
    /// </summary>
    public partial class StopInstancesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private bool? _force;
        private bool? _hibernate;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _skipOsShutdown;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public StopInstancesRequest() { }

        /// <summary>
        /// Instantiates StopInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceIds">The IDs of the instances.</param>
        public StopInstancesRequest(List<string> instanceIds)
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
        /// Forces the instance to stop. The instance will first attempt a graceful shutdown,
        /// which includes flushing file system caches and metadata. If the graceful shutdown
        /// fails to complete within the timeout period, the instance shuts down forcibly without
        /// flushing the file system caches and metadata.
        /// </para>
        ///  
        /// <para>
        /// After using this option, you must perform file system check and repair procedures.
        /// This option is not recommended for Windows instances. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesStopping.html">Troubleshoot
        /// Amazon EC2 instance stop issues</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
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
        /// Gets and sets the property Hibernate. 
        /// <para>
        /// Hibernates the instance if the instance was enabled for hibernation at launch. If
        /// the instance cannot hibernate successfully, a normal shutdown occurs. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
        /// your Amazon EC2 instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? Hibernate
        {
            get { return this._hibernate; }
            set { this._hibernate = value; }
        }

        // Check to see if Hibernate property is set
        internal bool IsSetHibernate()
        {
            return this._hibernate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances.
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
        /// stopped.
        /// </para>
        ///  <important> 
        /// <para>
        /// Bypassing the graceful OS shutdown might result in data loss or corruption (for example,
        /// memory contents not flushed to disk or loss of in-flight IOs) or skipped shutdown
        /// scripts.
        /// </para>
        ///  </important> 
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