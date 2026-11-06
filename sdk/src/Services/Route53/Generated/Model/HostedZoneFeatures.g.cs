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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Represents the features configuration for a hosted zone, including the status of various
    /// features and any associated failure reasons.
    /// </summary>
    public partial class HostedZoneFeatures
    {
        /// <summary>
        /// Gets and sets the property AcceleratedRecoveryStatus. 
        /// <para>
        /// The current status of accelerated recovery for the hosted zone.
        /// </para>
        /// </summary>
        public AcceleratedRecoveryStatus AcceleratedRecoveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratedRecoveryStatus property is set.
        /// </summary>
        internal bool IsSetAcceleratedRecoveryStatus() => this.AcceleratedRecoveryStatus != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// Information about any failures that occurred when attempting to enable or configure
        /// features for the hosted zone.
        /// </para>
        /// </summary>
        public HostedZoneFailureReasons FailureReasons { get; set; }

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null;
    }
}
