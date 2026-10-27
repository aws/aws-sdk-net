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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Details on an Elastic Inference accelerator. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-inference.html">Working
    /// with Amazon Elastic Inference on Amazon ECS</a> in the <i>Amazon Elastic Container
    /// Service Developer Guide</i>.
    /// </summary>
    [Obsolete("This feature is no longer available.")]
    public partial class InferenceAccelerator
    {
        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The Elastic Inference accelerator device name. The <c>deviceName</c> must also be
        /// referenced in a container definition as a <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ResourceRequirement.html">ResourceRequirement</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The Elastic Inference accelerator type to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeviceType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceType property is set.
        /// </summary>
        internal bool IsSetDeviceType() => this.DeviceType != null;
    }
}
