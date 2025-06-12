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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
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
    /// Contains one or more countries that AWS WAF will search for.
    /// </para>
    /// </summary>
    public partial class GeoMatchSet
    {
        private List<GeoMatchConstraint> _geoMatchConstraints = AWSConfigs.InitializeCollections ? new List<GeoMatchConstraint>() : null;
        private string _geoMatchSetId;
        private string _name;

        /// <summary>
        /// Gets and sets the property GeoMatchConstraints. 
        /// <para>
        /// An array of <a>GeoMatchConstraint</a> objects, which contain the country that you
        /// want AWS WAF to search for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GeoMatchConstraint> GeoMatchConstraints
        {
            get { return this._geoMatchConstraints; }
            set { this._geoMatchConstraints = value; }
        }

        // Check to see if GeoMatchConstraints property is set
        internal bool IsSetGeoMatchConstraints()
        {
            return this._geoMatchConstraints != null && (this._geoMatchConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GeoMatchSetId. 
        /// <para>
        /// The <c>GeoMatchSetId</c> for an <c>GeoMatchSet</c>. You use <c>GeoMatchSetId</c> to
        /// get information about a <c>GeoMatchSet</c> (see <a>GeoMatchSet</a>), update a <c>GeoMatchSet</c>
        /// (see <a>UpdateGeoMatchSet</a>), insert a <c>GeoMatchSet</c> into a <c>Rule</c> or
        /// delete one from a <c>Rule</c> (see <a>UpdateRule</a>), and delete a <c>GeoMatchSet</c>
        /// from AWS WAF (see <a>DeleteGeoMatchSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <c>GeoMatchSetId</c> is returned by <a>CreateGeoMatchSet</a> and by <a>ListGeoMatchSets</a>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>GeoMatchSet</a>. You can't change the name
        /// of an <c>GeoMatchSet</c> after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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