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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// A tagged union that represents the term configuration provided by the acceptor. Only
    /// one configuration is accepted per term.
    /// </summary>
    public partial class RequestedTermConfiguration
    {
        private ConfigurableUpfrontPricingTermConfiguration _configurableUpfrontPricingTermConfiguration;
        private RenewalTermConfiguration _renewalTermConfiguration;
        private VariablePaymentTermConfiguration _variablePaymentTermConfiguration;

        /// <summary>
        /// Gets and sets the property ConfigurableUpfrontPricingTermConfiguration.
        /// </summary>
        public ConfigurableUpfrontPricingTermConfiguration ConfigurableUpfrontPricingTermConfiguration
        {
            get { return this._configurableUpfrontPricingTermConfiguration; }
            set { this._configurableUpfrontPricingTermConfiguration = value; }
        }

        // Check to see if ConfigurableUpfrontPricingTermConfiguration property is set
        internal bool IsSetConfigurableUpfrontPricingTermConfiguration()
        {
            return this._configurableUpfrontPricingTermConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalTermConfiguration.
        /// </summary>
        public RenewalTermConfiguration RenewalTermConfiguration
        {
            get { return this._renewalTermConfiguration; }
            set { this._renewalTermConfiguration = value; }
        }

        // Check to see if RenewalTermConfiguration property is set
        internal bool IsSetRenewalTermConfiguration()
        {
            return this._renewalTermConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VariablePaymentTermConfiguration.
        /// </summary>
        public VariablePaymentTermConfiguration VariablePaymentTermConfiguration
        {
            get { return this._variablePaymentTermConfiguration; }
            set { this._variablePaymentTermConfiguration = value; }
        }

        // Check to see if VariablePaymentTermConfiguration property is set
        internal bool IsSetVariablePaymentTermConfiguration()
        {
            return this._variablePaymentTermConfiguration != null;
        }

    }
}