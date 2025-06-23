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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
        private int? _blockDurationMinutes;
        private InstanceInterruptionBehaviorEnum _instanceInterruptionBehavior;
        private string _maxPrice;
        private SpotInstanceTypeEnum _spotInstanceType;
        private DateTime? _validUntilUtc;

        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        /// Duration of spot instance block reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? BlockDurationMinutes
        {
            get { return this._blockDurationMinutes; }
            set { this._blockDurationMinutes = value; }
        }

        // Check to see if BlockDurationMinutes property is set
        internal bool IsSetBlockDurationMinutes()
        {
            return this._blockDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// Specifies behavior when spot instance is interrupted.
        /// </para>
        /// </summary>
        public InstanceInterruptionBehaviorEnum InstanceInterruptionBehavior
        {
            get { return this._instanceInterruptionBehavior; }
            set { this._instanceInterruptionBehavior = value; }
        }

        // Check to see if InstanceInterruptionBehavior property is set
        internal bool IsSetInstanceInterruptionBehavior()
        {
            return this._instanceInterruptionBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property MaxPrice. 
        /// <para>
        /// Maximum hourly price for spot instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string MaxPrice
        {
            get { return this._maxPrice; }
            set { this._maxPrice = value; }
        }

        // Check to see if MaxPrice property is set
        internal bool IsSetMaxPrice()
        {
            return this._maxPrice != null;
        }

        /// <summary>
        /// Gets and sets the property SpotInstanceType. 
        /// <para>
        /// Defines the type of spot instance request.
        /// </para>
        /// </summary>
        public SpotInstanceTypeEnum SpotInstanceType
        {
            get { return this._spotInstanceType; }
            set { this._spotInstanceType = value; }
        }

        // Check to see if SpotInstanceType property is set
        internal bool IsSetSpotInstanceType()
        {
            return this._spotInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ValidUntilUtc. 
        /// <para>
        /// Timestamp until which spot instance request is valid.
        /// </para>
        /// </summary>
        public DateTime? ValidUntilUtc
        {
            get { return this._validUntilUtc; }
            set { this._validUntilUtc = value; }
        }

        // Check to see if ValidUntilUtc property is set
        internal bool IsSetValidUntilUtc()
        {
            return this._validUntilUtc.HasValue; 
        }

    }
}