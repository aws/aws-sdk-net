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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The options for Spot Instances.
    /// </summary>
    public partial class SpotMarketOptions
    {
        private int? _blockDurationMinutes;
        private InstanceInterruptionBehavior _instanceInterruptionBehavior;
        private string _maxPrice;
        private SpotInstanceType _spotInstanceType;
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
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
        /// The behavior when a Spot Instance is interrupted.
        /// </para>
        ///  
        /// <para>
        /// If <c>Configured</c> (for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_HibernationOptionsRequest.html">
        /// <c>HibernationOptions</c> </a>) is set to <c>true</c>, the <c>InstanceInterruptionBehavior</c>
        /// parameter is automatically set to <c>hibernate</c>. If you set it to <c>stop</c> or
        /// <c>terminate</c>, you'll get an error.
        /// </para>
        ///  
        /// <para>
        /// If <c>Configured</c> (for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_HibernationOptionsRequest.html">
        /// <c>HibernationOptions</c> </a>) is set to <c>false</c> or <c>null</c>, the <c>InstanceInterruptionBehavior</c>
        /// parameter is automatically set to <c>terminate</c>. You can also set it to <c>stop</c>
        /// or <c>hibernate</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/interruption-behavior.html">Interruption
        /// behavior</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// The maximum hourly price that you're willing to pay for a Spot Instance. We do not
        /// recommend using this parameter because it can lead to increased interruptions. If
        /// you do not specify this parameter, you will pay the current Spot price.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a maximum price, your Spot Instances will be interrupted more frequently
        /// than if you do not specify this parameter.
        /// </para>
        ///  
        /// <para>
        /// If you specify a maximum price, it must be more than USD $0.001. Specifying a value
        /// below USD $0.001 will result in an <c>InvalidParameterValue</c> error message.
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
        /// The Spot Instance request type. For <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances">RunInstances</a>,
        /// persistent Spot Instance requests are only supported when the instance interruption
        /// behavior is either <c>hibernate</c> or <c>stop</c>.
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
        /// Gets and sets the property ValidUntil. 
        /// <para>
        /// The end date of the request, in UTC format (<i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// Supported only for persistent requests.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a persistent request, the request remains active until the <c>ValidUntil</c> date
        /// and time is reached. Otherwise, the request remains active until you cancel it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a one-time request, <c>ValidUntil</c> is not supported. The request remains active
        /// until all instances launch or you cancel the request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return this._validUntil; }
            set { this._validUntil = value; }
        }

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this._validUntil.HasValue; 
        }

    }
}