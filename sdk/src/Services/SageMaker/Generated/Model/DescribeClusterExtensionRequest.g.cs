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
    /// Container for the parameters to the DescribeClusterExtension operation. Retrieves
    /// information about an extension installed on a SageMaker HyperPod cluster. The information
    /// includes the extension's version, configuration, and status, and a summary of how
    /// many cluster nodes are running the current version and configuration of the extension.
    /// If the extension has problems on some nodes, the response also lists the problems
    /// and how many nodes each one affects.
    /// </summary>
    public partial class DescribeClusterExtensionRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker HyperPod cluster on which the extension
        /// is installed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ExtensionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension to describe. <c>CreateClusterExtension</c>
        /// returns this ARN, and <c>ListClusterExtensions</c> lists it. If you delete an extension
        /// and create it again, the new extension has a new ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ExtensionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionArn property is set.
        /// </summary>
        internal bool IsSetExtensionArn() => this.ExtensionArn != null;
    }
}
