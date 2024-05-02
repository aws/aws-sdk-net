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
    /// For the action that is associated with a rule in a <c>WebACL</c>, specifies the action
    /// that you want AWS WAF to perform when a web request matches all of the conditions
    /// in a rule. For the default action in a <c>WebACL</c>, specifies the action that you
    /// want AWS WAF to take when a web request doesn't match all of the conditions in any
    /// of the rules in a <c>WebACL</c>. 
    /// </para>
    /// </summary>
    public partial class WafAction
    {
        private WafActionType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies how you want AWS WAF to respond to requests that match the settings in a
        /// <c>Rule</c>. Valid settings include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW</c>: AWS WAF allows requests
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BLOCK</c>: AWS WAF blocks requests
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COUNT</c>: AWS WAF increments a counter of the requests that match all of the
        /// conditions in the rule. AWS WAF then continues to inspect the web request based on
        /// the remaining rules in the web ACL. You can't specify <c>COUNT</c> for the default
        /// action for a <c>WebACL</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public WafActionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}