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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The capacity utilization for a specific share in a fairshare scheduling job queue,
    /// including the share identifier and its current usage.
    /// </summary>
    public partial class FairshareCapacityUtilization
    {
        /// <summary>
        /// Gets and sets the property CapacityUsage. 
        /// <para>
        /// The capacity usage information for this share, including the unit of measure and quantity
        /// being used. This is <c>VCPU</c> for Amazon EC2 and <c>cpu</c> for Amazon EKS.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FairshareCapacityUsage> CapacityUsage { get; set; } = AWSConfigs.InitializeCollections ? new List<FairshareCapacityUsage>() : null;

        /// <summary>
        /// Checks to see if the CapacityUsage property is set.
        /// </summary>
        internal bool IsSetCapacityUsage() => this.CapacityUsage != null && (this.CapacityUsage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the fairshare scheduling job queue.
        /// </para>
        /// </summary>
        public string ShareIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ShareIdentifier property is set.
        /// </summary>
        internal bool IsSetShareIdentifier() => this.ShareIdentifier != null;
    }
}
