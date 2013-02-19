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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes a layer's load-based auto scaling configuration.</para>
    /// </summary>
    public class LoadBasedAutoScalingConfiguration
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
        public LoadBasedAutoScalingConfiguration WithLayerId(string layerId)
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
        /// Whether load-based auto scaling is enabled for the layer.
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
        public LoadBasedAutoScalingConfiguration WithEnable(bool enable)
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
        /// A <c>LoadBasedAutoscalingInstruction</c> object that describes the upscaling configuration, which defines how and when OpsWorks increases
        /// the number of instances.
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
        public LoadBasedAutoScalingConfiguration WithUpScaling(AutoScalingThresholds upScaling)
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
        /// A <c>LoadBasedAutoscalingInstruction</c> object that describes the downscaling configuration, which defines how and when OpsWorks reduces
        /// the number of instances.
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
        public LoadBasedAutoScalingConfiguration WithDownScaling(AutoScalingThresholds downScaling)
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
