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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details on the Amazon EC2 Resource.
    /// </summary>
    public partial class EC2ResourceDetails
    {
        private string _hourlyOnDemandRate;
        private string _instanceType;
        private string _memory;
        private string _networkPerformance;
        private string _platform;
        private string _region;
        private string _sku;
        private string _storage;
        private string _vcpu;

        /// <summary>
        /// Gets and sets the property HourlyOnDemandRate. 
        /// <para>
        /// The hourly public On-Demand rate for the instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string HourlyOnDemandRate
        {
            get { return this._hourlyOnDemandRate; }
            set { this._hourlyOnDemandRate = value; }
        }

        // Check to see if HourlyOnDemandRate property is set
        internal bool IsSetHourlyOnDemandRate()
        {
            return this._hourlyOnDemandRate != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of Amazon Web Services instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Memory. 
        /// <para>
        /// The memory capacity of the Amazon Web Services instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkPerformance. 
        /// <para>
        /// The network performance capacity of the Amazon Web Services instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the Amazon Web Services instance. The platform is the specific combination
        /// of operating system, license model, and software on an instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Sku. 
        /// <para>
        /// The SKU of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }

        // Check to see if Sku property is set
        internal bool IsSetSku()
        {
            return this._sku != null;
        }

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The disk storage of the Amazon Web Services instance. This doesn't include EBS storage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null;
        }

        /// <summary>
        /// Gets and sets the property Vcpu. 
        /// <para>
        /// The number of VCPU cores in the Amazon Web Services instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Vcpu
        {
            get { return this._vcpu; }
            set { this._vcpu = value; }
        }

        // Check to see if Vcpu property is set
        internal bool IsSetVcpu()
        {
            return this._vcpu != null;
        }

    }
}