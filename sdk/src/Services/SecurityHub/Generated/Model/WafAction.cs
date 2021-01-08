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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about the action that CloudFront or AWS WAF takes when a web request matches
    /// the conditions in the rule.
    /// </summary>
    public partial class WafAction
    {
        private string _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies how you want AWS WAF to respond to requests that match the settings in a
        /// rule.
        /// </para>
        ///  
        /// <para>
        /// Valid settings include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALLOW</code> - AWS WAF allows requests
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BLOCK</code> - AWS WAF blocks requests
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COUNT</code> - AWS WAF increments a counter of the requests that match all
        /// of the conditions in the rule. AWS WAF then continues to inspect the web request based
        /// on the remaining rules in the web ACL. You can't specify <code>COUNT</code> for the
        /// default action for a WebACL.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type
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