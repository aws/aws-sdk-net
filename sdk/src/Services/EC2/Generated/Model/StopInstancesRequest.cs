/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the StopInstances operation.
    /// Stops an Amazon EBS-backed instance.
    /// 
    ///  
    /// <para>
    /// We don't charge hourly usage for a stopped instance, or data transfer fees; however,
    /// your root partition Amazon EBS volume remains, continues to persist your data, and
    /// you are charged for Amazon EBS volume usage. Each time you transition an instance
    /// from stopped to started, Amazon EC2 charges a full instance hour, even if transitions
    /// happen multiple times within a single hour.
    /// </para>
    ///  
    /// <para>
    /// You can't start or stop Spot instances, and you can't stop instance store-backed instances.
    /// </para>
    ///  
    /// <para>
    /// When you stop an instance, we shut it down. You can restart your instance at any time.
    /// Before stopping an instance, make sure it is in a state from which it can be restarted.
    /// Stopping an instance does not preserve data stored in RAM.
    /// </para>
    ///  
    /// <para>
    /// Stopping an instance is different to rebooting or terminating it. For example, when
    /// you stop an instance, the root device and any other devices attached to the instance
    /// persist. When you terminate an instance, the root device and any other devices attached
    /// during the instance launch are automatically deleted. For more information about the
    /// differences between rebooting, stopping, and terminating instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
    /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When you stop an instance, we attempt to shut it down forcibly after a short while.
    /// If your instance appears stuck in the stopping state after a period of time, there
    /// may be an issue with the underlying host computer. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesStopping.html">Troubleshooting
    /// Stopping Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class StopInstancesRequest : AmazonEC2Request
    {
        private bool? _force;
        private List<string> _instanceIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public StopInstancesRequest() { }

        /// <summary>
        /// Instantiates StopInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceIds">One or more instance IDs.</param>
        public StopInstancesRequest(List<string> instanceIds)
        {
            _instanceIds = instanceIds;
        }

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Forces the instances to stop. The instances do not have an opportunity to flush file
        /// system caches or file system metadata. If you use this option, you must perform file
        /// system check and repair procedures. This option is not recommended for Windows instances.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
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
        /// One or more instance IDs.
        /// </para>
        /// </summary>
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