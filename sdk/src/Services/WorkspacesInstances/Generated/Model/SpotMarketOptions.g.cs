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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines configuration for spot instance deployment.
    /// </summary>
    public partial class SpotMarketOptions
    {
        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        /// Duration of spot instance block reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? BlockDurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the BlockDurationMinutes property is set.
        /// </summary>
        internal bool IsSetBlockDurationMinutes() => this.BlockDurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// Specifies behavior when spot instance is interrupted.
        /// </para>
        /// </summary>
        public InstanceInterruptionBehaviorEnum InstanceInterruptionBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InstanceInterruptionBehavior property is set.
        /// </summary>
        internal bool IsSetInstanceInterruptionBehavior() => this.InstanceInterruptionBehavior != null;

        /// <summary>
        /// Gets and sets the property MaxPrice. 
        /// <para>
        /// Maximum hourly price for spot instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string MaxPrice { get; set; }

        /// <summary>
        /// Checks to see if the MaxPrice property is set.
        /// </summary>
        internal bool IsSetMaxPrice() => this.MaxPrice != null;

        /// <summary>
        /// Gets and sets the property SpotInstanceType. 
        /// <para>
        /// Defines the type of spot instance request.
        /// </para>
        /// </summary>
        public SpotInstanceTypeEnum SpotInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the SpotInstanceType property is set.
        /// </summary>
        internal bool IsSetSpotInstanceType() => this.SpotInstanceType != null;

        /// <summary>
        /// Gets and sets the property ValidUntilUtc. 
        /// <para>
        /// Timestamp until which spot instance request is valid.
        /// </para>
        /// </summary>
        public DateTime? ValidUntilUtc { get; set; }

        /// <summary>
        /// Checks to see if the ValidUntilUtc property is set.
        /// </summary>
        internal bool IsSetValidUntilUtc() => this.ValidUntilUtc.HasValue;
    }
}
