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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Details about a daemon revision, including the running task counts per capacity provider.
    /// </summary>
    public partial class DaemonRevisionDetail
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon revision.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The capacity providers associated with this daemon revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonCapacityProvider> CapacityProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<DaemonCapacityProvider>() : null;

        /// <summary>
        /// Checks to see if the CapacityProviders property is set.
        /// </summary>
        internal bool IsSetCapacityProviders() => this.CapacityProviders != null && (this.CapacityProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalRunningCount. 
        /// <para>
        /// The total number of daemon tasks running for this revision.
        /// </para>
        /// </summary>
        public int? TotalRunningCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalRunningCount property is set.
        /// </summary>
        internal bool IsSetTotalRunningCount() => this.TotalRunningCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalWithoutDaemonCount. 
        /// <para>
        /// The total number of instances running without the daemon task for this revision, across
        /// all capacity providers. These instances aren't included in <c>totalRunningCount</c>.
        /// </para>
        /// </summary>
        public int? TotalWithoutDaemonCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalWithoutDaemonCount property is set.
        /// </summary>
        internal bool IsSetTotalWithoutDaemonCount() => this.TotalWithoutDaemonCount.HasValue;
    }
}
