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

namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Place that is related to the result item.
    /// </summary>
    public partial class RelatedPlace
    {
        /// <summary>
        /// Gets and sets the property AccessPoints. 
        /// <para>
        /// Position of the access point in World Geodetic System (WGS 84) format: [longitude,
        /// latitude].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<AccessPoint> AccessPoints { get; set; } = AWSConfigs.InitializeCollections ? new List<AccessPoint>() : null;

        /// <summary>
        /// Checks to see if the AccessPoints property is set.
        /// </summary>
        internal bool IsSetAccessPoints() => this.AccessPoints != null && (this.AccessPoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The <c>PlaceId</c> of the place result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 500)]
        public string PlaceId { get; set; }

        /// <summary>
        /// Checks to see if the PlaceId property is set.
        /// </summary>
        internal bool IsSetPlaceId() => this.PlaceId != null;

        /// <summary>
        /// Gets and sets the property PlaceType. 
        /// <para>
        /// A <c>PlaceType</c> is a category that the result place must belong to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public PlaceType PlaceType { get; set; }

        /// <summary>
        /// Checks to see if the PlaceType property is set.
        /// </summary>
        internal bool IsSetPlaceType() => this.PlaceType != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position in World Geodetic System (WGS 84) format: [longitude, latitude].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 2)]
        public List<double> Position { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null && (this.Position.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The localized display name of this result item based on request parameter <c>language</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 200)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
