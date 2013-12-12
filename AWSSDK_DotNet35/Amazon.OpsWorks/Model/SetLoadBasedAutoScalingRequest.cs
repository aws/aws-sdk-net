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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the SetLoadBasedAutoScaling operation.
    /// <para>Specify the load-based auto scaling configuration for a specified layer. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html" >Managing Load with Time-based and Load-based
    /// Instances</a> .</para> <para><b>NOTE:</b>To use load-based auto scaling, you must create a set of load-based auto scaling instances.
    /// Load-based auto scaling operates only on the instances from that set, so you must ensure that you have created enough instances to handle
    /// the maximum anticipated load.</para> <para> <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached policy that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class SetLoadBasedAutoScalingRequest : AmazonOpsWorksRequest
    {
        private string layerId;
        private bool? enable;
        private AutoScalingThresholds upScaling;
        private AutoScalingThresholds downScaling;


        /// <summary>
        /// The layer ID.
        ///  
        /// </summary>
        public string LayerId
        {
            get { return this.layerId; }
            set { this.layerId = value; }
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this.layerId != null;
        }

        /// <summary>
        /// Enables load-based auto scaling for the layer.
        ///  
        /// </summary>
        public bool Enable
        {
            get { return this.enable ?? default(bool); }
            set { this.enable = value; }
        }

        // Check to see if Enable property is set
        internal bool IsSetEnable()
        {
            return this.enable.HasValue;
        }

        /// <summary>
        /// An <c>AutoScalingThresholds</c> object with the upscaling threshold configuration. If the load exceeds these thresholds for a specified
        /// amount of time, AWS OpsWorks starts a specified number of instances.
        ///  
        /// </summary>
        public AutoScalingThresholds UpScaling
        {
            get { return this.upScaling; }
            set { this.upScaling = value; }
        }

        // Check to see if UpScaling property is set
        internal bool IsSetUpScaling()
        {
            return this.upScaling != null;
        }

        /// <summary>
        /// An <c>AutoScalingThresholds</c> object with the downscaling threshold configuration. If the load falls below these thresholds for a
        /// specified amount of time, AWS OpsWorks stops a specified number of instances.
        ///  
        /// </summary>
        public AutoScalingThresholds DownScaling
        {
            get { return this.downScaling; }
            set { this.downScaling = value; }
        }

        // Check to see if DownScaling property is set
        internal bool IsSetDownScaling()
        {
            return this.downScaling != null;
        }

    }
}
    
