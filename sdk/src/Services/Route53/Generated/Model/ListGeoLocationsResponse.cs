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
    /// A complex type containing the response information for the request.
    /// </summary>
    public partial class ListGeoLocationsResponse : AmazonWebServiceResponse
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
        /// A complex type that contains one <code>GeoLocationDetails</code> element for each
        /// location that Amazon Route 53 supports for geolocation.
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
        /// A value that indicates whether more locations remain to be listed after the last location
        /// in this response. If so, the value of <code>IsTruncated</code> is <code>true</code>.
        /// To get more values, submit another request and include the values of <code>NextContinentCode</code>,
        /// <code>NextCountryCode</code>, and <code>NextSubdivisionCode</code> in the <code>StartContinentCode</code>,
        /// <code>StartCountryCode</code>, and <code>StartSubdivisionCode</code>, as applicable.
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
        /// If <code>IsTruncated</code> is <code>true</code>, you can make a follow-up request
        /// to display more locations. Enter the value of <code>NextContinentCode</code> in the
        /// <code>StartContinentCode</code> parameter in another <code>GET</code> <code>ListGeoLocations</code>
        /// request.
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
        /// If <code>IsTruncated</code> is <code>true</code>, you can make a follow-up request
        /// to display more locations. Enter the value of <code>NextCountryCode</code> in the
        /// <code>StartCountryCode</code> parameter in another <code>GET</code> <code>ListGeoLocations</code>
        /// request.
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
        /// If <code>IsTruncated</code> is <code>true</code>, you can make a follow-up request
        /// to display more locations. Enter the value of <code>NextSubdivisionCode</code> in
        /// the <code>StartSubdivisionCode</code> parameter in another <code>GET</code> <code>ListGeoLocations</code>
        /// request.
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
        /// The value that you specified for <code>MaxItems</code> in the request.
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