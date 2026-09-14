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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the ListTelemetryRules operation. Lists all telemetry
    /// rules in your account. You can filter the results by specifying a rule name prefix.
    /// </summary>
    public partial class ListTelemetryRulesRequest : AmazonObservabilityAdminRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of telemetry rules to return in a single call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of results. A previous call generates this token. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RuleNamePrefix. 
        /// <para>
        ///  A string to filter telemetry rules whose names begin with the specified prefix. 
        /// </para>
        /// </summary>
        public string RuleNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the RuleNamePrefix property is set.
        /// </summary>
        internal bool IsSetRuleNamePrefix() => this.RuleNamePrefix != null;
    }
}
