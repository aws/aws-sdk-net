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
    /// Container for the parameters to the PutTaxExemption operation. Adds the tax exemption
    /// for a single account or all accounts listed in a consolidated billing family. The
    /// IAM action is <c>tax:UpdateExemptions</c>.
    /// </summary>
    public partial class PutTaxExemptionRequest : AmazonTaxSettingsRequest
    {
        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        ///  The list of unique account identifiers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 550)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Authority.
        /// </summary>
        [AWSProperty(Required = true)]
        public Authority Authority { get; set; }

        /// <summary>
        /// Checks to see if the Authority property is set.
        /// </summary>
        internal bool IsSetAuthority() => this.Authority != null;

        /// <summary>
        /// Gets and sets the property ExemptionCertificate.
        /// </summary>
        [AWSProperty(Required = true)]
        public ExemptionCertificate ExemptionCertificate { get; set; }

        /// <summary>
        /// Checks to see if the ExemptionCertificate property is set.
        /// </summary>
        internal bool IsSetExemptionCertificate() => this.ExemptionCertificate != null;

        /// <summary>
        /// Gets and sets the property ExemptionType. 
        /// <para>
        /// The exemption type. Use the supported tax exemption type description. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string ExemptionType { get; set; }

        /// <summary>
        /// Checks to see if the ExemptionType property is set.
        /// </summary>
        internal bool IsSetExemptionType() => this.ExemptionType != null;
    }
}
