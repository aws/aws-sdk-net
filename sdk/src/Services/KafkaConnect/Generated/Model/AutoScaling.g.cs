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
    /// Specifies how the connector scales.
    /// </summary>
    public partial class AutoScaling
    {
        /// <summary>
        /// Gets and sets the property MaxAutoscalingTaskCount. 
        /// <para>
        /// The maximum number of tasks allocated to the connector during autoscaling operations.
        /// Must be at least equal to maxWorkerCount.
        /// </para>
        /// </summary>
        public int? MaxAutoscalingTaskCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxAutoscalingTaskCount property is set.
        /// </summary>
        internal bool IsSetMaxAutoscalingTaskCount() => this.MaxAutoscalingTaskCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. 
        /// <para>
        /// The maximum number of workers allocated to the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxWorkerCount property is set.
        /// </summary>
        internal bool IsSetMaxWorkerCount() => this.MaxWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property McuCount. 
        /// <para>
        /// The number of microcontroller units (MCUs) allocated to each connector worker. The
        /// valid values are 1,2,4,8.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public int? McuCount { get; set; }

        /// <summary>
        /// Checks to see if the McuCount property is set.
        /// </summary>
        internal bool IsSetMcuCount() => this.McuCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinWorkerCount. 
        /// <para>
        /// The minimum number of workers allocated to the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the MinWorkerCount property is set.
        /// </summary>
        internal bool IsSetMinWorkerCount() => this.MinWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property ScaleInPolicy. 
        /// <para>
        /// The scale-in policy for the connector.
        /// </para>
        /// </summary>
        public ScaleInPolicy ScaleInPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ScaleInPolicy property is set.
        /// </summary>
        internal bool IsSetScaleInPolicy() => this.ScaleInPolicy != null;

        /// <summary>
        /// Gets and sets the property ScaleOutPolicy. 
        /// <para>
        /// The scale-out policy for the connector.
        /// </para>
        /// </summary>
        public ScaleOutPolicy ScaleOutPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ScaleOutPolicy property is set.
        /// </summary>
        internal bool IsSetScaleOutPolicy() => this.ScaleOutPolicy != null;
    }
}
