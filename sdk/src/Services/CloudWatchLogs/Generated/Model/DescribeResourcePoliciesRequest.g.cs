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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeResourcePolicies operation. Lists the
    /// resource policies in this account.
    /// </summary>
    public partial class DescribeResourcePoliciesRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of resource policies to be displayed with one call of this API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PolicyScope. 
        /// <para>
        /// Specifies the scope of the resource policy. Valid values are <c>ACCOUNT</c> or <c>RESOURCE</c>.
        /// When not specified, defaults to <c>ACCOUNT</c>.
        /// </para>
        /// </summary>
        public PolicyScope PolicyScope { get; set; }

        /// <summary>
        /// Checks to see if the PolicyScope property is set.
        /// </summary>
        internal bool IsSetPolicyScope() => this.PolicyScope != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the CloudWatch Logs resource for which to query the resource policy.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
