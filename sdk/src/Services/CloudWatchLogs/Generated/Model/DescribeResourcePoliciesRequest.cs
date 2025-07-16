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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeResourcePolicies operation.
    /// Lists the resource policies in this account.
    /// </summary>
    public partial class DescribeResourcePoliciesRequest : AmazonCloudWatchLogsRequest
    {
        private int? _limit;
        private string _nextToken;
        private PolicyScope _policyScope;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of resource policies to be displayed with one call of this API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property PolicyScope. 
        /// <para>
        /// Specifies the scope of the resource policy. Valid values are <c>ACCOUNT</c> or <c>RESOURCE</c>.
        /// When not specified, defaults to <c>ACCOUNT</c>.
        /// </para>
        /// </summary>
        public PolicyScope PolicyScope
        {
            get { return this._policyScope; }
            set { this._policyScope = value; }
        }

        // Check to see if PolicyScope property is set
        internal bool IsSetPolicyScope()
        {
            return this._policyScope != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the CloudWatch Logs resource for which to query the resource policy.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}