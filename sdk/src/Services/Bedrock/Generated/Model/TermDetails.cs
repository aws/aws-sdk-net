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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private LegalTerm _legalTerm;
        private SupportTerm _supportTerm;
        private PricingTerm _usageBasedPricingTerm;
        private ValidityTerm _validityTerm;

        /// <summary>
        /// Gets and sets the property LegalTerm. 
        /// <para>
        /// Describes the legal terms.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LegalTerm LegalTerm
        {
            get { return this._legalTerm; }
            set { this._legalTerm = value; }
        }

        // Check to see if LegalTerm property is set
        internal bool IsSetLegalTerm()
        {
            return this._legalTerm != null;
        }

        /// <summary>
        /// Gets and sets the property SupportTerm. 
        /// <para>
        /// Describes the support terms.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupportTerm SupportTerm
        {
            get { return this._supportTerm; }
            set { this._supportTerm = value; }
        }

        // Check to see if SupportTerm property is set
        internal bool IsSetSupportTerm()
        {
            return this._supportTerm != null;
        }

        /// <summary>
        /// Gets and sets the property UsageBasedPricingTerm.
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingTerm UsageBasedPricingTerm
        {
            get { return this._usageBasedPricingTerm; }
            set { this._usageBasedPricingTerm = value; }
        }

        // Check to see if UsageBasedPricingTerm property is set
        internal bool IsSetUsageBasedPricingTerm()
        {
            return this._usageBasedPricingTerm != null;
        }

        /// <summary>
        /// Gets and sets the property ValidityTerm. 
        /// <para>
        /// Describes the validity terms.
        /// </para>
        /// </summary>
        public ValidityTerm ValidityTerm
        {
            get { return this._validityTerm; }
            set { this._validityTerm = value; }
        }

        // Check to see if ValidityTerm property is set
        internal bool IsSetValidityTerm()
        {
            return this._validityTerm != null;
        }

    }
}