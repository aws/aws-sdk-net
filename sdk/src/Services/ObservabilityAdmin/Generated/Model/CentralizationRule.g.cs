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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Defines how telemetry data should be centralized across an Amazon Web Services Organization,
    /// including source and destination configurations.
    /// </summary>
    public partial class CentralizationRule
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Configuration determining where the telemetry data should be centralized, backed up,
        /// as well as encryption configuration for the primary and backup destinations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CentralizationRuleDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Configuration determining the source of the telemetry data to be centralized.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CentralizationRuleSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
