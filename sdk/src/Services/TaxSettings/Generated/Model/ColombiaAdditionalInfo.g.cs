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
    /// in Colombia, derived from your Registro Único Tributario (RUT) document.
    /// </summary>
    public partial class ColombiaAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property IssueDate. 
        /// <para>
        /// The issue date of the RUT document from Box 61, in <c>YYYY-MM-DD</c> format.
        /// </para>
        /// </summary>
        public string IssueDate { get; set; }

        /// <summary>
        /// Checks to see if the IssueDate property is set.
        /// </summary>
        internal bool IsSetIssueDate() => this.IssueDate != null;

        /// <summary>
        /// Gets and sets the property ResponsibilityCodes. 
        /// <para>
        /// The DIAN fiscal responsibility codes from Box 53 of the RUT document (for example,
        /// <c>48</c> for value-added tax (VAT) responsibility).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 26)]
        public List<string> ResponsibilityCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResponsibilityCodes property is set.
        /// </summary>
        internal bool IsSetResponsibilityCodes() => this.ResponsibilityCodes != null && (this.ResponsibilityCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaxpayerTypeCode. 
        /// <para>
        /// The taxpayer category from Box 24 of the RUT document (<c>1</c> for a legal entity,
        /// <c>2</c> for a natural person).
        /// </para>
        /// </summary>
        public string TaxpayerTypeCode { get; set; }

        /// <summary>
        /// Checks to see if the TaxpayerTypeCode property is set.
        /// </summary>
        internal bool IsSetTaxpayerTypeCode() => this.TaxpayerTypeCode != null;
    }
}
