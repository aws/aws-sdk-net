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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about an instance type that can be ordered for an Outpost, including hardware
    /// specifications and supported form factors.
    /// </summary>
    public partial class DetailedInstanceTypeItem
    {
        private List<FormFactorConfig> _formFactorConfigs = AWSConfigs.InitializeCollections ? new List<FormFactorConfig>() : null;
        private string _instanceType;
        private int? _memoryInMib;
        private string _networkPerformance;
        private int? _vcpUs;

        /// <summary>
        /// Gets and sets the property FormFactorConfigs. 
        /// <para>
        /// The supported form factor and Outpost generation configurations for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FormFactorConfig> FormFactorConfigs
        {
            get { return this._formFactorConfigs; }
            set { this._formFactorConfigs = value; }
        }

        // Check to see if FormFactorConfigs property is set
        internal bool IsSetFormFactorConfigs()
        {
            return this._formFactorConfigs != null && (this._formFactorConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryInMib. 
        /// <para>
        /// The memory size of the instance type, in MiB.
        /// </para>
        /// </summary>
        public int? MemoryInMib
        {
            get { return this._memoryInMib; }
            set { this._memoryInMib = value; }
        }

        // Check to see if MemoryInMib property is set
        internal bool IsSetMemoryInMib()
        {
            return this._memoryInMib.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkPerformance. 
        /// <para>
        /// The network performance of the instance type.
        /// </para>
        /// </summary>
        public string NetworkPerformance
        {
            get { return this._networkPerformance; }
            set { this._networkPerformance = value; }
        }

        // Check to see if NetworkPerformance property is set
        internal bool IsSetNetworkPerformance()
        {
            return this._networkPerformance != null;
        }

        /// <summary>
        /// Gets and sets the property VCPUs. 
        /// <para>
        /// The number of default VCPUs in the instance type.
        /// </para>
        /// </summary>
        public int? VCPUs
        {
            get { return this._vcpUs; }
            set { this._vcpUs = value; }
        }

        // Check to see if VCPUs property is set
        internal bool IsSetVCPUs()
        {
            return this._vcpUs.HasValue; 
        }

    }
}