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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the ListGroupingAttributeDefinitions operation. Returns
    /// the current grouping configuration for this account, including all custom grouping
    /// attribute definitions that have been configured. These definitions determine how services
    /// are logically grouped based on telemetry attributes, Amazon Web Services tags, or
    /// predefined mappings.
    /// </summary>
    public partial class ListGroupingAttributeDefinitionsRequest : AmazonApplicationSignalsRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID to retrieve grouping attribute definitions for.
        /// Use this when accessing grouping configurations from a different account in cross-account
        /// monitoring scenarios.
        /// </para>
        /// </summary>
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// If you are using this operation in a monitoring account, specify <c>true</c> to include
        /// grouping attributes from source accounts in the returned data.
        /// </para>
        /// </summary>
        public bool? IncludeLinkedAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeLinkedAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeLinkedAccounts() => this.IncludeLinkedAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Include this value, if it was returned by the previous operation, to get the next
        /// set of grouping attribute definitions.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
