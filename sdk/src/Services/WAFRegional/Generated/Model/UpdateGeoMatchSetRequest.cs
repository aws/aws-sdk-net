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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGeoMatchSet operation.
    /// Inserts or deletes <a>GeoMatchConstraint</a> objects in an <code>GeoMatchSet</code>.
    /// For each <code>GeoMatchConstraint</code> object, you specify the following values:
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Whether to insert or delete the object from the array. If you want to change an <code>GeoMatchConstraint</code>
    /// object, you delete the existing object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>Type</code>. The only valid value for <code>Type</code> is <code>Country</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>Value</code>, which is a two character code for the country to add to the
    /// <code>GeoMatchConstraint</code> object. Valid codes are listed in <a>GeoMatchConstraint$Value</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To create and configure an <code>GeoMatchSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Submit a <a>CreateGeoMatchSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <a>UpdateGeoMatchSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <code>UpdateGeoMatchSet</code> request to specify the country that you want
    /// AWS WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// When you update an <code>GeoMatchSet</code>, you specify the country that you want
    /// to add and/or the country that you want to delete. If you want to change a country,
    /// you delete the existing country and add the new one.
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
        private List<GeoMatchSetUpdate> _updates = new List<GeoMatchSetUpdate>();

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
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
        /// The <code>GeoMatchSetId</code> of the <a>GeoMatchSet</a> that you want to update.
        /// <code>GeoMatchSetId</code> is returned by <a>CreateGeoMatchSet</a> and by <a>ListGeoMatchSets</a>.
        /// </para>
        /// </summary>
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
        /// An array of <code>GeoMatchSetUpdate</code> objects that you want to insert into or
        /// delete from an <a>GeoMatchSet</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GeoMatchSetUpdate</a>: Contains <code>Action</code> and <code>GeoMatchConstraint</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GeoMatchConstraint</a>: Contains <code>Type</code> and <code>Value</code> 
        /// </para>
        ///  
        /// <para>
        /// You can have only one <code>Type</code> and <code>Value</code> per <code>GeoMatchConstraint</code>.
        /// To add multiple countries, include multiple <code>GeoMatchSetUpdate</code> objects
        /// in your request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<GeoMatchSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

    }
}