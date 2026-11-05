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

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// This is the response object from the GroupResources operation.
    /// </summary>
    public partial class GroupResourcesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// A list of Amazon resource names (ARNs) of any resources that this operation failed
        /// to add to the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedResource> Failed { get; set; } = AWSConfigs.InitializeCollections ? new List<FailedResource>() : null;

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed != null && (this.Failed.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// A list of Amazon resource names (ARNs) of any resources that this operation is still
        /// in the process adding to the group. These pending additions continue asynchronously.
        /// You can check the status of pending additions by using the <c> <a>ListGroupResources</a>
        /// </c> operation, and checking the <c>Resources</c> array in the response and the <c>Status</c>
        /// field of each object in that array. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PendingResource> Pending { get; set; } = AWSConfigs.InitializeCollections ? new List<PendingResource>() : null;

        /// <summary>
        /// Checks to see if the Pending property is set.
        /// </summary>
        internal bool IsSetPending() => this.Pending != null && (this.Pending.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Succeeded. 
        /// <para>
        /// A list of Amazon resource names (ARNs) of the resources that this operation successfully
        /// added to the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> Succeeded { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Succeeded property is set.
        /// </summary>
        internal bool IsSetSucceeded() => this.Succeeded != null && (this.Succeeded.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
