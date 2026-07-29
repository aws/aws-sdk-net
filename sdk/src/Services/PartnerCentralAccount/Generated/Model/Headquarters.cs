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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Contains the partner's headquarters location using International Organization for
    /// Standardization (ISO) 3166 country and subdivision codes.
    /// </summary>
    public partial class Headquarters
    {
        private string _countryCode;
        private string _subdivisionCode;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The ISO 3166-1 alpha-2 country code of the partner's headquarters. For example, <c>US</c>,
        /// <c>BR</c>, or <c>DE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property SubdivisionCode. 
        /// <para>
        /// The subdivision portion of the ISO 3166-2 code for the partner's headquarters (for
        /// example, <c>SP</c> from <c>BR-SP</c>, <c>NSW</c> from <c>AU-NSW</c>, or <c>13</c>
        /// from <c>JP-13</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public string SubdivisionCode
        {
            get { return this._subdivisionCode; }
            set { this._subdivisionCode = value; }
        }

        // Check to see if SubdivisionCode property is set
        internal bool IsSetSubdivisionCode()
        {
            return this._subdivisionCode != null;
        }

    }
}