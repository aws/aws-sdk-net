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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of UltraServer resources and their current status.
    /// </summary>
    public partial class UltraServerSummary
    {
        /// <summary>
        /// Gets and sets the property AvailableSpareInstanceCount. 
        /// <para>
        /// The number of available spare instances in the UltraServers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AvailableSpareInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableSpareInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableSpareInstanceCount() => this.AvailableSpareInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type used in the UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReservedCapacityInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property UltraServerCount. 
        /// <para>
        /// The number of UltraServers of this type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? UltraServerCount { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerCount property is set.
        /// </summary>
        internal bool IsSetUltraServerCount() => this.UltraServerCount.HasValue;

        /// <summary>
        /// Gets and sets the property UltraServerType. 
        /// <para>
        /// The type of UltraServer, such as ml.u-p6e-gb200x72.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UltraServerType { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerType property is set.
        /// </summary>
        internal bool IsSetUltraServerType() => this.UltraServerType != null;

        /// <summary>
        /// Gets and sets the property UnhealthyInstanceCount. 
        /// <para>
        /// The total number of instances across all UltraServers of this type that are currently
        /// in an unhealthy state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? UnhealthyInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyInstanceCount property is set.
        /// </summary>
        internal bool IsSetUnhealthyInstanceCount() => this.UnhealthyInstanceCount.HasValue;
    }
}
