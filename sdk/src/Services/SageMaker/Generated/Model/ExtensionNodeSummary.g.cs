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
    /// A summary of an extension's installation across the nodes of a SageMaker HyperPod
    /// cluster.
    /// </summary>
    public partial class ExtensionNodeSummary
    {
        /// <summary>
        /// Gets and sets the property ActiveCount. 
        /// <para>
        /// The number of nodes that are running the extension's current version and configuration.
        /// Nodes that report the extension as unhealthy aren't counted. While SageMaker HyperPod
        /// creates or updates the extension, <c>ActiveCount</c> is lower than <c>TotalCount</c>.
        /// To see why nodes aren't counted, see <c>Health</c> in <c>DescribeClusterExtension</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? ActiveCount { get; set; }

        /// <summary>
        /// Checks to see if the ActiveCount property is set.
        /// </summary>
        internal bool IsSetActiveCount() => this.ActiveCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The number of nodes in your cluster that the extension targets. SageMaker HyperPod
        /// targets every running node in your cluster, including nodes that you add after you
        /// create the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;
    }
}
