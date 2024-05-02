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
    /// Specifies the type of update to perform to an <a>GeoMatchSet</a> with <a>UpdateGeoMatchSet</a>.
    /// </para>
    /// </summary>
    public partial class GeoMatchSetUpdate
    {
        private ChangeAction _action;
        private GeoMatchConstraint _geoMatchConstraint;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies whether to insert or delete a country with <a>UpdateGeoMatchSet</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property GeoMatchConstraint. 
        /// <para>
        /// The country from which web requests originate that you want AWS WAF to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeoMatchConstraint GeoMatchConstraint
        {
            get { return this._geoMatchConstraint; }
            set { this._geoMatchConstraint = value; }
        }

        // Check to see if GeoMatchConstraint property is set
        internal bool IsSetGeoMatchConstraint()
        {
            return this._geoMatchConstraint != null;
        }

    }
}