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
    /// Container for the parameters to the DeleteClusterExtension operation. Deletes an extension
    /// from a SageMaker HyperPod cluster. SageMaker HyperPod removes the extension's software
    /// from every node in the cluster. While SageMaker HyperPod removes the extension, its
    /// status is <c>Deleting</c>. After SageMaker HyperPod removes the extension from all
    /// nodes, it no longer appears in <c>ListClusterExtensions</c>, and <c>DescribeClusterExtension</c>
    /// returns a <c>ResourceNotFound</c> error. <para> Deleting an extension doesn't delete
    /// data that the extension sent to other Amazon Web Services services, such as metrics
    /// in Amazon CloudWatch or Amazon Managed Service for Prometheus. </para>
    /// </summary>
    public partial class DeleteClusterExtensionRequest : AmazonSageMakerRequest
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
        /// The Amazon Resource Name (ARN) of the extension to delete.
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
