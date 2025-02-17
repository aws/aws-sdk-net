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
    /// Container for the parameters to the Autocomplete operation.
    /// The autocomplete operation speeds up and increases the accuracy of entering addresses
    /// by providing a list of address candidates matching a partially entered address. Results
    /// are sorted from most to least matching. Filtering and biasing can be used to increase
    /// the relevance of the results if additional search context is known
    /// </summary>
    public partial class AutocompleteRequest : AmazonGeoPlacesRequest
    {
        private List<string> _additionalFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<double> _biasPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private AutocompleteFilter _filter;
        private AutocompleteIntendedUse _intendedUse;
        private string _key;
        private string _language;
        private int? _maxResults;
        private string _politicalView;
        private PostalCodeMode _postalCodeMode;
        private string _queryText;

        /// <summary>
        /// Gets and sets the property AdditionalFeatures. 
        /// <para>
        /// A list of optional additional parameters that can be requested for each result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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
        /// Gets and sets the property BiasPosition. 
        /// <para>
        /// The position in longitude and latitude that the results should be close to. Typically,
        /// place results returned are ranked higher the closer they are to this position. Stored
        /// in <c>[lng, lat]</c> and in the WSG84 format.
        /// </para>
        ///  <note> 
        /// <para>
        /// The fields <c>BiasPosition</c>, <c>FilterBoundingBox</c>, and <c>FilterCircle</c>
        /// are mutually exclusive.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
        public List<double> BiasPosition
        {
            get { return this._biasPosition; }
            set { this._biasPosition = value; }
        }

        // Check to see if BiasPosition property is set
        internal bool IsSetBiasPosition()
        {
            return this._biasPosition != null && (this._biasPosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A structure which contains a set of inclusion/exclusion properties that results must
        /// posses in order to be returned as a result.
        /// </para>
        /// </summary>
        public AutocompleteFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property IntendedUse. 
        /// <para>
        /// Indicates if the results will be stored. Defaults to <c>SingleUse</c>, if left empty.
        /// </para>
        /// </summary>
        public AutocompleteIntendedUse IntendedUse
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional limit for the number of results returned in a single call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the political view of a country. The political
        /// view applies to the results of the request to represent unresolved territorial claims
        /// through the point of view of the specified country.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=3)]
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

        /// <summary>
        /// Gets and sets the property PostalCodeMode. 
        /// <para>
        /// The <c>PostalCodeMode</c> affects how postal code results are returned. If a postal
        /// code spans multiple localities and this value is empty, partial district or locality
        /// information may be returned under a single postal code result entry. If it's populated
        /// with the value <c>cityLookup</c>, all cities in that postal code are returned.
        /// </para>
        /// </summary>
        public PostalCodeMode PostalCodeMode
        {
            get { return this._postalCodeMode; }
            set { this._postalCodeMode = value; }
        }

        // Check to see if PostalCodeMode property is set
        internal bool IsSetPostalCodeMode()
        {
            return this._postalCodeMode != null;
        }

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The free-form text query to match addresses against. This is usually a partially typed
        /// address from an end user in an address box or form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=200)]
        public string QueryText
        {
            get { return this._queryText; }
            set { this._queryText = value; }
        }

        // Check to see if QueryText property is set
        internal bool IsSetQueryText()
        {
            return this._queryText != null;
        }

    }
}