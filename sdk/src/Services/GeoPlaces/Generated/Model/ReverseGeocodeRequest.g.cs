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
    /// Container for the parameters to the ReverseGeocode operation. <c>ReverseGeocode</c>
    /// converts geographic coordinates into a human-readable address or place. You can obtain
    /// address component, and other related information such as place type, category, street
    /// information. The Reverse Geocode API supports filtering to on place type so that you
    /// can refine result based on your need. Also, The Reverse Geocode API can also provide
    /// additional features such as time zone information and the inclusion of political views.
    /// <para> For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/reverse-geocode.html">Reverse
    /// Geocode</a> in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class ReverseGeocodeRequest : AmazonGeoPlacesRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalFeatures. 
        /// <para>
        ///  A list of optional additional parameters, such as time zone that can be requested
        /// for each result. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only the
        /// <c>TimeZone</c> value. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> AdditionalFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalFeatures property is set.
        /// </summary>
        internal bool IsSetAdditionalFeatures() => this.AdditionalFeatures != null && (this.AdditionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AddressNamesMode. 
        /// <para>
        /// Specifies how address names are returned. When set to <c>Administrative</c>, the service
        /// returns the official administrative names for address components. <c>Administrative</c>
        /// currently applies only to addresses in the United States.
        /// </para>
        /// </summary>
        public ReverseGeocodeAddressNamesMode AddressNamesMode { get; set; }

        /// <summary>
        /// Checks to see if the AddressNamesMode property is set.
        /// </summary>
        internal bool IsSetAddressNamesMode() => this.AddressNamesMode != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A structure which contains a set of inclusion/exclusion properties that results must
        /// possess in order to be returned as a result.
        /// </para>
        /// </summary>
        public ReverseGeocodeFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property Heading. 
        /// <para>
        /// The heading in degrees from true north in a navigation context. The heading is measured
        /// as the angle clockwise from the North direction.
        /// </para>
        ///  
        /// <para>
        /// Example: North is <c>0</c> degrees, East is <c>90</c> degrees, South is <c>180</c>
        /// degrees, and West is <c>270</c> degrees.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 360)]
        public double? Heading { get; set; }

        /// <summary>
        /// Checks to see if the Heading property is set.
        /// </summary>
        internal bool IsSetHeading() => this.Heading.HasValue;

        /// <summary>
        /// Gets and sets the property IntendedUse. 
        /// <para>
        ///  Indicates if the query results will be persisted in customer infrastructure. Defaults
        /// to <c>SingleUse</c> (not stored). 
        /// </para>
        ///  <note> 
        /// <para>
        /// When storing <c>ReverseGeocode</c> responses, you <i>must</i> set this field to <c>Storage</c>
        /// to comply with the terms of service. These requests will be charged at a higher rate.
        /// Please review the <a href="https://aws.amazon.com/location/sla/">user agreement</a>
        /// and <a href="https://aws.amazon.com/location/pricing/">service pricing structure</a>
        /// to determine the correct setting for your use case.
        /// </para>
        ///  </note>
        /// </summary>
        public ReverseGeocodeIntendedUse IntendedUse { get; set; }

        /// <summary>
        /// Checks to see if the IntendedUse property is set.
        /// </summary>
        internal bool IsSetIntendedUse() => this.IntendedUse != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1000)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        ///  A list of <a href="https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry">BCP
        /// 47</a> compliant language codes for the results to be rendered in. If there is no
        /// data for the result in the requested language, data will be returned in the default
        /// language for the entry. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only the
        /// following codes: <c>en, id, km, lo, ms, my, pt, th, tl, vi, zh</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 35)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  An optional limit for the number of results returned in a single call.
        /// </para>
        ///  
        /// <para>
        /// Default value: 1
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        ///  The alpha-2 or alpha-3 character code for the political view of a country. The political
        /// view applies to the results of the request to represent unresolved territorial claims
        /// through the point of view of the specified country. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 3)]
        public string PoliticalView { get; set; }

        /// <summary>
        /// Checks to see if the PoliticalView property is set.
        /// </summary>
        internal bool IsSetPoliticalView() => this.PoliticalView != null;

        /// <summary>
        /// Gets and sets the property QueryPosition. 
        /// <para>
        /// The position in World Geodetic System (WGS 84) format: [longitude, latitude] for which
        /// you are querying nearby results for. Results closer to the position will be ranked
        /// higher then results further away from the position
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> QueryPosition { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the QueryPosition property is set.
        /// </summary>
        internal bool IsSetQueryPosition() => this.QueryPosition != null && (this.QueryPosition.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryRadius. 
        /// <para>
        ///  The maximum distance in meters from the QueryPosition from which a result will be
        /// returned. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only up
        /// to a maximum value of 100,000. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 21000000)]
        public long? QueryRadius { get; set; }

        /// <summary>
        /// Checks to see if the QueryRadius property is set.
        /// </summary>
        internal bool IsSetQueryRadius() => this.QueryRadius.HasValue;
    }
}
