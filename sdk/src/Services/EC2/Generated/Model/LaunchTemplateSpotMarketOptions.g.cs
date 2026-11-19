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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The options for Spot Instances.
    /// </summary>
    public partial class LaunchTemplateSpotMarketOptions
    {
        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        /// The required duration for the Spot Instances (also known as Spot blocks), in minutes.
        /// This value must be a multiple of 60 (60, 120, 180, 240, 300, or 360).
        /// </para>
        /// </summary>
        public int? BlockDurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the BlockDurationMinutes property is set.
        /// </summary>
        internal bool IsSetBlockDurationMinutes() => this.BlockDurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// The behavior when a Spot Instance is interrupted.
        /// </para>
        /// </summary>
        public InstanceInterruptionBehavior InstanceInterruptionBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InstanceInterruptionBehavior property is set.
        /// </summary>
        internal bool IsSetInstanceInterruptionBehavior() => this.InstanceInterruptionBehavior != null;

        /// <summary>
        /// Gets and sets the property MaxPrice. 
        /// <para>
        /// The maximum hourly price you're willing to pay for a Spot Instance. We do not recommend
        /// using this parameter because it can lead to increased interruptions. If you do not
        /// specify this parameter, you will pay the current Spot price. If you do specify this
        /// parameter, it must be more than USD $0.001. Specifying a value below USD $0.001 will
        /// result in an <c>InvalidParameterValue</c> error message when the launch template is
        /// used to launch an instance.
        /// </para>
        /// </summary>
        public string MaxPrice { get; set; }

        /// <summary>
        /// Checks to see if the MaxPrice property is set.
        /// </summary>
        internal bool IsSetMaxPrice() => this.MaxPrice != null;

        /// <summary>
        /// Gets and sets the property SpotInstanceType. 
        /// <para>
        /// The Spot Instance request type.
        /// </para>
        /// </summary>
        public SpotInstanceType SpotInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the SpotInstanceType property is set.
        /// </summary>
        internal bool IsSetSpotInstanceType() => this.SpotInstanceType != null;

        /// <summary>
        /// Gets and sets the property ValidUntil. 
        /// <para>
        /// The end date of the request. For a one-time request, the request remains active until
        /// all instances launch, the request is canceled, or this date is reached. If the request
        /// is persistent, it remains active until it is canceled or this date and time is reached.
        /// </para>
        /// </summary>
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Checks to see if the ValidUntil property is set.
        /// </summary>
        internal bool IsSetValidUntil() => this.ValidUntil.HasValue;
    }
}
