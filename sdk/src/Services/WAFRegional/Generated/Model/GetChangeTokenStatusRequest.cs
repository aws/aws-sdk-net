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
    /// Container for the parameters to the GetChangeTokenStatus operation.
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
    /// Returns the status of a <c>ChangeToken</c> that you got by calling <a>GetChangeToken</a>.
    /// <c>ChangeTokenStatus</c> is one of the following values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>PROVISIONED</c>: You requested the change token by calling <c>GetChangeToken</c>,
    /// but you haven't used it yet in a call to create, update, or delete an AWS WAF object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PENDING</c>: AWS WAF is propagating the create, update, or delete request to all
    /// AWS WAF servers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>INSYNC</c>: Propagation is complete.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetChangeTokenStatusRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The change token for which you want to get the status. This change token was previously
        /// returned in the <c>GetChangeToken</c> response.
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

    }
}