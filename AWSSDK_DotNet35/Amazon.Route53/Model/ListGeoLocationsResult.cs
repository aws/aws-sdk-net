/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about the geo locations that are returned
    /// by the request and information about the response.
    /// </summary>
    public partial class ListGeoLocationsResult : AmazonWebServiceResponse
    {
        private List<GeoLocationDetails> _geoLocationDetailsList = new List<GeoLocationDetails>();
        private bool? _isTruncated;
        private string _nextContinentCode;
        private string _nextCountryCode;
        private string _nextSubdivisionCode;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property GeoLocationDetailsList. 
        /// <para>
        /// A complex type that contains information about the geo locations that are returned
        /// by the request.
        /// </para>
        /// </summary>
        public List<GeoLocationDetails> GeoLocationDetailsList
        {
            get { return this._geoLocationDetailsList; }
            set { this._geoLocationDetailsList = value; }
        }

        // Check to see if GeoLocationDetailsList property is set
        internal bool IsSetGeoLocationDetailsList()
        {
            return this._geoLocationDetailsList != null && this._geoLocationDetailsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more geo locations to be listed. If your results
        /// were truncated, you can make a follow-up request for the next page of results by using
        /// the values included in the <a>ListGeoLocationsResponse$NextContinentCode</a>, <a>ListGeoLocationsResponse$NextCountryCode</a>
        /// and <a>ListGeoLocationsResponse$NextSubdivisionCode</a> elements.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code>
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextContinentCode. 
        /// <para>
        /// If the results were truncated, the continent code of the next geo location in the
        /// list. This element is present only if <a>ListGeoLocationsResponse$IsTruncated</a>
        /// is true and the next geo location to list is a continent location. 
        /// </para>
        /// </summary>
        public string NextContinentCode
        {
            get { return this._nextContinentCode; }
            set { this._nextContinentCode = value; }
        }

        // Check to see if NextContinentCode property is set
        internal bool IsSetNextContinentCode()
        {
            return this._nextContinentCode != null;
        }

        /// <summary>
        /// Gets and sets the property NextCountryCode. 
        /// <para>
        /// If the results were truncated, the country code of the next geo location in the list.
        /// This element is present only if <a>ListGeoLocationsResponse$IsTruncated</a> is true
        /// and the next geo location to list is not a continent location. 
        /// </para>
        /// </summary>
        public string NextCountryCode
        {
            get { return this._nextCountryCode; }
            set { this._nextCountryCode = value; }
        }

        // Check to see if NextCountryCode property is set
        internal bool IsSetNextCountryCode()
        {
            return this._nextCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property NextSubdivisionCode. 
        /// <para>
        /// If the results were truncated, the subdivision code of the next geo location in the
        /// list. This element is present only if <a>ListGeoLocationsResponse$IsTruncated</a>
        /// is true and the next geo location has a subdivision. 
        /// </para>
        /// </summary>
        public string NextSubdivisionCode
        {
            get { return this._nextSubdivisionCode; }
            set { this._nextSubdivisionCode = value; }
        }

        // Check to see if NextSubdivisionCode property is set
        internal bool IsSetNextSubdivisionCode()
        {
            return this._nextSubdivisionCode != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of records you requested. The maximum value of <code>MaxItems</code>
        /// is 100.
        /// </para>
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}