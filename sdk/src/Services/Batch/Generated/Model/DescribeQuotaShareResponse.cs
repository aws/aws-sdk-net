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
    /// This is the response object from the DescribeQuotaShare operation.
    /// </summary>
    public partial class DescribeQuotaShareResponse : AmazonWebServiceResponse
    {
        private List<QuotaShareCapacityLimit> _capacityLimits = AWSConfigs.InitializeCollections ? new List<QuotaShareCapacityLimit>() : null;
        private string _jobQueueArn;
        private QuotaSharePreemptionConfiguration _preemptionConfiguration;
        private string _quotaShareArn;
        private string _quotaShareName;
        private QuotaShareResourceSharingConfiguration _resourceSharingConfiguration;
        private QuotaShareState _state;
        private QuotaShareStatus _status;
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
        /// Gets and sets the property JobQueueArn. 
        /// <para>
        /// The ARN of the job queue associated with the quota share.
        /// </para>
        /// </summary>
        public string JobQueueArn
        {
            get { return this._jobQueueArn; }
            set { this._jobQueueArn = value; }
        }

        // Check to see if JobQueueArn property is set
        internal bool IsSetJobQueueArn()
        {
            return this._jobQueueArn != null;
        }

        /// <summary>
        /// Gets and sets the property PreemptionConfiguration. 
        /// <para>
        /// Specifies the preemption behavior for jobs in a quota share.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property QuotaShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quota share.
        /// </para>
        /// </summary>
        public string QuotaShareArn
        {
            get { return this._quotaShareArn; }
            set { this._quotaShareArn = value; }
        }

        // Check to see if QuotaShareArn property is set
        internal bool IsSetQuotaShareArn()
        {
            return this._quotaShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaShareName. 
        /// <para>
        /// The name of the quota share.
        /// </para>
        /// </summary>
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
        /// The state of the quota share.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the quota share.
        /// </para>
        /// </summary>
        public QuotaShareStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags applied to the quota share.
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