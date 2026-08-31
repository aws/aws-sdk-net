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
    /// Container for the parameters to the CreateQuotaShare operation. Creates an Batch quota
    /// share. Each quota share operates as a virtual queue with a configured compute capacity,
    /// resource sharing strategy, and borrow limits.
    /// </summary>
    public partial class CreateQuotaShareRequest : AmazonBatchRequest
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
        [AWSProperty(Required = true)]
        public List<QuotaShareCapacityLimit> CapacityLimits { get; set; } = AWSConfigs.InitializeCollections ? new List<QuotaShareCapacityLimit>() : null;

        /// <summary>
        /// Checks to see if the CapacityLimits property is set.
        /// </summary>
        internal bool IsSetCapacityLimits() => this.CapacityLimits != null && (this.CapacityLimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The Batch job queue associated with the quota share. This can be the job queue name
        /// or ARN. A job queue must be in the <c>VALID</c> state before you can associate it
        /// with a quota share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueue { get; set; }

        /// <summary>
        /// Checks to see if the JobQueue property is set.
        /// </summary>
        internal bool IsSetJobQueue() => this.JobQueue != null;

        /// <summary>
        /// Gets and sets the property PreemptionConfiguration. 
        /// <para>
        /// Specifies the preemption behavior for jobs in a quota share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QuotaSharePreemptionConfiguration PreemptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PreemptionConfiguration property is set.
        /// </summary>
        internal bool IsSetPreemptionConfiguration() => this.PreemptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property QuotaShareName. 
        /// <para>
        /// The name of the quota share. It can be up to 128 characters long. It can contain uppercase
        /// and lowercase letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QuotaShareName { get; set; }

        /// <summary>
        /// Checks to see if the QuotaShareName property is set.
        /// </summary>
        internal bool IsSetQuotaShareName() => this.QuotaShareName != null;

        /// <summary>
        /// Gets and sets the property ResourceSharingConfiguration. 
        /// <para>
        /// Specifies whether a quota share reserves, lends, or both lends and borrows idle compute
        /// capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// jobs already submitted can finish. The default state is <c>ENABLED</c>.
        /// </para>
        /// </summary>
        public QuotaShareState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the quota share to help you categorize and organize your
        /// resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a> in <i>Batch User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
