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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCapacityProvider operation.
    /// Modifies the parameters for a capacity provider.
    /// </summary>
    public partial class UpdateCapacityProviderRequest : AmazonECSRequest
    {
        private AutoScalingGroupProviderUpdate _autoScalingGroupProvider;
        private string _name;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupProvider. 
        /// <para>
        /// The name of the capacity provider to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoScalingGroupProviderUpdate AutoScalingGroupProvider
        {
            get { return this._autoScalingGroupProvider; }
            set { this._autoScalingGroupProvider = value; }
        }

        // Check to see if AutoScalingGroupProvider property is set
        internal bool IsSetAutoScalingGroupProvider()
        {
            return this._autoScalingGroupProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An object representing the parameters to update for the Auto Scaling group capacity
        /// provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}