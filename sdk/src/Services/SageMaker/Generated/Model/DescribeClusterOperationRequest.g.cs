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
    /// Container for the parameters to the DescribeClusterOperation operation. Retrieves
    /// detailed information about a specific operation for a given HyperPod cluster, such
    /// as a scaling operation or a deep health check. Use the <c>OperationId</c> returned
    /// by the <c>ListClusterOperations</c> operation to identify the operation to describe.
    /// </summary>
    public partial class DescribeClusterOperationRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the HyperPod cluster associated with the
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique identifier (UUID) of the operation to describe. This ID can be obtained
        /// from the <c>ListClusterOperations</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OperationId { get; set; }

        /// <summary>
        /// Checks to see if the OperationId property is set.
        /// </summary>
        internal bool IsSetOperationId() => this.OperationId != null;
    }
}
