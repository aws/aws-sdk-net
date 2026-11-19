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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an entry in a transit gateway metering policy.
    /// </summary>
    public partial class TransitGatewayMeteringPolicyEntry
    {
        /// <summary>
        /// Gets and sets the property MeteredAccount. 
        /// <para>
        /// The Amazon Web Services account ID to which the metered traffic is attributed.
        /// </para>
        /// </summary>
        public TransitGatewayMeteringPayerType MeteredAccount { get; set; }

        /// <summary>
        /// Checks to see if the MeteredAccount property is set.
        /// </summary>
        internal bool IsSetMeteredAccount() => this.MeteredAccount != null;

        /// <summary>
        /// Gets and sets the property MeteringPolicyRule. 
        /// <para>
        /// The metering policy rule that defines traffic matching criteria.
        /// </para>
        /// </summary>
        public TransitGatewayMeteringPolicyRule MeteringPolicyRule { get; set; }

        /// <summary>
        /// Checks to see if the MeteringPolicyRule property is set.
        /// </summary>
        internal bool IsSetMeteringPolicyRule() => this.MeteringPolicyRule != null;

        /// <summary>
        /// Gets and sets the property PolicyRuleNumber. 
        /// <para>
        /// The rule number of the metering policy entry.
        /// </para>
        /// </summary>
        public string PolicyRuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRuleNumber property is set.
        /// </summary>
        internal bool IsSetPolicyRuleNumber() => this.PolicyRuleNumber != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the metering policy entry.
        /// </para>
        /// </summary>
        public TransitGatewayMeteringPolicyEntryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdateEffectiveAt. 
        /// <para>
        /// The date and time when the metering policy entry update becomes effective.
        /// </para>
        /// </summary>
        public DateTime? UpdateEffectiveAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdateEffectiveAt property is set.
        /// </summary>
        internal bool IsSetUpdateEffectiveAt() => this.UpdateEffectiveAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the metering policy entry was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
