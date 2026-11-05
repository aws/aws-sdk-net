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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCapacityProvider operation. Updates the
    /// configuration of an existing capacity provider.
    /// </summary>
    public partial class UpdateCapacityProviderRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderName. 
        /// <para>
        /// The name of the capacity provider to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string CapacityProviderName { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderName property is set.
        /// </summary>
        internal bool IsSetCapacityProviderName() => this.CapacityProviderName != null;

        /// <summary>
        /// Gets and sets the property CapacityProviderScalingConfig. 
        /// <para>
        /// The updated scaling configuration for the capacity provider.
        /// </para>
        /// </summary>
        public CapacityProviderScalingConfig CapacityProviderScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderScalingConfig property is set.
        /// </summary>
        internal bool IsSetCapacityProviderScalingConfig() => this.CapacityProviderScalingConfig != null;

        /// <summary>
        /// Gets and sets the property PropagateTags.
        /// </summary>
        public PropagateTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;

        /// <summary>
        /// Gets and sets the property TelemetryConfig. 
        /// <para>
        /// The updated telemetry configuration for the capacity provider.
        /// </para>
        /// </summary>
        public CapacityProviderTelemetryConfig TelemetryConfig { get; set; }

        /// <summary>
        /// Checks to see if the TelemetryConfig property is set.
        /// </summary>
        internal bool IsSetTelemetryConfig() => this.TelemetryConfig != null;
    }
}
