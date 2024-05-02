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
    /// The <c>Id</c> and <c>Name</c> of an <c>XssMatchSet</c>.
    /// </para>
    /// </summary>
    public partial class XssMatchSetSummary
    {
        private string _name;
        private string _xssMatchSetId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>XssMatchSet</c>, if any, specified by <c>Id</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property XssMatchSetId. 
        /// <para>
        /// A unique identifier for an <c>XssMatchSet</c>. You use <c>XssMatchSetId</c> to get
        /// information about a <c>XssMatchSet</c> (see <a>GetXssMatchSet</a>), update an <c>XssMatchSet</c>
        /// (see <a>UpdateXssMatchSet</a>), insert an <c>XssMatchSet</c> into a <c>Rule</c> or
        /// delete one from a <c>Rule</c> (see <a>UpdateRule</a>), and delete an <c>XssMatchSet</c>
        /// from AWS WAF (see <a>DeleteXssMatchSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <c>XssMatchSetId</c> is returned by <a>CreateXssMatchSet</a> and by <a>ListXssMatchSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string XssMatchSetId
        {
            get { return this._xssMatchSetId; }
            set { this._xssMatchSetId = value; }
        }

        // Check to see if XssMatchSetId property is set
        internal bool IsSetXssMatchSetId()
        {
            return this._xssMatchSetId != null;
        }

    }
}