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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A summary report of actual Amazon Web Services charges and calculated Amazon Web Services
    /// charges, based on the associated pricing plan of a billing group.
    /// </summary>
    public partial class BillingGroupCostReportElement
    {
        /// <summary>
        /// Gets and sets the property AWSCost. 
        /// <para>
        /// The actual Amazon Web Services charges for the billing group.
        /// </para>
        /// </summary>
        public string AWSCost { get; set; }

        /// <summary>
        /// Checks to see if the AWSCost property is set.
        /// </summary>
        internal bool IsSetAWSCost() => this.AWSCost != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a billing group.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The displayed currency.
        /// </para>
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property Margin. 
        /// <para>
        /// The billing group margin.
        /// </para>
        /// </summary>
        public string Margin { get; set; }

        /// <summary>
        /// Checks to see if the Margin property is set.
        /// </summary>
        internal bool IsSetMargin() => this.Margin != null;

        /// <summary>
        /// Gets and sets the property MarginPercentage. 
        /// <para>
        /// The percentage of billing group margin.
        /// </para>
        /// </summary>
        public string MarginPercentage { get; set; }

        /// <summary>
        /// Checks to see if the MarginPercentage property is set.
        /// </summary>
        internal bool IsSetMarginPercentage() => this.MarginPercentage != null;

        /// <summary>
        /// Gets and sets the property ProformaCost. 
        /// <para>
        /// The hypothetical Amazon Web Services charges based on the associated pricing plan
        /// of a billing group.
        /// </para>
        /// </summary>
        public string ProformaCost { get; set; }

        /// <summary>
        /// Checks to see if the ProformaCost property is set.
        /// </summary>
        internal bool IsSetProformaCost() => this.ProformaCost != null;
    }
}
