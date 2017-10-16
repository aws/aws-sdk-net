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
    /// Contains one or more countries that AWS WAF will search for.
    /// </summary>
    public partial class GeoMatchSet
    {
        private List<GeoMatchConstraint> _geoMatchConstraints = new List<GeoMatchConstraint>();
        private string _geoMatchSetId;
        private string _name;

        /// <summary>
        /// Gets and sets the property GeoMatchConstraints. 
        /// <para>
        /// An array of <a>GeoMatchConstraint</a> objects, which contain the country that you
        /// want AWS WAF to search for.
        /// </para>
        /// </summary>
        public List<GeoMatchConstraint> GeoMatchConstraints
        {
            get { return this._geoMatchConstraints; }
            set { this._geoMatchConstraints = value; }
        }

        // Check to see if GeoMatchConstraints property is set
        internal bool IsSetGeoMatchConstraints()
        {
            return this._geoMatchConstraints != null && this._geoMatchConstraints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GeoMatchSetId. 
        /// <para>
        /// The <code>GeoMatchSetId</code> for an <code>GeoMatchSet</code>. You use <code>GeoMatchSetId</code>
        /// to get information about a <code>GeoMatchSet</code> (see <a>GeoMatchSet</a>), update
        /// a <code>GeoMatchSet</code> (see <a>UpdateGeoMatchSet</a>), insert a <code>GeoMatchSet</code>
        /// into a <code>Rule</code> or delete one from a <code>Rule</code> (see <a>UpdateRule</a>),
        /// and delete a <code>GeoMatchSet</code> from AWS WAF (see <a>DeleteGeoMatchSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <code>GeoMatchSetId</code> is returned by <a>CreateGeoMatchSet</a> and by <a>ListGeoMatchSets</a>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>GeoMatchSet</a>. You can't change the name
        /// of an <code>GeoMatchSet</code> after you create it.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}