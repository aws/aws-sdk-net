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
    /// Container for the parameters to the GetPlace operation. <c>GetPlace</c> finds a place
    /// by its unique ID. A <c>PlaceId</c> is returned by other place operations. <para> For
    /// more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/get-place.html">GetPlace</a>
    /// in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class GetPlaceRequest : AmazonGeoPlacesRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalFeatures. 
        /// <para>
        ///  A list of optional additional parameters such as time zone that can be requested
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
        [AWSProperty(Min = 1, Max = 6)]
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
        public GetPlaceAddressNamesMode AddressNamesMode { get; set; }

        /// <summary>
        /// Checks to see if the AddressNamesMode property is set.
        /// </summary>
        internal bool IsSetAddressNamesMode() => this.AddressNamesMode != null;

        /// <summary>
        /// Gets and sets the property IntendedUse. 
        /// <para>
        ///  Indicates if the query results will be persisted in customer infrastructure. Defaults
        /// to <c>SingleUse</c> (not stored). Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When storing <c>GetPlace</c> responses, you <i>must</i> set this field to <c>Storage</c>
        /// to comply with the terms of service. These requests will be charged at a higher rate.
        /// Please review the <a href="https://aws.amazon.com/location/sla/">user agreement</a>
        /// and <a href="https://aws.amazon.com/location/pricing/">service pricing structure</a>
        /// to determine the correct setting for your use case.
        /// </para>
        ///  </note>
        /// </summary>
        public GetPlaceIntendedUse IntendedUse { get; set; }

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
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The <c>PlaceId</c> of the place you wish to receive the information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 500)]
        public string PlaceId { get; set; }

        /// <summary>
        /// Checks to see if the PlaceId property is set.
        /// </summary>
        internal bool IsSetPlaceId() => this.PlaceId != null;

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
    }
}
