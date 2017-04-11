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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
        /// An <code>AutoScalingThresholds</code> object that describes the downscaling configuration,
        /// which defines how and when AWS OpsWorks Stacks reduces the number of instances.
        /// </para>
        /// </summary>
        public AutoScalingThresholds DownScaling
        {
            get { return this._downScaling; }
            set { this._downScaling = value; }
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

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this._layerId != null;
        }

        /// <summary>
        /// Gets and sets the property UpScaling. 
        /// <para>
        /// An <code>AutoScalingThresholds</code> object that describes the upscaling configuration,
        /// which defines how and when AWS OpsWorks Stacks increases the number of instances.
        /// </para>
        /// </summary>
        public AutoScalingThresholds UpScaling
        {
            get { return this._upScaling; }
            set { this._upScaling = value; }
        }

        // Check to see if UpScaling property is set
        internal bool IsSetUpScaling()
        {
            return this._upScaling != null;
        }

    }
}