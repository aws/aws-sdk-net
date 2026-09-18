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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Provides details about toll information along a route, including the payment sites,
    /// applicable toll rates, toll systems, and the country associated with the toll collection.
    /// </summary>
    public partial class RouteToll
    {
        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the country.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 3)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property PaymentSites. 
        /// <para>
        /// Locations or sites where the toll fare is collected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTollPaymentSite> PaymentSites { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTollPaymentSite>() : null;

        /// <summary>
        /// Checks to see if the PaymentSites property is set.
        /// </summary>
        internal bool IsSetPaymentSites() => this.PaymentSites != null && (this.PaymentSites.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Rates. 
        /// <para>
        /// Toll rates that need to be paid to travel this leg of the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTollRate> Rates { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTollRate>() : null;

        /// <summary>
        /// Checks to see if the Rates property is set.
        /// </summary>
        internal bool IsSetRates() => this.Rates != null && (this.Rates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Systems. 
        /// <para>
        /// Toll systems are authorities that collect payments for the toll.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<int> Systems { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Systems property is set.
        /// </summary>
        internal bool IsSetSystems() => this.Systems != null && (this.Systems.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
