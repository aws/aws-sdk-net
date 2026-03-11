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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
        private AcceleratedRecoveryStatus _acceleratedRecoveryStatus;
        private HostedZoneFailureReasons _failureReasons;

        /// <summary>
        /// Gets and sets the property AcceleratedRecoveryStatus. 
        /// <para>
        /// The current status of accelerated recovery for the hosted zone.
        /// </para>
        /// </summary>
        public AcceleratedRecoveryStatus AcceleratedRecoveryStatus
        {
            get { return this._acceleratedRecoveryStatus; }
            set { this._acceleratedRecoveryStatus = value; }
        }

        // Check to see if AcceleratedRecoveryStatus property is set
        internal bool IsSetAcceleratedRecoveryStatus()
        {
            return this._acceleratedRecoveryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// Information about any failures that occurred when attempting to enable or configure
        /// features for the hosted zone.
        /// </para>
        /// </summary>
        public HostedZoneFailureReasons FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null;
        }

    }
}