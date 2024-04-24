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
    /// Specifies the part of a web request that you want to inspect for cross-site scripting
    /// attacks and indicates whether you want to add the specification to an <a>XssMatchSet</a>
    /// or delete it from an <c>XssMatchSet</c>.
    /// </para>
    /// </summary>
    public partial class XssMatchSetUpdate
    {
        private ChangeAction _action;
        private XssMatchTuple _xssMatchTuple;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specify <c>INSERT</c> to add an <a>XssMatchSetUpdate</a> to an <a>XssMatchSet</a>.
        /// Use <c>DELETE</c> to remove an <c>XssMatchSetUpdate</c> from an <c>XssMatchSet</c>.
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
        /// Gets and sets the property XssMatchTuple. 
        /// <para>
        /// Specifies the part of a web request that you want AWS WAF to inspect for cross-site
        /// scripting attacks and, if you want AWS WAF to inspect a header, the name of the header.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public XssMatchTuple XssMatchTuple
        {
            get { return this._xssMatchTuple; }
            set { this._xssMatchTuple = value; }
        }

        // Check to see if XssMatchTuple property is set
        internal bool IsSetXssMatchTuple()
        {
            return this._xssMatchTuple != null;
        }

    }
}