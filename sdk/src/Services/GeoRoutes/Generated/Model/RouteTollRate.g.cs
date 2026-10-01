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
    /// The toll rate.
    /// </summary>
    public partial class RouteTollRate
    {
        /// <summary>
        /// Gets and sets the property ApplicableTimes. 
        /// <para>
        /// Time when the rate is valid.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ApplicableTimes { get; set; }

        /// <summary>
        /// Checks to see if the ApplicableTimes property is set.
        /// </summary>
        internal bool IsSetApplicableTimes() => this.ApplicableTimes != null;

        /// <summary>
        /// Gets and sets the property ConvertedPrice. 
        /// <para>
        /// Price in the converted currency as specified in the request.
        /// </para>
        /// </summary>
        public RouteTollPrice ConvertedPrice { get; set; }

        /// <summary>
        /// Checks to see if the ConvertedPrice property is set.
        /// </summary>
        internal bool IsSetConvertedPrice() => this.ConvertedPrice != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The Toll rate Id.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LocalPrice. 
        /// <para>
        /// Price in the local regional currency.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteTollPrice LocalPrice { get; set; }

        /// <summary>
        /// Checks to see if the LocalPrice property is set.
        /// </summary>
        internal bool IsSetLocalPrice() => this.LocalPrice != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the toll.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Pass. 
        /// <para>
        /// Details if the toll rate can be a pass that supports multiple trips.
        /// </para>
        /// </summary>
        public RouteTollPass Pass { get; set; }

        /// <summary>
        /// Checks to see if the Pass property is set.
        /// </summary>
        internal bool IsSetPass() => this.Pass != null;

        /// <summary>
        /// Gets and sets the property PaymentMethods. 
        /// <para>
        /// Accepted payment methods at the toll.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 8)]
        public List<string> PaymentMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PaymentMethods property is set.
        /// </summary>
        internal bool IsSetPaymentMethods() => this.PaymentMethods != null && (this.PaymentMethods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Transponders. 
        /// <para>
        /// Transponders for which this toll can be applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteTransponder> Transponders { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteTransponder>() : null;

        /// <summary>
        /// Checks to see if the Transponders property is set.
        /// </summary>
        internal bool IsSetTransponders() => this.Transponders != null && (this.Transponders.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
