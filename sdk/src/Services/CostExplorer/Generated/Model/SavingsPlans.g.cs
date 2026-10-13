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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The Savings Plans commitment details.
    /// </summary>
    public partial class SavingsPlans
    {
        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family of the Savings Plans commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string InstanceFamily { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFamily property is set.
        /// </summary>
        internal bool IsSetInstanceFamily() => this.InstanceFamily != null;

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The unique ID that's used to distinguish Savings Plans commitments from one another.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OfferingId { get; set; }

        /// <summary>
        /// Checks to see if the OfferingId property is set.
        /// </summary>
        internal bool IsSetOfferingId() => this.OfferingId != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option for the Savings Plans commitment.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region associated with the Savings Plans commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansCommitment. 
        /// <para>
        /// The Savings Plans commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 5000)]
        public double? SavingsPlansCommitment { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansCommitment property is set.
        /// </summary>
        internal bool IsSetSavingsPlansCommitment() => this.SavingsPlansCommitment.HasValue;

        /// <summary>
        /// Gets and sets the property SavingsPlansType. 
        /// <para>
        /// The Savings Plans type.
        /// </para>
        /// </summary>
        public SupportedSavingsPlansType SavingsPlansType { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansType property is set.
        /// </summary>
        internal bool IsSetSavingsPlansType() => this.SavingsPlansType != null;

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The term that you want the Savings Plans commitment for.
        /// </para>
        /// </summary>
        public TermInYears TermInYears { get; set; }

        /// <summary>
        /// Checks to see if the TermInYears property is set.
        /// </summary>
        internal bool IsSetTermInYears() => this.TermInYears != null;
    }
}
