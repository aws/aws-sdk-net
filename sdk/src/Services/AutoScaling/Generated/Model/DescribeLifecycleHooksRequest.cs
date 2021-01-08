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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLifecycleHooks operation.
    /// Describes the lifecycle hooks for the specified Auto Scaling group.
    /// </summary>
    public partial class DescribeLifecycleHooksRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _lifecycleHookNames = new List<string>();

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleHookNames. 
        /// <para>
        /// The names of one or more lifecycle hooks. If you omit this parameter, all lifecycle
        /// hooks are described.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> LifecycleHookNames
        {
            get { return this._lifecycleHookNames; }
            set { this._lifecycleHookNames = value; }
        }

        // Check to see if LifecycleHookNames property is set
        internal bool IsSetLifecycleHookNames()
        {
            return this._lifecycleHookNames != null && this._lifecycleHookNames.Count > 0; 
        }

    }
}