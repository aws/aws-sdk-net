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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Provides information about the reason for the current status of a device.
    /// </summary>
    public partial class DeviceStatusReason
    {
        /// <summary>
        /// Gets and sets the property EstimatedEndAt. 
        /// <para>
        /// The estimated time at which the current status reason will end.
        /// </para>
        /// </summary>
        public DateTime? EstimatedEndAt { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedEndAt property is set.
        /// </summary>
        internal bool IsSetEstimatedEndAt() => this.EstimatedEndAt.HasValue;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason code for the current status of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeviceStatusReasonCode Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time at which the device status reason started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time of the most recent update to the device status reason.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
