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

namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Input parameters for configuring test environment preferences for a procurement portal.
    /// </summary>
    public partial class TestEnvPreferenceInput
    {
        /// <summary>
        /// Gets and sets the property BuyerDomain. 
        /// <para>
        /// The domain identifier to use for the buyer in the test environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BuyerDomain BuyerDomain { get; set; }

        /// <summary>
        /// Checks to see if the BuyerDomain property is set.
        /// </summary>
        internal bool IsSetBuyerDomain() => this.BuyerDomain != null;

        /// <summary>
        /// Gets and sets the property BuyerIdentifier. 
        /// <para>
        /// The unique identifier to use for the buyer in the test environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string BuyerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BuyerIdentifier property is set.
        /// </summary>
        internal bool IsSetBuyerIdentifier() => this.BuyerIdentifier != null;

        /// <summary>
        /// Gets and sets the property ProcurementPortalInstanceEndpoint. 
        /// <para>
        /// The endpoint URL where e-invoices will be delivered in the test environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ProcurementPortalInstanceEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementPortalInstanceEndpoint property is set.
        /// </summary>
        internal bool IsSetProcurementPortalInstanceEndpoint() => this.ProcurementPortalInstanceEndpoint != null;

        /// <summary>
        /// Gets and sets the property ProcurementPortalSharedSecret. 
        /// <para>
        /// The shared secret or authentication credential to use for secure communication in
        /// the test environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ProcurementPortalSharedSecret { get; set; }

        /// <summary>
        /// Checks to see if the ProcurementPortalSharedSecret property is set.
        /// </summary>
        internal bool IsSetProcurementPortalSharedSecret() => this.ProcurementPortalSharedSecret != null;

        /// <summary>
        /// Gets and sets the property SupplierDomain. 
        /// <para>
        /// The domain identifier to use for the supplier in the test environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SupplierDomain SupplierDomain { get; set; }

        /// <summary>
        /// Checks to see if the SupplierDomain property is set.
        /// </summary>
        internal bool IsSetSupplierDomain() => this.SupplierDomain != null;

        /// <summary>
        /// Gets and sets the property SupplierIdentifier. 
        /// <para>
        /// The unique identifier to use for the supplier in the test environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string SupplierIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SupplierIdentifier property is set.
        /// </summary>
        internal bool IsSetSupplierIdentifier() => this.SupplierIdentifier != null;
    }
}
