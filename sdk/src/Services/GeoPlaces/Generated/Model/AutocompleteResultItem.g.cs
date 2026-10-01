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
    /// A result matching the input query text.
    /// </summary>
    public partial class AutocompleteResultItem
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address associated with this result.
        /// </para>
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The distance in meters between the center of the search area and this result. Useful
        /// to evaluate how far away from the original bias position the result is.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedPointAddress. 
        /// <para>
        /// If <c>true</c>, indicates that the coordinates of the position and access points of
        /// the point address are estimated.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? EstimatedPointAddress { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedPointAddress property is set.
        /// </summary>
        internal bool IsSetEstimatedPointAddress() => this.EstimatedPointAddress.HasValue;

        /// <summary>
        /// Gets and sets the property Highlights. 
        /// <para>
        /// Indicates the starting and ending index of the place in the text query that match
        /// the found title. 
        /// </para>
        /// </summary>
        public AutocompleteHighlights Highlights { get; set; }

        /// <summary>
        /// Checks to see if the Highlights property is set.
        /// </summary>
        internal bool IsSetHighlights() => this.Highlights != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A list of <a href="https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry">BCP
        /// 47</a> compliant language codes for the results to be rendered in. If there is no
        /// data for the result in the requested language, data will be returned in the default
        /// language for the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 35)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The PlaceId of the place associated with this result. This can be used to look up
        /// additional details about the result via GetPlace.
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
        /// PlaceType describes the type of result entry returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public PlaceType PlaceType { get; set; }

        /// <summary>
        /// Checks to see if the PlaceType property is set.
        /// </summary>
        internal bool IsSetPlaceType() => this.PlaceType != null;

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the political view of a country. The political
        /// view applies to the results of the request to represent unresolved territorial claims
        /// through the point of view of the specified country.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 3)]
        public string PoliticalView { get; set; }

        /// <summary>
        /// Checks to see if the PoliticalView property is set.
        /// </summary>
        internal bool IsSetPoliticalView() => this.PoliticalView != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A formatted string for display when presenting this result to an end user.
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
