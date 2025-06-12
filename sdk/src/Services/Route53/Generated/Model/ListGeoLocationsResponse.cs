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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type containing the response information for the request.
    /// </summary>
    public partial class ListGeoLocationsResponse : AmazonWebServiceResponse
    {
        private List<GeoLocationDetails> _geoLocationDetailsList = AWSConfigs.InitializeCollections ? new List<GeoLocationDetails>() : null;
        private bool? _isTruncated;
        private string _nextContinentCode;
        private string _nextCountryCode;
        private string _nextSubdivisionCode;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property GeoLocationDetailsList. 
        /// <para>
        /// A complex type that contains one <c>GeoLocationDetails</c> element for each location
        /// that Amazon Route 53 supports for geolocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GeoLocationDetails> GeoLocationDetailsList
        {
            get { return this._geoLocationDetailsList; }
            set { this._geoLocationDetailsList = value; }
        }

        // Check to see if GeoLocationDetailsList property is set
        internal bool IsSetGeoLocationDetailsList()
        {
            return this._geoLocationDetailsList != null && (this._geoLocationDetailsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A value that indicates whether more locations remain to be listed after the last location
        /// in this response. If so, the value of <c>IsTruncated</c> is <c>true</c>. To get more
        /// values, submit another request and include the values of <c>NextContinentCode</c>,
        /// <c>NextCountryCode</c>, and <c>NextSubdivisionCode</c> in the <c>startcontinentcode</c>,
        /// <c>startcountrycode</c>, and <c>startsubdivisioncode</c>, as applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
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
        /// If <c>IsTruncated</c> is <c>true</c>, you can make a follow-up request to display
        /// more locations. Enter the value of <c>NextContinentCode</c> in the <c>startcontinentcode</c>
        /// parameter in another <c>ListGeoLocations</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
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
        /// If <c>IsTruncated</c> is <c>true</c>, you can make a follow-up request to display
        /// more locations. Enter the value of <c>NextCountryCode</c> in the <c>startcountrycode</c>
        /// parameter in another <c>ListGeoLocations</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
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
        /// If <c>IsTruncated</c> is <c>true</c>, you can make a follow-up request to display
        /// more locations. Enter the value of <c>NextSubdivisionCode</c> in the <c>startsubdivisioncode</c>
        /// parameter in another <c>ListGeoLocations</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
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
        /// The value that you specified for <c>MaxItems</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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