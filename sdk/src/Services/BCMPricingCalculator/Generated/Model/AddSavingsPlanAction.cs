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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents an action to add a Savings Plan to a bill scenario.
    /// </summary>
    public partial class AddSavingsPlanAction
    {
        private double? _commitment;
        private string _savingsPlanOfferingId;

        /// <summary>
        /// Gets and sets the property Commitment. 
        /// <para>
        ///  The hourly commitment, in the same currency of the <c>savingsPlanOfferingId</c>.
        /// This is a value between 0.001 and 1 million. You cannot specify more than five digits
        /// after the decimal point. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000000)]
        public double? Commitment
        {
            get { return this._commitment; }
            set { this._commitment = value; }
        }

        // Check to see if Commitment property is set
        internal bool IsSetCommitment()
        {
            return this._commitment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanOfferingId. 
        /// <para>
        ///  The ID of the Savings Plan offering to add. For more information, see <a href="https://docs.aws.amazon.com/savingsplans/latest/APIReference/API_DescribeSavingsPlansOfferings.html">
        /// DescribeSavingsPlansOfferings</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SavingsPlanOfferingId
        {
            get { return this._savingsPlanOfferingId; }
            set { this._savingsPlanOfferingId = value; }
        }

        // Check to see if SavingsPlanOfferingId property is set
        internal bool IsSetSavingsPlanOfferingId()
        {
            return this._savingsPlanOfferingId != null;
        }

    }
}