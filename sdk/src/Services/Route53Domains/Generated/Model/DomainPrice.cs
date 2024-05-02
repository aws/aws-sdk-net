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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
    /// Information about the domain price associated with a TLD.
    /// </summary>
    public partial class DomainPrice
    {
        private PriceWithCurrency _changeOwnershipPrice;
        private string _name;
        private PriceWithCurrency _registrationPrice;
        private PriceWithCurrency _renewalPrice;
        private PriceWithCurrency _restorationPrice;
        private PriceWithCurrency _transferPrice;

        /// <summary>
        /// Gets and sets the property ChangeOwnershipPrice. 
        /// <para>
        /// The price for changing domain ownership.
        /// </para>
        /// </summary>
        public PriceWithCurrency ChangeOwnershipPrice
        {
            get { return this._changeOwnershipPrice; }
            set { this._changeOwnershipPrice = value; }
        }

        // Check to see if ChangeOwnershipPrice property is set
        internal bool IsSetChangeOwnershipPrice()
        {
            return this._changeOwnershipPrice != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the TLD for which the prices apply.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationPrice. 
        /// <para>
        /// The price for domain registration with Route 53.
        /// </para>
        /// </summary>
        public PriceWithCurrency RegistrationPrice
        {
            get { return this._registrationPrice; }
            set { this._registrationPrice = value; }
        }

        // Check to see if RegistrationPrice property is set
        internal bool IsSetRegistrationPrice()
        {
            return this._registrationPrice != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalPrice. 
        /// <para>
        /// The price for renewing domain registration with Route 53.
        /// </para>
        /// </summary>
        public PriceWithCurrency RenewalPrice
        {
            get { return this._renewalPrice; }
            set { this._renewalPrice = value; }
        }

        // Check to see if RenewalPrice property is set
        internal bool IsSetRenewalPrice()
        {
            return this._renewalPrice != null;
        }

        /// <summary>
        /// Gets and sets the property RestorationPrice. 
        /// <para>
        /// The price for restoring the domain with Route 53.
        /// </para>
        /// </summary>
        public PriceWithCurrency RestorationPrice
        {
            get { return this._restorationPrice; }
            set { this._restorationPrice = value; }
        }

        // Check to see if RestorationPrice property is set
        internal bool IsSetRestorationPrice()
        {
            return this._restorationPrice != null;
        }

        /// <summary>
        /// Gets and sets the property TransferPrice. 
        /// <para>
        /// The price for transferring the domain registration to Route 53.
        /// </para>
        /// </summary>
        public PriceWithCurrency TransferPrice
        {
            get { return this._transferPrice; }
            set { this._transferPrice = value; }
        }

        // Check to see if TransferPrice property is set
        internal bool IsSetTransferPrice()
        {
            return this._transferPrice != null;
        }

    }
}