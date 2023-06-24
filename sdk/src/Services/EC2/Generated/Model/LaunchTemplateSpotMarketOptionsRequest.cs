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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The options for Spot Instances.
    /// </summary>
    public partial class LaunchTemplateSpotMarketOptionsRequest
    {
        private int? _blockDurationMinutes;
        private InstanceInterruptionBehavior _instanceInterruptionBehavior;
        private string _maxPrice;
        private SpotInstanceType _spotInstanceType;
        private DateTime? _validUntilUtc;

        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        /// Deprecated.
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
        /// The behavior when a Spot Instance is interrupted. The default is <code>terminate</code>.
        /// </para>
        /// </summary>
        public InstanceInterruptionBehavior InstanceInterruptionBehavior
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
        /// The maximum hourly price you're willing to pay for the Spot Instances. We do not recommend
        /// using this parameter because it can lead to increased interruptions. If you do not
        /// specify this parameter, you will pay the current Spot price.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a maximum price, your Spot Instances will be interrupted more frequently
        /// than if you do not specify this parameter.
        /// </para>
        ///  </important>
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
        /// The Spot Instance request type.
        /// </para>
        /// </summary>
        public SpotInstanceType SpotInstanceType
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
        /// The end date of the request, in UTC format (<i>YYYY-MM-DD</i>T<i>HH:MM:SS</i>Z). Supported
        /// only for persistent requests.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a persistent request, the request remains active until the <code>ValidUntil</code>
        /// date and time is reached. Otherwise, the request remains active until you cancel it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a one-time request, <code>ValidUntil</code> is not supported. The request remains
        /// active until all instances launch or you cancel the request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: 7 days from the current date
        /// </para>
        /// </summary>
        public DateTime ValidUntilUtc
        {
            get { return this._validUntilUtc.GetValueOrDefault(); }
            set { this._validUntil = this._validUntilUtc = value; }
        }

        // Check to see if ValidUntilUtc property is set
        internal bool IsSetValidUntilUtc()
        {
            return this._validUntilUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property ValidUntilUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ValidUntilUtc instead. Setting either ValidUntil or
        /// ValidUntilUtc results in both ValidUntil and ValidUntilUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. ValidUntil
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The end date of the request, in UTC format (<i>YYYY-MM-DD</i>T<i>HH:MM:SS</i>Z). Supported
        /// only for persistent requests.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a persistent request, the request remains active until the <code>ValidUntil</code>
        /// date and time is reached. Otherwise, the request remains active until you cancel it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a one-time request, <code>ValidUntil</code> is not supported. The request remains
        /// active until all instances launch or you cancel the request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: 7 days from the current date
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ValidUntilUtc instead. Setting either ValidUntil or ValidUntilUtc results in both ValidUntil and " +
            "ValidUntilUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. ValidUntil is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ValidUntil
        {
            get { return this._validUntil.GetValueOrDefault(); }
            set
            {
                this._validUntil = value;
                this._validUntilUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}