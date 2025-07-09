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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
    /// Container for the parameters to the GetPlace operation.
    /// <c>GetPlace</c> finds a place by its unique ID. A <c>PlaceId</c> is returned by other
    /// place operations.
    /// </summary>
    public partial class GetPlaceRequest : AmazonGeoPlacesRequest
    {
        private List<string> _additionalFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GetPlaceIntendedUse _intendedUse;
        private string _key;
        private string _language;
        private string _placeId;
        private string _politicalView;

        /// <summary>
        /// Gets and sets the property AdditionalFeatures. 
        /// <para>
        /// A list of optional additional parameters such as time zone that can be requested for
        /// each result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AdditionalFeatures
        {
            get { return this._additionalFeatures; }
            set { this._additionalFeatures = value; }
        }

        // Check to see if AdditionalFeatures property is set
        internal bool IsSetAdditionalFeatures()
        {
            return this._additionalFeatures != null && (this._additionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntendedUse. 
        /// <para>
        /// Indicates if the results will be stored. Defaults to <c>SingleUse</c>, if left empty.
        /// </para>
        ///  <note> 
        /// <para>
        /// Storing the response of an GetPlace query is required to comply with service terms,
        /// but charged at a higher cost per request. Please review the <a href="https://aws.amazon.com/location/sla/">user
        /// agreement</a> and <a href="https://aws.amazon.com/location/pricing/">service pricing
        /// structure</a> to determine the correct setting for your use case.
        /// </para>
        ///  </note>
        /// </summary>
        public GetPlaceIntendedUse IntendedUse
        {
            get { return this._intendedUse; }
            set { this._intendedUse = value; }
        }

        // Check to see if IntendedUse property is set
        internal bool IsSetIntendedUse()
        {
            return this._intendedUse != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A list of <a href="https://en.wikipedia.org/wiki/IETF_language_tag">BCP 47</a> compliant
        /// language codes for the results to be rendered in. If there is no data for the result
        /// in the requested language, data will be returned in the default language for the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=35)]
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The <c>PlaceId</c> of the place you wish to receive the information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=500)]
        public string PlaceId
        {
            get { return this._placeId; }
            set { this._placeId = value; }
        }

        // Check to see if PlaceId property is set
        internal bool IsSetPlaceId()
        {
            return this._placeId != null;
        }

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the political view of a country. The political
        /// view applies to the results of the request to represent unresolved territorial claims
        /// through the point of view of the specified country.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=3)]
        public string PoliticalView
        {
            get { return this._politicalView; }
            set { this._politicalView = value; }
        }

        // Check to see if PoliticalView property is set
        internal bool IsSetPoliticalView()
        {
            return this._politicalView != null;
        }

    }
}