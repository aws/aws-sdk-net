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
    /// <para>Specify the load-based auto scaling configuration for a specified layer.</para> <para><b>NOTE:</b>To use load-based auto scaling, you
    /// must create a set of load-based auto scaling instances. Load-based auto scaling operates only on the instances from that set, so you must
    /// ensure that you have created enough instances to handle the maximum anticipated load.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.SetLoadBasedAutoScaling"/>
    public class SetLoadBasedAutoScalingRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the LayerId property
        /// </summary>
        /// <param name="layerId">The value to set for the LayerId property </param>
        /// <returns>this instance</returns>
        public SetLoadBasedAutoScalingRequest WithLayerId(string layerId)
        {
            this.layerId = layerId;
            return this;
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

        /// <summary>
        /// Sets the Enable property
        /// </summary>
        /// <param name="enable">The value to set for the Enable property </param>
        /// <returns>this instance</returns>
        public SetLoadBasedAutoScalingRequest WithEnable(bool enable)
        {
            this.enable = enable;
            return this;
        }
            

        // Check to see if Enable property is set
        internal bool IsSetEnable()
        {
            return this.enable.HasValue;
        }

        /// <summary>
        /// An <c>AutoScalingThresholds</c> object with the upscaling threshold configuration. If the load exceeds these thresholds for a specified
        /// amount of time, OpsWorks starts a specified number of instances.
        ///  
        /// </summary>
        public AutoScalingThresholds UpScaling
        {
            get { return this.upScaling; }
            set { this.upScaling = value; }
        }

        /// <summary>
        /// Sets the UpScaling property
        /// </summary>
        /// <param name="upScaling">The value to set for the UpScaling property </param>
        /// <returns>this instance</returns>
        public SetLoadBasedAutoScalingRequest WithUpScaling(AutoScalingThresholds upScaling)
        {
            this.upScaling = upScaling;
            return this;
        }
            

        // Check to see if UpScaling property is set
        internal bool IsSetUpScaling()
        {
            return this.upScaling != null;
        }

        /// <summary>
        /// An <c>AutoScalingThresholds</c> object with the downscaling threshold configuration. If the load falls below these thresholds for a
        /// specified amount of time, OpsWorks stops a specified number of instances.
        ///  
        /// </summary>
        public AutoScalingThresholds DownScaling
        {
            get { return this.downScaling; }
            set { this.downScaling = value; }
        }

        /// <summary>
        /// Sets the DownScaling property
        /// </summary>
        /// <param name="downScaling">The value to set for the DownScaling property </param>
        /// <returns>this instance</returns>
        public SetLoadBasedAutoScalingRequest WithDownScaling(AutoScalingThresholds downScaling)
        {
            this.downScaling = downScaling;
            return this;
        }
            

        // Check to see if DownScaling property is set
        internal bool IsSetDownScaling()
        {
            return this.downScaling != null;
        }
    }
}
    
