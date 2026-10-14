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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// The expected duration of a partner's contract with the customer. Used to convert Total
    /// Contract Value (TCV) to Monthly Recurring Revenue (MRR) for opportunity dealsizing
    /// calculations.
    /// </summary>
    public partial class ExpectedContractDuration
    {
        /// <summary>
        /// Gets and sets the property Term. 
        /// <para>
        /// The unit of measurement for the contract duration value. Currently accepts only <c>Months</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExpectedContractDurationTerm Term { get; set; }

        /// <summary>
        /// Checks to see if the Term property is set.
        /// </summary>
        internal bool IsSetTerm() => this.Term != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A String representation of the contract duration as an integer, expressed in the unit
        /// defined by <c>Term</c>. Valid values range from <c>1</c> to <c>144</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
