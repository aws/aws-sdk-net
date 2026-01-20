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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The instance lifecycle policy for the Auto Scaling group. This policy controls instance
    /// behavior when an instance transitions through its lifecycle states. Configure retention
    /// triggers to specify when instances should move to a <c>Retained</c> state instead
    /// of automatic termination. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/instance-lifecycle-policy.html">
    /// Control instance retention with instance lifecycle policies</a> in the <i>Amazon EC2
    /// Auto Scaling User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class InstanceLifecyclePolicy
    {
        private RetentionTriggers _retentionTriggers;

        /// <summary>
        /// Gets and sets the property RetentionTriggers. 
        /// <para>
        ///  Specifies the conditions that trigger instance retention behavior. These triggers
        /// determine when instances should move to a <c>Retained</c> state instead of automatic
        /// termination. This allows you to maintain control over instance management when lifecycles
        /// transition and operations fail. 
        /// </para>
        /// </summary>
        public RetentionTriggers RetentionTriggers
        {
            get { return this._retentionTriggers; }
            set { this._retentionTriggers = value; }
        }

        // Check to see if RetentionTriggers property is set
        internal bool IsSetRetentionTriggers()
        {
            return this._retentionTriggers != null;
        }

    }
}