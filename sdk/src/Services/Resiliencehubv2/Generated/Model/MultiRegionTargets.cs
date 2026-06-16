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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Defines the multi-Region disaster recovery targets for a resilience policy.
    /// </summary>
    public partial class MultiRegionTargets
    {
        private MultiRegionDisasterRecoveryApproach _disasterRecoveryApproach;
        private int? _rpoInMinutes;
        private int? _rtoInMinutes;

        /// <summary>
        /// Gets and sets the property DisasterRecoveryApproach. 
        /// <para>
        /// The disaster recovery approach for multi-Region.
        /// </para>
        /// </summary>
        public MultiRegionDisasterRecoveryApproach DisasterRecoveryApproach
        {
            get { return this._disasterRecoveryApproach; }
            set { this._disasterRecoveryApproach = value; }
        }

        // Check to see if DisasterRecoveryApproach property is set
        internal bool IsSetDisasterRecoveryApproach()
        {
            return this._disasterRecoveryApproach != null;
        }

        /// <summary>
        /// Gets and sets the property RpoInMinutes. 
        /// <para>
        /// The recovery point objective (RPO) target for multi-Region, in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? RpoInMinutes
        {
            get { return this._rpoInMinutes; }
            set { this._rpoInMinutes = value; }
        }

        // Check to see if RpoInMinutes property is set
        internal bool IsSetRpoInMinutes()
        {
            return this._rpoInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RtoInMinutes. 
        /// <para>
        /// The recovery time objective (RTO) target for multi-Region, in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? RtoInMinutes
        {
            get { return this._rtoInMinutes; }
            set { this._rtoInMinutes = value; }
        }

        // Check to see if RtoInMinutes property is set
        internal bool IsSetRtoInMinutes()
        {
            return this._rtoInMinutes.HasValue; 
        }

    }
}