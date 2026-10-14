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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The EC2 instance Savings Plans configuration used for recommendations.
    /// </summary>
    public partial class Ec2InstanceSavingsPlansConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope for which you want recommendations.
        /// </para>
        /// </summary>
        public string AccountScope { get; set; }

        /// <summary>
        /// Checks to see if the AccountScope property is set.
        /// </summary>
        internal bool IsSetAccountScope() => this.AccountScope != null;

        /// <summary>
        /// Gets and sets the property HourlyCommitment. 
        /// <para>
        /// The hourly commitment for the Savings Plans type.
        /// </para>
        /// </summary>
        public string HourlyCommitment { get; set; }

        /// <summary>
        /// Checks to see if the HourlyCommitment property is set.
        /// </summary>
        internal bool IsSetHourlyCommitment() => this.HourlyCommitment != null;

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family of the recommended Savings Plans.
        /// </para>
        /// </summary>
        public string InstanceFamily { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFamily property is set.
        /// </summary>
        internal bool IsSetInstanceFamily() => this.InstanceFamily != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option for the commitment.
        /// </para>
        /// </summary>
        public string PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansRegion. 
        /// <para>
        /// The Amazon Web Services Region of the commitment.
        /// </para>
        /// </summary>
        public string SavingsPlansRegion { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansRegion property is set.
        /// </summary>
        internal bool IsSetSavingsPlansRegion() => this.SavingsPlansRegion != null;

        /// <summary>
        /// Gets and sets the property Term. 
        /// <para>
        /// The Savings Plans recommendation term in years.
        /// </para>
        /// </summary>
        public string Term { get; set; }

        /// <summary>
        /// Checks to see if the Term property is set.
        /// </summary>
        internal bool IsSetTerm() => this.Term != null;
    }
}
