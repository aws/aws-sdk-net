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
    /// Container for the parameters to the ListSecurityControlDefinitions operation.
    /// Lists all of the security controls that apply to a specified standard.
    /// </summary>
    public partial class ListSecurityControlDefinitionsRequest : AmazonSecurityHubRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _standardsArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  An optional parameter that limits the total results of the API response to the specified
        /// number. If this parameter isn't provided in the request, the results include the first
        /// 25 security controls that apply to the specified standard. The results also include
        /// a <code>NextToken</code> parameter that you can use in a subsequent API call to get
        /// the next 25 controls. This repeats until all controls for the standard are returned.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Optional pagination parameter. 
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

        /// <summary>
        /// Gets and sets the property StandardsArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the standard that you want to view controls for.
        /// 
        /// </para>
        /// </summary>
        public string StandardsArn
        {
            get { return this._standardsArn; }
            set { this._standardsArn = value; }
        }

        // Check to see if StandardsArn property is set
        internal bool IsSetStandardsArn()
        {
            return this._standardsArn != null;
        }

    }
}