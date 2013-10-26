/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Stops an instance that uses an Amazon EBS volume as its root device. Instances that use Amazon EBS volumes as their root devices can
    /// be quickly stopped and started. When an instance is stopped, the compute resources are released and you are not billed for hourly instance
    /// usage. However, your root partition Amazon EBS volume remains, continues to persist your data, and you are charged for Amazon EBS volume
    /// usage. You can restart your instance at any time. </para> <para><b>NOTE:</b> Before stopping an instance, make sure it is in a state from
    /// which it can be restarted. Stopping an instance does not preserve data stored in RAM. Performing this operation on an instance that uses an
    /// instance store as its root device returns an error. </para>
    /// </summary>
    public partial class StopInstancesRequest : AmazonEC2Request
    {
        private List<string> instanceIds = new List<string>();
        private bool? force;


        /// <summary>
        /// The list of Amazon EC2 instances to stop.
        ///  
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this.instanceIds; }
            set { this.instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this.instanceIds.Count > 0;
        }

        /// <summary>
        /// Forces the instance to stop. The instance will not have an opportunity to flush file system caches nor file system meta data. If you use
        /// this option, you must perform file system check and repair procedures. This option is not recommended for Windows instances.
        ///  
        /// </summary>
        public bool Force
        {
            get { return this.force ?? default(bool); }
            set { this.force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this.force.HasValue;
        }

    }
}
    
