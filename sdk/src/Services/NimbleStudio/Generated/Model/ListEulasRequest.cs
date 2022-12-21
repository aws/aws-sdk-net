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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Container for the parameters to the ListEulas operation.
    /// List EULAs.
    /// </summary>
    public partial class ListEulasRequest : AmazonNimbleStudioRequest
    {
        private List<string> _eulaIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EulaIds. 
        /// <para>
        /// The list of EULA IDs that should be returned
        /// </para>
        /// </summary>
        public List<string> EulaIds
        {
            get { return this._eulaIds; }
            set { this._eulaIds = value; }
        }

        // Check to see if EulaIds property is set
        internal bool IsSetEulaIds()
        {
            return this._eulaIds != null && this._eulaIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no more results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}