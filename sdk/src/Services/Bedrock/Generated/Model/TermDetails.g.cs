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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Describes the usage terms of an offer.
    /// </summary>
    public partial class TermDetails
    {
        /// <summary>
        /// Gets and sets the property LegalTerm. 
        /// <para>
        /// Describes the legal terms.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LegalTerm LegalTerm { get; set; }

        /// <summary>
        /// Checks to see if the LegalTerm property is set.
        /// </summary>
        internal bool IsSetLegalTerm() => this.LegalTerm != null;

        /// <summary>
        /// Gets and sets the property SupportTerm. 
        /// <para>
        /// Describes the support terms.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SupportTerm SupportTerm { get; set; }

        /// <summary>
        /// Checks to see if the SupportTerm property is set.
        /// </summary>
        internal bool IsSetSupportTerm() => this.SupportTerm != null;

        /// <summary>
        /// Gets and sets the property UsageBasedPricingTerm.
        /// </summary>
        [AWSProperty(Required = true)]
        public PricingTerm UsageBasedPricingTerm { get; set; }

        /// <summary>
        /// Checks to see if the UsageBasedPricingTerm property is set.
        /// </summary>
        internal bool IsSetUsageBasedPricingTerm() => this.UsageBasedPricingTerm != null;

        /// <summary>
        /// Gets and sets the property ValidityTerm. 
        /// <para>
        /// Describes the validity terms.
        /// </para>
        /// </summary>
        public ValidityTerm ValidityTerm { get; set; }

        /// <summary>
        /// Checks to see if the ValidityTerm property is set.
        /// </summary>
        internal bool IsSetValidityTerm() => this.ValidityTerm != null;
    }
}
