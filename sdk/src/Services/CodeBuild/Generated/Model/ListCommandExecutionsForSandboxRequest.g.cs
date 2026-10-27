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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the ListCommandExecutionsForSandbox operation. Gets
    /// a list of command executions for a sandbox.
    /// </summary>
    public partial class ListCommandExecutionsForSandboxRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of sandbox records to be retrieved.
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
        /// The next token, if any, to get paginated results. You will get this value from previous
        /// execution of list sandboxes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SandboxId. 
        /// <para>
        /// A <c>sandboxId</c> or <c>sandboxArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string SandboxId { get; set; }

        /// <summary>
        /// Checks to see if the SandboxId property is set.
        /// </summary>
        internal bool IsSetSandboxId() => this.SandboxId != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order in which sandbox records should be retrieved.
        /// </para>
        /// </summary>
        public SortOrderType SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
