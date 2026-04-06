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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
    /// Container for the parameters to the CreateQuotaShare operation.
    /// Creates an Batch quota share. Each quota share operates as a virtual queue with a
    /// configured compute capacity, resource sharing strategy, and borrow limits.
    /// </summary>
    public partial class CreateQuotaShareRequest : AmazonBatchRequest
    {
        private List<QuotaShareCapacityLimit> _capacityLimits = AWSConfigs.InitializeCollections ? new List<QuotaShareCapacityLimit>() : null;
        private string _jobQueue;
        private QuotaSharePreemptionConfiguration _preemptionConfiguration;
        private string _quotaShareName;
        private QuotaShareResourceSharingConfiguration _resourceSharingConfiguration;
        private QuotaShareState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// A list that specifies the quantity and type of compute capacity allocated to the quota
        /// share. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<QuotaShareCapacityLimit> CapacityLimits
        {
            get { return this._capacityLimits; }
            set { this._capacityLimits = value; }
        }

        // Check to see if CapacityLimits property is set
        internal bool IsSetCapacityLimits()
        {
            return this._capacityLimits != null && (this._capacityLimits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The Batch job queue associated with the quota share. This can be the job queue name
        /// or ARN. A job queue must be in the <c>VALID</c> state before you can associate it
        /// with a quota share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobQueue
        {
            get { return this._jobQueue; }
            set { this._jobQueue = value; }
        }

        // Check to see if JobQueue property is set
        internal bool IsSetJobQueue()
        {
            return this._jobQueue != null;
        }

        /// <summary>
        /// Gets and sets the property PreemptionConfiguration. 
        /// <para>
        /// Specifies the preemption behavior for jobs in a quota share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuotaSharePreemptionConfiguration PreemptionConfiguration
        {
            get { return this._preemptionConfiguration; }
            set { this._preemptionConfiguration = value; }
        }

        // Check to see if PreemptionConfiguration property is set
        internal bool IsSetPreemptionConfiguration()
        {
            return this._preemptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaShareName. 
        /// <para>
        /// The name of the quota share. It can be up to 128 characters long. It can contain uppercase
        /// and lowercase letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QuotaShareName
        {
            get { return this._quotaShareName; }
            set { this._quotaShareName = value; }
        }

        // Check to see if QuotaShareName property is set
        internal bool IsSetQuotaShareName()
        {
            return this._quotaShareName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSharingConfiguration. 
        /// <para>
        /// Specifies whether a quota share reserves, lends, or both lends and borrows idle compute
        /// capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuotaShareResourceSharingConfiguration ResourceSharingConfiguration
        {
            get { return this._resourceSharingConfiguration; }
            set { this._resourceSharingConfiguration = value; }
        }

        // Check to see if ResourceSharingConfiguration property is set
        internal bool IsSetResourceSharingConfiguration()
        {
            return this._resourceSharingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the quota share. If the quota share is <c>ENABLED</c>, it is able to
        /// accept jobs. If the quota share is <c>DISABLED</c>, new jobs won't be accepted but
        /// jobs already submitted can finish. The default state is <c>ENABLED</c>.
        /// </para>
        /// </summary>
        public QuotaShareState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the quota share to help you categorize and organize your
        /// resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a> in <i>Batch User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}