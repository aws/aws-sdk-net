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
    /// Describes a layer's load-based auto scaling configuration.
    /// </summary>
    public partial class LoadBasedAutoScalingConfiguration
    {
        private AutoScalingThresholds _downScaling;
        private bool? _enable;
        private string _layerId;
        private AutoScalingThresholds _upScaling;


        /// <summary>
        /// Gets and sets the property DownScaling. 
        /// <para>
        /// A <code>LoadBasedAutoscalingInstruction</code> object that describes the downscaling
        /// configuration, which          defines how and when AWS OpsWorks reduces the number
        /// of instances.
        /// </para>
        /// </summary>
        public AutoScalingThresholds DownScaling
        {
            get { return this._downScaling; }
            set { this._downScaling = value; }
        }


        /// <summary>
        /// Sets the DownScaling property
        /// </summary>
        /// <param name="downScaling">The value to set for the DownScaling property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LoadBasedAutoScalingConfiguration WithDownScaling(AutoScalingThresholds downScaling)
        {
            this._downScaling = downScaling;
            return this;
        }

        // Check to see if DownScaling property is set
        internal bool IsSetDownScaling()
        {
            return this._downScaling != null;
        }


        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// Whether load-based auto scaling is enabled for the layer.
        /// </para>
        /// </summary>
        public bool Enable
        {
            get { return this._enable.GetValueOrDefault(); }
            set { this._enable = value; }
        }


        /// <summary>
        /// Sets the Enable property
        /// </summary>
        /// <param name="enable">The value to set for the Enable property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LoadBasedAutoScalingConfiguration WithEnable(bool enable)
        {
            this._enable = enable;
            return this;
        }

        // Check to see if Enable property is set
        internal bool IsSetEnable()
        {
            return this._enable.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property LayerId. 
        /// <para>
        /// The layer ID.
        /// </para>
        /// </summary>
        public string LayerId
        {
            get { return this._layerId; }
            set { this._layerId = value; }
        }


        /// <summary>
        /// Sets the LayerId property
        /// </summary>
        /// <param name="layerId">The value to set for the LayerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LoadBasedAutoScalingConfiguration WithLayerId(string layerId)
        {
            this._layerId = layerId;
            return this;
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this._layerId != null;
        }


        /// <summary>
        /// Gets and sets the property UpScaling. 
        /// <para>
        /// A <code>LoadBasedAutoscalingInstruction</code> object that describes the upscaling
        /// configuration, which          defines how and when AWS OpsWorks increases the number
        /// of instances.
        /// </para>
        /// </summary>
        public AutoScalingThresholds UpScaling
        {
            get { return this._upScaling; }
            set { this._upScaling = value; }
        }


        /// <summary>
        /// Sets the UpScaling property
        /// </summary>
        /// <param name="upScaling">The value to set for the UpScaling property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LoadBasedAutoScalingConfiguration WithUpScaling(AutoScalingThresholds upScaling)
        {
            this._upScaling = upScaling;
            return this;
        }

        // Check to see if UpScaling property is set
        internal bool IsSetUpScaling()
        {
            return this._upScaling != null;
        }

    }
}