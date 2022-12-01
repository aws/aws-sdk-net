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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Details on an Elastic Inference accelerator task override. This parameter is used
    /// to override the Elastic Inference accelerator specified in the task definition. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/userguide/ecs-inference.html">Working
    /// with Amazon Elastic Inference on Amazon ECS</a> in the <i>Amazon Elastic Container
    /// Service Developer Guide</i>.
    /// </summary>
    public partial class EcsInferenceAcceleratorOverride
    {
        private string _deviceName;
        private string _deviceType;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The Elastic Inference accelerator device name to override for the task. This parameter
        /// must match a <code>deviceName</code> specified in the task definition.
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The Elastic Inference accelerator type to use.
        /// </para>
        /// </summary>
        public string DeviceType
        {
            get { return this._deviceType; }
            set { this._deviceType = value; }
        }

        // Check to see if DeviceType property is set
        internal bool IsSetDeviceType()
        {
            return this._deviceType != null;
        }

    }
}