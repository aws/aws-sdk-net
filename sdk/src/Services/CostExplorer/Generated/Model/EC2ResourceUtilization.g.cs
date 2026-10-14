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
    /// Utilization metrics for the instance.
    /// </summary>
    public partial class EC2ResourceUtilization
    {
        /// <summary>
        /// Gets and sets the property DiskResourceUtilization. 
        /// <para>
        /// The field that contains a list of disk (local storage) metrics that are associated
        /// with the current instance. 
        /// </para>
        /// </summary>
        public DiskResourceUtilization DiskResourceUtilization { get; set; }

        /// <summary>
        /// Checks to see if the DiskResourceUtilization property is set.
        /// </summary>
        internal bool IsSetDiskResourceUtilization() => this.DiskResourceUtilization != null;

        /// <summary>
        /// Gets and sets the property EBSResourceUtilization. 
        /// <para>
        /// The EBS field that contains a list of EBS metrics that are associated with the current
        /// instance. 
        /// </para>
        /// </summary>
        public EBSResourceUtilization EBSResourceUtilization { get; set; }

        /// <summary>
        /// Checks to see if the EBSResourceUtilization property is set.
        /// </summary>
        internal bool IsSetEBSResourceUtilization() => this.EBSResourceUtilization != null;

        /// <summary>
        /// Gets and sets the property MaxCpuUtilizationPercentage. 
        /// <para>
        /// The maximum observed or expected CPU utilization of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MaxCpuUtilizationPercentage { get; set; }

        /// <summary>
        /// Checks to see if the MaxCpuUtilizationPercentage property is set.
        /// </summary>
        internal bool IsSetMaxCpuUtilizationPercentage() => this.MaxCpuUtilizationPercentage != null;

        /// <summary>
        /// Gets and sets the property MaxMemoryUtilizationPercentage. 
        /// <para>
        /// The maximum observed or expected memory utilization of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MaxMemoryUtilizationPercentage { get; set; }

        /// <summary>
        /// Checks to see if the MaxMemoryUtilizationPercentage property is set.
        /// </summary>
        internal bool IsSetMaxMemoryUtilizationPercentage() => this.MaxMemoryUtilizationPercentage != null;

        /// <summary>
        /// Gets and sets the property MaxStorageUtilizationPercentage. 
        /// <para>
        /// The maximum observed or expected storage utilization of the instance. This doesn't
        /// include EBS storage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MaxStorageUtilizationPercentage { get; set; }

        /// <summary>
        /// Checks to see if the MaxStorageUtilizationPercentage property is set.
        /// </summary>
        internal bool IsSetMaxStorageUtilizationPercentage() => this.MaxStorageUtilizationPercentage != null;

        /// <summary>
        /// Gets and sets the property NetworkResourceUtilization. 
        /// <para>
        /// The network field that contains a list of network metrics that are associated with
        /// the current instance. 
        /// </para>
        /// </summary>
        public NetworkResourceUtilization NetworkResourceUtilization { get; set; }

        /// <summary>
        /// Checks to see if the NetworkResourceUtilization property is set.
        /// </summary>
        internal bool IsSetNetworkResourceUtilization() => this.NetworkResourceUtilization != null;
    }
}
