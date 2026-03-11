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
    /// The toll rate.
    /// </summary>
    public partial class RouteTollRate
    {
        private string _applicableTimes;
        private RouteTollPrice _convertedPrice;
        private string _id;
        private RouteTollPrice _localPrice;
        private string _name;
        private RouteTollPass _pass;
        private List<string> _paymentMethods = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RouteTransponder> _transponders = AWSConfigs.InitializeCollections ? new List<RouteTransponder>() : null;

        /// <summary>
        /// Gets and sets the property ApplicableTimes. 
        /// <para>
        /// Time when the rate is valid.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ApplicableTimes
        {
            get { return this._applicableTimes; }
            set { this._applicableTimes = value; }
        }

        // Check to see if ApplicableTimes property is set
        internal bool IsSetApplicableTimes()
        {
            return this._applicableTimes != null;
        }

        /// <summary>
        /// Gets and sets the property ConvertedPrice. 
        /// <para>
        /// Price in the converted currency as specified in the request.
        /// </para>
        /// </summary>
        public RouteTollPrice ConvertedPrice
        {
            get { return this._convertedPrice; }
            set { this._convertedPrice = value; }
        }

        // Check to see if ConvertedPrice property is set
        internal bool IsSetConvertedPrice()
        {
            return this._convertedPrice != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The Toll rate Id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LocalPrice. 
        /// <para>
        /// Price in the local regional currency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteTollPrice LocalPrice
        {
            get { return this._localPrice; }
            set { this._localPrice = value; }
        }

        // Check to see if LocalPrice property is set
        internal bool IsSetLocalPrice()
        {
            return this._localPrice != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the toll.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property Pass. 
        /// <para>
        /// Details if the toll rate can be a pass that supports multiple trips.
        /// </para>
        /// </summary>
        public RouteTollPass Pass
        {
            get { return this._pass; }
            set { this._pass = value; }
        }

        // Check to see if Pass property is set
        internal bool IsSetPass()
        {
            return this._pass != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentMethods. 
        /// <para>
        /// Accepted payment methods at the toll.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=8)]
        public List<string> PaymentMethods
        {
            get { return this._paymentMethods; }
            set { this._paymentMethods = value; }
        }

        // Check to see if PaymentMethods property is set
        internal bool IsSetPaymentMethods()
        {
            return this._paymentMethods != null && (this._paymentMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Transponders. 
        /// <para>
        /// Transponders for which this toll can be applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteTransponder> Transponders
        {
            get { return this._transponders; }
            set { this._transponders = value; }
        }

        // Check to see if Transponders property is set
        internal bool IsSetTransponders()
        {
            return this._transponders != null && (this._transponders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}