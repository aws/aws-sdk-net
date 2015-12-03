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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the GetIPSet operation.
    /// Returns the <a>IPSet</a> that is specified by <code>IPSetId</code>.
    /// </summary>
    public partial class GetIPSetRequest : AmazonWAFRequest
    {
        private string _ipSetId;

        /// <summary>
        /// Gets and sets the property IPSetId. 
        /// <para>
        /// The <code>IPSetId</code> of the <a>IPSet</a> that you want to get. <code>IPSetId</code>
        /// is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.
        /// </para>
        /// </summary>
        public string IPSetId
        {
            get { return this._ipSetId; }
            set { this._ipSetId = value; }
        }

        // Check to see if IPSetId property is set
        internal bool IsSetIPSetId()
        {
            return this._ipSetId != null;
        }

    }
}