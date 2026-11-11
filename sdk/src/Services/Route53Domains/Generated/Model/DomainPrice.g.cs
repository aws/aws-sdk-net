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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Information about the prices associated with a TLD or a domain name.
    /// </summary>
    public partial class DomainPrice
    {
        /// <summary>
        /// Gets and sets the property ChangeOwnershipPrice. 
        /// <para>
        /// The price for changing domain ownership.
        /// </para>
        /// </summary>
        public PriceWithCurrency ChangeOwnershipPrice { get; set; }

        /// <summary>
        /// Checks to see if the ChangeOwnershipPrice property is set.
        /// </summary>
        internal bool IsSetChangeOwnershipPrice() => this.ChangeOwnershipPrice != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The TLD or domain name that the prices apply to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RegistrationPrice. 
        /// <para>
        /// The price for domain registration with Route 53.
        /// </para>
        /// </summary>
        public PriceWithCurrency RegistrationPrice { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationPrice property is set.
        /// </summary>
        internal bool IsSetRegistrationPrice() => this.RegistrationPrice != null;

        /// <summary>
        /// Gets and sets the property RenewalPrice. 
        /// <para>
        /// The price for renewing domain registration with Route 53.
        /// </para>
        /// </summary>
        public PriceWithCurrency RenewalPrice { get; set; }

        /// <summary>
        /// Checks to see if the RenewalPrice property is set.
        /// </summary>
        internal bool IsSetRenewalPrice() => this.RenewalPrice != null;

        /// <summary>
        /// Gets and sets the property RestorationPrice. 
        /// <para>
        /// The price for restoring the domain with Route 53.
        /// </para>
        /// </summary>
        public PriceWithCurrency RestorationPrice { get; set; }

        /// <summary>
        /// Checks to see if the RestorationPrice property is set.
        /// </summary>
        internal bool IsSetRestorationPrice() => this.RestorationPrice != null;

        /// <summary>
        /// Gets and sets the property TransferPrice. 
        /// <para>
        /// The price for transferring the domain registration to Route 53.
        /// </para>
        /// </summary>
        public PriceWithCurrency TransferPrice { get; set; }

        /// <summary>
        /// Checks to see if the TransferPrice property is set.
        /// </summary>
        internal bool IsSetTransferPrice() => this.TransferPrice != null;
    }
}
