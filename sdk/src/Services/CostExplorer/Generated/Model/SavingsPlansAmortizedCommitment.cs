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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
    /// The amortized amount of Savings Plans purchased in a specific account during a specific
    /// time interval.
    /// </summary>
    public partial class SavingsPlansAmortizedCommitment
    {
        private string _amortizedRecurringCommitment;
        private string _amortizedUpfrontCommitment;
        private string _totalAmortizedCommitment;

        /// <summary>
        /// Gets and sets the property AmortizedRecurringCommitment. 
        /// <para>
        /// The amortized amount of your Savings Plans commitment that was purchased with either
        /// a <c>Partial</c> or a <c>NoUpfront</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AmortizedRecurringCommitment
        {
            get { return this._amortizedRecurringCommitment; }
            set { this._amortizedRecurringCommitment = value; }
        }

        // Check to see if AmortizedRecurringCommitment property is set
        internal bool IsSetAmortizedRecurringCommitment()
        {
            return this._amortizedRecurringCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property AmortizedUpfrontCommitment. 
        /// <para>
        /// The amortized amount of your Savings Plans commitment that was purchased with an <c>Upfront</c>
        /// or <c>PartialUpfront</c> Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AmortizedUpfrontCommitment
        {
            get { return this._amortizedUpfrontCommitment; }
            set { this._amortizedUpfrontCommitment = value; }
        }

        // Check to see if AmortizedUpfrontCommitment property is set
        internal bool IsSetAmortizedUpfrontCommitment()
        {
            return this._amortizedUpfrontCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAmortizedCommitment. 
        /// <para>
        /// The total amortized amount of your Savings Plans commitment, regardless of your Savings
        /// Plans purchase method. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TotalAmortizedCommitment
        {
            get { return this._totalAmortizedCommitment; }
            set { this._totalAmortizedCommitment = value; }
        }

        // Check to see if TotalAmortizedCommitment property is set
        internal bool IsSetTotalAmortizedCommitment()
        {
            return this._totalAmortizedCommitment != null;
        }

    }
}