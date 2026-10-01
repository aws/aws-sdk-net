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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about the market (purchasing) options for Spot Instances.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataInstanceMarketOptionsSpotOptionsDetails
    {
        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        ///  Deprecated. 
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
        ///  The behavior when a Spot Instance is interrupted. 
        /// </para>
        /// </summary>
        public string InstanceInterruptionBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InstanceInterruptionBehavior property is set.
        /// </summary>
        internal bool IsSetInstanceInterruptionBehavior() => this.InstanceInterruptionBehavior != null;

        /// <summary>
        /// Gets and sets the property MaxPrice. 
        /// <para>
        ///  The maximum hourly price you're willing to pay for the Spot Instances. 
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
        ///  The Spot Instance request type. 
        /// </para>
        /// </summary>
        public string SpotInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the SpotInstanceType property is set.
        /// </summary>
        internal bool IsSetSpotInstanceType() => this.SpotInstanceType != null;

        /// <summary>
        /// Gets and sets the property ValidUntil. 
        /// <para>
        ///  The end date of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ), for persistent
        /// requests. 
        /// </para>
        /// </summary>
        public string ValidUntil { get; set; }

        /// <summary>
        /// Checks to see if the ValidUntil property is set.
        /// </summary>
        internal bool IsSetValidUntil() => this.ValidUntil != null;
    }
}
