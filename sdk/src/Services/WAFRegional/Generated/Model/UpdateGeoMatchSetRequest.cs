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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
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
namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGeoMatchSet operation.
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Inserts or deletes <a>GeoMatchConstraint</a> objects in an <c>GeoMatchSet</c>. For
    /// each <c>GeoMatchConstraint</c> object, you specify the following values: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Whether to insert or delete the object from the array. If you want to change an <c>GeoMatchConstraint</c>
    /// object, you delete the existing object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>Type</c>. The only valid value for <c>Type</c> is <c>Country</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>Value</c>, which is a two character code for the country to add to the <c>GeoMatchConstraint</c>
    /// object. Valid codes are listed in <a>GeoMatchConstraint$Value</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To create and configure an <c>GeoMatchSet</c>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Submit a <a>CreateGeoMatchSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of an <a>UpdateGeoMatchSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <c>UpdateGeoMatchSet</c> request to specify the country that you want AWS
    /// WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// When you update an <c>GeoMatchSet</c>, you specify the country that you want to add
    /// and/or the country that you want to delete. If you want to change a country, you delete
    /// the existing country and add the new one.
    /// </para>
    ///  
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateGeoMatchSetRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _geoMatchSetId;
        private List<GeoMatchSetUpdate> _updates = AWSConfigs.InitializeCollections ? new List<GeoMatchSetUpdate>() : null;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property GeoMatchSetId. 
        /// <para>
        /// The <c>GeoMatchSetId</c> of the <a>GeoMatchSet</a> that you want to update. <c>GeoMatchSetId</c>
        /// is returned by <a>CreateGeoMatchSet</a> and by <a>ListGeoMatchSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GeoMatchSetId
        {
            get { return this._geoMatchSetId; }
            set { this._geoMatchSetId = value; }
        }

        // Check to see if GeoMatchSetId property is set
        internal bool IsSetGeoMatchSetId()
        {
            return this._geoMatchSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <c>GeoMatchSetUpdate</c> objects that you want to insert into or delete
        /// from an <a>GeoMatchSet</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GeoMatchSetUpdate</a>: Contains <c>Action</c> and <c>GeoMatchConstraint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GeoMatchConstraint</a>: Contains <c>Type</c> and <c>Value</c> 
        /// </para>
        ///  
        /// <para>
        /// You can have only one <c>Type</c> and <c>Value</c> per <c>GeoMatchConstraint</c>.
        /// To add multiple countries, include multiple <c>GeoMatchSetUpdate</c> objects in your
        /// request.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<GeoMatchSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && (this._updates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}