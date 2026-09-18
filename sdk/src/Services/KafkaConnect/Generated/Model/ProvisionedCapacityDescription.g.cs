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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// The description of a connector's provisioned capacity.
    /// </summary>
    public partial class ProvisionedCapacityDescription
    {
        /// <summary>
        /// Gets and sets the property McuCount. 
        /// <para>
        /// The number of microcontroller units (MCUs) allocated to each connector worker. The
        /// valid values are 1,2,4,8.
        /// </para>
        /// </summary>
        public int? McuCount { get; set; }

        /// <summary>
        /// Checks to see if the McuCount property is set.
        /// </summary>
        internal bool IsSetMcuCount() => this.McuCount.HasValue;

        /// <summary>
        /// Gets and sets the property WorkerCount. 
        /// <para>
        /// The number of workers that are allocated to the connector.
        /// </para>
        /// </summary>
        public int? WorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the WorkerCount property is set.
        /// </summary>
        internal bool IsSetWorkerCount() => this.WorkerCount.HasValue;
    }
}
