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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the neuron accelerators for the instance type.
    /// </summary>
    public partial class NeuronInfo
    {
        private List<NeuronDeviceInfo> _neuronDevices = AWSConfigs.InitializeCollections ? new List<NeuronDeviceInfo>() : null;
        private int? _totalNeuronDeviceMemoryInMiB;

        /// <summary>
        /// Gets and sets the property NeuronDevices. 
        /// <para>
        /// Describes the neuron accelerators for the instance type.
        /// </para>
        /// </summary>
        public List<NeuronDeviceInfo> NeuronDevices
        {
            get { return this._neuronDevices; }
            set { this._neuronDevices = value; }
        }

        // Check to see if NeuronDevices property is set
        internal bool IsSetNeuronDevices()
        {
            return this._neuronDevices != null && (this._neuronDevices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalNeuronDeviceMemoryInMiB. 
        /// <para>
        /// The total size of the memory for the neuron accelerators for the instance type, in
        /// MiB.
        /// </para>
        /// </summary>
        public int TotalNeuronDeviceMemoryInMiB
        {
            get { return this._totalNeuronDeviceMemoryInMiB.GetValueOrDefault(); }
            set { this._totalNeuronDeviceMemoryInMiB = value; }
        }

        // Check to see if TotalNeuronDeviceMemoryInMiB property is set
        internal bool IsSetTotalNeuronDeviceMemoryInMiB()
        {
            return this._totalNeuronDeviceMemoryInMiB.HasValue; 
        }

    }
}