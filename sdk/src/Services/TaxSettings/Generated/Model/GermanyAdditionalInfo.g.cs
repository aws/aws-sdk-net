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
    /// in Germany, such as the economic identification number and Steuernummer.
    /// </summary>
    public partial class GermanyAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property EconomicIdentificationNumber. 
        /// <para>
        /// The economic identification number (Wirtschafts-Identifikationsnummer, or W-IdNr)
        /// in Germany.
        /// </para>
        /// </summary>
        public string EconomicIdentificationNumber { get; set; }

        /// <summary>
        /// Checks to see if the EconomicIdentificationNumber property is set.
        /// </summary>
        internal bool IsSetEconomicIdentificationNumber() => this.EconomicIdentificationNumber != null;

        /// <summary>
        /// Gets and sets the property Steuernummer. 
        /// <para>
        /// The Steuernummer (tax number issued by the local tax office) in Germany.
        /// </para>
        /// </summary>
        public string Steuernummer { get; set; }

        /// <summary>
        /// Checks to see if the Steuernummer property is set.
        /// </summary>
        internal bool IsSetSteuernummer() => this.Steuernummer != null;
    }
}
