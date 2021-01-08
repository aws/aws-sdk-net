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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the DescribeRemediationExceptions operation.
    /// </summary>
    public partial class DescribeRemediationExceptionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RemediationException> _remediationExceptions = new List<RemediationException>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned in a previous request that you use to request
        /// the next page of results in a paginated response.
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
        /// Gets and sets the property RemediationExceptions. 
        /// <para>
        /// Returns a list of remediation exception objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<RemediationException> RemediationExceptions
        {
            get { return this._remediationExceptions; }
            set { this._remediationExceptions = value; }
        }

        // Check to see if RemediationExceptions property is set
        internal bool IsSetRemediationExceptions()
        {
            return this._remediationExceptions != null && this._remediationExceptions.Count > 0; 
        }

    }
}