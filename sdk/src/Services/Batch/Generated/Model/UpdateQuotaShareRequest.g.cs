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
    /// Container for the parameters to the UpdateQuotaShare operation. Updates a quota share.
    /// </summary>
    public partial class UpdateQuotaShareRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// A list that specifies the quantity and type of compute capacity allocated to the quota
        /// share.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QuotaShareCapacityLimit> CapacityLimits { get; set; } = AWSConfigs.InitializeCollections ? new List<QuotaShareCapacityLimit>() : null;

        /// <summary>
        /// Checks to see if the CapacityLimits property is set.
        /// </summary>
        internal bool IsSetCapacityLimits() => this.CapacityLimits != null && (this.CapacityLimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreemptionConfiguration. 
        /// <para>
        /// Specifies the preemption behavior for jobs in a quota share.
        /// </para>
        /// </summary>
        public QuotaSharePreemptionConfiguration PreemptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PreemptionConfiguration property is set.
        /// </summary>
        internal bool IsSetPreemptionConfiguration() => this.PreemptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property QuotaShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quota share to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QuotaShareArn { get; set; }

        /// <summary>
        /// Checks to see if the QuotaShareArn property is set.
        /// </summary>
        internal bool IsSetQuotaShareArn() => this.QuotaShareArn != null;

        /// <summary>
        /// Gets and sets the property ResourceSharingConfiguration. 
        /// <para>
        /// Specifies whether a quota share reserves, lends, or both lends and borrows idle compute
        /// capacity.
        /// </para>
        /// </summary>
        public QuotaShareResourceSharingConfiguration ResourceSharingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSharingConfiguration property is set.
        /// </summary>
        internal bool IsSetResourceSharingConfiguration() => this.ResourceSharingConfiguration != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the quota share. If the quota share is <c>ENABLED</c>, it is able to
        /// accept jobs. If the quota share is <c>DISABLED</c>, new jobs won't be accepted but
        /// jobs already submitted can finish.
        /// </para>
        /// </summary>
        public QuotaShareState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
