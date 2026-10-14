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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details on the Amazon EC2 Resource.
    /// </summary>
    public partial class EC2ResourceDetails
    {
        /// <summary>
        /// Gets and sets the property HourlyOnDemandRate. 
        /// <para>
        /// The hourly public On-Demand rate for the instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string HourlyOnDemandRate { get; set; }

        /// <summary>
        /// Checks to see if the HourlyOnDemandRate property is set.
        /// </summary>
        internal bool IsSetHourlyOnDemandRate() => this.HourlyOnDemandRate != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of Amazon Web Services instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The memory capacity of the Amazon Web Services instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory != null;

        /// <summary>
        /// Gets and sets the property NetworkPerformance. 
        /// <para>
        /// The network performance capacity of the Amazon Web Services instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NetworkPerformance { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPerformance property is set.
        /// </summary>
        internal bool IsSetNetworkPerformance() => this.NetworkPerformance != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the Amazon Web Services instance. The platform is the specific combination
        /// of operating system, license model, and software on an instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Sku. 
        /// <para>
        /// The SKU of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Sku { get; set; }

        /// <summary>
        /// Checks to see if the Sku property is set.
        /// </summary>
        internal bool IsSetSku() => this.Sku != null;

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The disk storage of the Amazon Web Services instance. This doesn't include EBS storage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Storage { get; set; }

        /// <summary>
        /// Checks to see if the Storage property is set.
        /// </summary>
        internal bool IsSetStorage() => this.Storage != null;

        /// <summary>
        /// Gets and sets the property Vcpu. 
        /// <para>
        /// The number of VCPU cores in the Amazon Web Services instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Vcpu { get; set; }

        /// <summary>
        /// Checks to see if the Vcpu property is set.
        /// </summary>
        internal bool IsSetVcpu() => this.Vcpu != null;
    }
}
