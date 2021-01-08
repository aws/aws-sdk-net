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
    /// Container for the parameters to the DescribeStandardsControls operation.
    /// Returns a list of security standards controls.
    /// 
    ///  
    /// <para>
    /// For each control, the results include information about whether it is currently enabled,
    /// the severity, and a link to remediation information.
    /// </para>
    /// </summary>
    public partial class DescribeStandardsControlsRequest : AmazonSecurityHubRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _standardsSubscriptionArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of security standard controls to return.
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
        /// The token that is required for pagination. On your first call to the <code>DescribeStandardsControls</code>
        /// operation, set the value of this parameter to <code>NULL</code>.
        /// </para>
        ///  
        /// <para>
        /// For subsequent calls to the operation, to continue listing data, set the value of
        /// this parameter to the value returned from the previous response.
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
        /// Gets and sets the property StandardsSubscriptionArn. 
        /// <para>
        /// The ARN of a resource that represents your subscription to a supported standard. To
        /// get the subscription ARNs of the standards you have enabled, use the <code> <a>GetEnabledStandards</a>
        /// </code> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StandardsSubscriptionArn
        {
            get { return this._standardsSubscriptionArn; }
            set { this._standardsSubscriptionArn = value; }
        }

        // Check to see if StandardsSubscriptionArn property is set
        internal bool IsSetStandardsSubscriptionArn()
        {
            return this._standardsSubscriptionArn != null;
        }

    }
}