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

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the CreateIPSet operation.
    /// </summary>
    public partial class CreateIPSetResponse : AmazonWebServiceResponse
    {
        private string _changeToken;
        private IPSet _ipSet;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The <code>ChangeToken</code> that you used to submit the <code>CreateIPSet</code>
        /// request. You can also use this value to query the status of the request. For more
        /// information, see <a>GetChangeTokenStatus</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property IPSet. 
        /// <para>
        /// The <a>IPSet</a> returned in the <code>CreateIPSet</code> response.
        /// </para>
        /// </summary>
        public IPSet IPSet
        {
            get { return this._ipSet; }
            set { this._ipSet = value; }
        }

        // Check to see if IPSet property is set
        internal bool IsSetIPSet()
        {
            return this._ipSet != null;
        }

    }
}