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
    /// Describes an instance reuse policy for a warm pool. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
    /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class InstanceReusePolicy
    {
        private bool? _reuseOnScaleIn;

        /// <summary>
        /// Gets and sets the property ReuseOnScaleIn. 
        /// <para>
        /// Specifies whether instances in the Auto Scaling group can be returned to the warm
        /// pool on scale in. 
        /// </para>
        /// </summary>
        public bool? ReuseOnScaleIn
        {
            get { return this._reuseOnScaleIn; }
            set { this._reuseOnScaleIn = value; }
        }

        // Check to see if ReuseOnScaleIn property is set
        internal bool IsSetReuseOnScaleIn()
        {
            return this._reuseOnScaleIn.HasValue; 
        }

    }
}