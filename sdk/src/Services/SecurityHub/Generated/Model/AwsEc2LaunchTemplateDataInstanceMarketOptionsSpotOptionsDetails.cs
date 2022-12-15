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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about the market (purchasing) options for Spot Instances.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataInstanceMarketOptionsSpotOptionsDetails
    {
        private int? _blockDurationMinutes;
        private string _instanceInterruptionBehavior;
        private string _maxPrice;
        private string _spotInstanceType;
        private string _validUntil;

        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        ///  Deprecated. 
        /// </para>
        /// </summary>
        public int BlockDurationMinutes
        {
            get { return this._blockDurationMinutes.GetValueOrDefault(); }
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
        ///  The behavior when a Spot Instance is interrupted. 
        /// </para>
        /// </summary>
        public string InstanceInterruptionBehavior
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
        ///  The maximum hourly price you're willing to pay for the Spot Instances. 
        /// </para>
        /// </summary>
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
        ///  The Spot Instance request type. 
        /// </para>
        /// </summary>
        public string SpotInstanceType
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
        /// Gets and sets the property ValidUntil. 
        /// <para>
        ///  The end date of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ), for persistent
        /// requests. 
        /// </para>
        /// </summary>
        public string ValidUntil
        {
            get { return this._validUntil; }
            set { this._validUntil = value; }
        }

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this._validUntil != null;
        }

    }
}