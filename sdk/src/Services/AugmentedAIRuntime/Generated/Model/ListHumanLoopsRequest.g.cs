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

namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the ListHumanLoops operation. Returns information
    /// about human loops, given the specified parameters. If a human loop was deleted, it
    /// will not be included.
    /// </summary>
    public partial class ListHumanLoopsRequest : AmazonAugmentedAIRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// (Optional) The timestamp of the date when you want the human loops to begin in ISO
        /// 8601 format. For example, <c>2020-02-24</c>.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeAfter property is set.
        /// </summary>
        internal bool IsSetCreationTimeAfter() => this.CreationTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// (Optional) The timestamp of the date before which you want the human loops to begin
        /// in ISO 8601 format. For example, <c>2020-02-24</c>.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property FlowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string FlowDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinitionArn property is set.
        /// </summary>
        internal bool IsSetFlowDefinitionArn() => this.FlowDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of items to return. If the total number of available items is more
        /// than the value specified in <c>MaxResults</c>, then a <c>NextToken</c> is returned
        /// in the output. You can use this token to display the next page of results. 
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
        /// A token to display the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Optional. The order for displaying results. Valid values: <c>Ascending</c> and <c>Descending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
