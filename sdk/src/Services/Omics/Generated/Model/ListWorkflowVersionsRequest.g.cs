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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the ListWorkflowVersions operation. Lists the workflow
    /// versions for the specified workflow. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-versions.html">Workflow
    /// versioning in Amazon Web Services HealthOmics</a> in the <i>Amazon Web Services HealthOmics
    /// User Guide</i>.
    /// </summary>
    public partial class ListWorkflowVersionsRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of workflows to return in one page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property StartingToken. 
        /// <para>
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StartingToken { get; set; }

        /// <summary>
        /// Checks to see if the StartingToken property is set.
        /// </summary>
        internal bool IsSetStartingToken() => this.StartingToken != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The workflow type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public WorkflowType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The workflow's ID. The <c>workflowId</c> is not the UUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 18)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;

        /// <summary>
        /// Gets and sets the property WorkflowOwnerId. 
        /// <para>
        /// The 12-digit account ID of the workflow owner. The workflow owner ID can be retrieved
        /// using the <c>GetShare</c> API operation. If you are the workflow owner, you do not
        /// need to include this ID.
        /// </para>
        /// </summary>
        public string WorkflowOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowOwnerId property is set.
        /// </summary>
        internal bool IsSetWorkflowOwnerId() => this.WorkflowOwnerId != null;
    }
}
