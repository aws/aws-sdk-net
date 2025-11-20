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
    /// Describes an entry in a transit gateway metering policy.
    /// </summary>
    public partial class TransitGatewayMeteringPolicyEntry
    {
        private TransitGatewayMeteringPayerType _meteredAccount;
        private TransitGatewayMeteringPolicyRule _meteringPolicyRule;
        private string _policyRuleNumber;
        private TransitGatewayMeteringPolicyEntryState _state;
        private DateTime? _updatedAt;
        private DateTime? _updateEffectiveAt;

        /// <summary>
        /// Gets and sets the property MeteredAccount. 
        /// <para>
        /// The Amazon Web Services account ID to which the metered traffic is attributed.
        /// </para>
        /// </summary>
        public TransitGatewayMeteringPayerType MeteredAccount
        {
            get { return this._meteredAccount; }
            set { this._meteredAccount = value; }
        }

        // Check to see if MeteredAccount property is set
        internal bool IsSetMeteredAccount()
        {
            return this._meteredAccount != null;
        }

        /// <summary>
        /// Gets and sets the property MeteringPolicyRule. 
        /// <para>
        /// The metering policy rule that defines traffic matching criteria.
        /// </para>
        /// </summary>
        public TransitGatewayMeteringPolicyRule MeteringPolicyRule
        {
            get { return this._meteringPolicyRule; }
            set { this._meteringPolicyRule = value; }
        }

        // Check to see if MeteringPolicyRule property is set
        internal bool IsSetMeteringPolicyRule()
        {
            return this._meteringPolicyRule != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyRuleNumber. 
        /// <para>
        /// The rule number of the metering policy entry.
        /// </para>
        /// </summary>
        public string PolicyRuleNumber
        {
            get { return this._policyRuleNumber; }
            set { this._policyRuleNumber = value; }
        }

        // Check to see if PolicyRuleNumber property is set
        internal bool IsSetPolicyRuleNumber()
        {
            return this._policyRuleNumber != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the metering policy entry.
        /// </para>
        /// </summary>
        public TransitGatewayMeteringPolicyEntryState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the metering policy entry was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateEffectiveAt. 
        /// <para>
        /// The date and time when the metering policy entry update becomes effective.
        /// </para>
        /// </summary>
        public DateTime UpdateEffectiveAt
        {
            get { return this._updateEffectiveAt.GetValueOrDefault(); }
            set { this._updateEffectiveAt = value; }
        }

        // Check to see if UpdateEffectiveAt property is set
        internal bool IsSetUpdateEffectiveAt()
        {
            return this._updateEffectiveAt.HasValue; 
        }

    }
}