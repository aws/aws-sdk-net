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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// A tagged union that represents the term configuration provided by the acceptor. Only
    /// one configuration is accepted per term.
    /// </summary>
    public partial class RequestedTermConfiguration
    {
        /// <summary>
        /// Gets and sets the property ConfigurableUpfrontPricingTermConfiguration.
        /// </summary>
        public ConfigurableUpfrontPricingTermConfiguration ConfigurableUpfrontPricingTermConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurableUpfrontPricingTermConfiguration property is set.
        /// </summary>
        internal bool IsSetConfigurableUpfrontPricingTermConfiguration() => this.ConfigurableUpfrontPricingTermConfiguration != null;

        /// <summary>
        /// Gets and sets the property RenewalTermConfiguration.
        /// </summary>
        public RenewalTermConfiguration RenewalTermConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RenewalTermConfiguration property is set.
        /// </summary>
        internal bool IsSetRenewalTermConfiguration() => this.RenewalTermConfiguration != null;

        /// <summary>
        /// Gets and sets the property VariablePaymentTermConfiguration.
        /// </summary>
        public VariablePaymentTermConfiguration VariablePaymentTermConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VariablePaymentTermConfiguration property is set.
        /// </summary>
        internal bool IsSetVariablePaymentTermConfiguration() => this.VariablePaymentTermConfiguration != null;
    }
}
