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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains information about the problems that affect an extension on the nodes of a
    /// SageMaker HyperPod cluster, including how many nodes each problem affects. <c>DescribeClusterExtension</c>
    /// returns <c>ExtensionHealth</c> only when at least one node has a problem.
    /// </summary>
    public partial class ExtensionHealth
    {
        /// <summary>
        /// Gets and sets the property Issues. 
        /// <para>
        /// The problems that affect the extension, grouped by cause, from the problem that affects
        /// the most nodes to the one that affects the fewest. SageMaker HyperPod counts each
        /// node in at most one issue. The list contains at most 20 issues. If more than 20 different
        /// problems exist, the list shows the 19 that affect the most nodes, and the 20th issue
        /// has the code <c>Other</c> and counts the nodes that the remaining problems affect.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 20)]
        public List<ExtensionHealthIssue> Issues { get; set; } = AWSConfigs.InitializeCollections ? new List<ExtensionHealthIssue>() : null;

        /// <summary>
        /// Checks to see if the Issues property is set.
        /// </summary>
        internal bool IsSetIssues() => this.Issues != null && (this.Issues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
