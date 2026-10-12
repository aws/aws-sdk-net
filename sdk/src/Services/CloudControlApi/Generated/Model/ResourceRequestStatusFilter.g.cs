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

namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// The filter criteria to use in determining the requests returned.
    /// </summary>
    public partial class ResourceRequestStatusFilter
    {
        /// <summary>
        /// Gets and sets the property OperationStatuses. 
        /// <para>
        /// The operation statuses to include in the filter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: The operation has been requested, but not yet initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c>: The operation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c>: The operation completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The operation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCEL_IN_PROGRESS</c>: The operation is in the process of being canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCEL_COMPLETE</c>: The operation has been canceled.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OperationStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OperationStatuses property is set.
        /// </summary>
        internal bool IsSetOperationStatuses() => this.OperationStatuses != null && (this.OperationStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// The operation types to include in the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Operations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Operations property is set.
        /// </summary>
        internal bool IsSetOperations() => this.Operations != null && (this.Operations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
