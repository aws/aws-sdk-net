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
    /// This is the response object from the MoveClusterNodes operation.
    /// </summary>
    public partial class MoveClusterNodesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The instance IDs that could not be moved, each with an error code and message. The
        /// response includes this list when you specify <c>NodeIds</c>. If none of the specified
        /// nodes can be moved, the request fails and no nodes are moved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<MoveClusterNodesError> Failed { get; set; } = AWSConfigs.InitializeCollections ? new List<MoveClusterNodesError>() : null;

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed != null && (this.Failed.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailedNodeLogicalIds. 
        /// <para>
        /// The <c>NodeLogicalIds</c> that could not be moved, each with an error code and message.
        /// The response includes this list when you specify <c>NodeLogicalIds</c>. If none of
        /// the specified nodes can be moved, the request fails and no nodes are moved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<MoveClusterNodeLogicalIdsError> FailedNodeLogicalIds { get; set; } = AWSConfigs.InitializeCollections ? new List<MoveClusterNodeLogicalIdsError>() : null;

        /// <summary>
        /// Checks to see if the FailedNodeLogicalIds property is set.
        /// </summary>
        internal bool IsSetFailedNodeLogicalIds() => this.FailedNodeLogicalIds != null && (this.FailedNodeLogicalIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Successful. 
        /// <para>
        /// This list contains the instance IDs of the nodes that were accepted for the move.
        /// The response includes this list when you specify <c>NodeIds</c> or <c>InstanceCount</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Successful { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Successful property is set.
        /// </summary>
        internal bool IsSetSuccessful() => this.Successful != null && (this.Successful.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SuccessfulNodeLogicalIds. 
        /// <para>
        /// The <c>NodeLogicalIds</c> of the nodes that were accepted for the move. The response
        /// includes this list when you specify <c>NodeLogicalIds</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> SuccessfulNodeLogicalIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SuccessfulNodeLogicalIds property is set.
        /// </summary>
        internal bool IsSetSuccessfulNodeLogicalIds() => this.SuccessfulNodeLogicalIds != null && (this.SuccessfulNodeLogicalIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
