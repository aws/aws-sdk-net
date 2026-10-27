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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Contains additional tax information associated with your Tax Registration Number (TRN)
    /// in Mexico, such as the SAT tax regime and CFDI usage code.
    /// </summary>
    public partial class MexicoAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property CfdiUsageCode. 
        /// <para>
        /// The SAT CFDI usage code that identifies the purpose of the invoice in Mexico (for
        /// example, <c>G01</c> for goods acquisition, <c>S01</c> for no tax effects).
        /// </para>
        /// </summary>
        public string CfdiUsageCode { get; set; }

        /// <summary>
        /// Checks to see if the CfdiUsageCode property is set.
        /// </summary>
        internal bool IsSetCfdiUsageCode() => this.CfdiUsageCode != null;

        /// <summary>
        /// Gets and sets the property TaxRegime. 
        /// <para>
        /// The SAT-assigned tax regime code for your business in Mexico. Must be a 3-digit number
        /// (for example, <c>601</c> for General de Ley Personas Morales).
        /// </para>
        /// </summary>
        public string TaxRegime { get; set; }

        /// <summary>
        /// Checks to see if the TaxRegime property is set.
        /// </summary>
        internal bool IsSetTaxRegime() => this.TaxRegime != null;

        /// <summary>
        /// Gets and sets the property TaxRegimeFullName. 
        /// <para>
        /// The full name of the SAT tax regime associated with your business in Mexico.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public string TaxRegimeFullName { get; set; }

        /// <summary>
        /// Checks to see if the TaxRegimeFullName property is set.
        /// </summary>
        internal bool IsSetTaxRegimeFullName() => this.TaxRegimeFullName != null;
    }
}
