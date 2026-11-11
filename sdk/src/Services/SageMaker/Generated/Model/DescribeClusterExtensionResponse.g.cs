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
    /// This is the response object from the DescribeClusterExtension operation.
    /// </summary>
    public partial class DescribeClusterExtensionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExtensionDetails. 
        /// <para>
        /// The details of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtensionDetails ExtensionDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionDetails property is set.
        /// </summary>
        internal bool IsSetExtensionDetails() => this.ExtensionDetails != null;

        /// <summary>
        /// Gets and sets the property NodeSummary. 
        /// <para>
        /// A summary of how many nodes in your cluster the extension targets, and how many of
        /// them run the extension's current version and configuration.
        /// </para>
        /// </summary>
        public ExtensionNodeSummary NodeSummary { get; set; }

        /// <summary>
        /// Checks to see if the NodeSummary property is set.
        /// </summary>
        internal bool IsSetNodeSummary() => this.NodeSummary != null;
    }
}
