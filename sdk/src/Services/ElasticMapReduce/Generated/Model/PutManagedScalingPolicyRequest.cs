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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the PutManagedScalingPolicy operation.
    /// Creates or updates a managed scaling policy for an Amazon EMR cluster. The managed
    /// scaling policy defines the limits for resources, such as Amazon EC2 instances that
    /// can be added or terminated from a cluster. The policy only applies to the core and
    /// task nodes. The master node cannot be scaled after initial configuration.
    /// </summary>
    public partial class PutManagedScalingPolicyRequest : AmazonElasticMapReduceRequest
    {
        private string _clusterId;
        private ManagedScalingPolicy _managedScalingPolicy;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// Specifies the ID of an Amazon EMR cluster where the managed scaling policy is attached.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedScalingPolicy. 
        /// <para>
        /// Specifies the constraints for the managed scaling policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ManagedScalingPolicy ManagedScalingPolicy
        {
            get { return this._managedScalingPolicy; }
            set { this._managedScalingPolicy = value; }
        }

        // Check to see if ManagedScalingPolicy property is set
        internal bool IsSetManagedScalingPolicy()
        {
            return this._managedScalingPolicy != null;
        }

    }
}