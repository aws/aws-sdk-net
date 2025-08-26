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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Provides details about toll information along a route, including the payment sites,
    /// applicable toll rates, toll systems, and the country associated with the toll collection.
    /// </summary>
    public partial class RouteToll
    {
        private string _country;
        private List<RouteTollPaymentSite> _paymentSites = AWSConfigs.InitializeCollections ? new List<RouteTollPaymentSite>() : null;
        private List<RouteTollRate> _rates = AWSConfigs.InitializeCollections ? new List<RouteTollRate>() : null;
        private List<int> _systems = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the country.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=3)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentSites. 
        /// <para>
        /// Locations or sites where the toll fare is collected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteTollPaymentSite> PaymentSites
        {
            get { return this._paymentSites; }
            set { this._paymentSites = value; }
        }

        // Check to see if PaymentSites property is set
        internal bool IsSetPaymentSites()
        {
            return this._paymentSites != null && (this._paymentSites.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Rates. 
        /// <para>
        /// Toll rates that need to be paid to travel this leg of the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteTollRate> Rates
        {
            get { return this._rates; }
            set { this._rates = value; }
        }

        // Check to see if Rates property is set
        internal bool IsSetRates()
        {
            return this._rates != null && (this._rates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Systems. 
        /// <para>
        /// Toll systems are authorities that collect payments for the toll.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<int> Systems
        {
            get { return this._systems; }
            set { this._systems = value; }
        }

        // Check to see if Systems property is set
        internal bool IsSetSystems()
        {
            return this._systems != null && (this._systems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}