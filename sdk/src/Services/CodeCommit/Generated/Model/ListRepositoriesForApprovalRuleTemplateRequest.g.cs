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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the ListRepositoriesForApprovalRuleTemplate operation.
    /// Lists all repositories associated with the specified approval rule template.
    /// </summary>
    public partial class ListRepositoriesForApprovalRuleTemplateRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateName. 
        /// <para>
        /// The name of the approval rule template for which you want to list repositories that
        /// are associated with that template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApprovalRuleTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalRuleTemplateName property is set.
        /// </summary>
        internal bool IsSetApprovalRuleTemplateName() => this.ApprovalRuleTemplateName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A non-zero, non-negative integer used to limit the number of returned results.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that, when provided in a request, returns the next batch of the
        /// results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
