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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Contains summary information about a spending limit, including current spending status
    /// and configuration details.
    /// </summary>
    public partial class SpendingLimitSummary
    {
        private DateTime? _createdAt;
        private string _deviceArn;
        private string _queuedSpend;
        private string _spendingLimit;
        private string _spendingLimitArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TimePeriod _timePeriod;
        private string _totalSpend;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the spending limit was created, in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quantum device associated with this spending
        /// limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property QueuedSpend. 
        /// <para>
        /// The amount currently queued for spending on the device, in USD.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueuedSpend
        {
            get { return this._queuedSpend; }
            set { this._queuedSpend = value; }
        }

        // Check to see if QueuedSpend property is set
        internal bool IsSetQueuedSpend()
        {
            return this._queuedSpend != null;
        }

        /// <summary>
        /// Gets and sets the property SpendingLimit. 
        /// <para>
        /// The maximum spending amount allowed for the device during the specified time period,
        /// in USD.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SpendingLimit
        {
            get { return this._spendingLimit; }
            set { this._spendingLimit = value; }
        }

        // Check to see if SpendingLimit property is set
        internal bool IsSetSpendingLimit()
        {
            return this._spendingLimit != null;
        }

        /// <summary>
        /// Gets and sets the property SpendingLimitArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the spending limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string SpendingLimitArn
        {
            get { return this._spendingLimitArn; }
            set { this._spendingLimitArn = value; }
        }

        // Check to see if SpendingLimitArn property is set
        internal bool IsSetSpendingLimitArn()
        {
            return this._spendingLimitArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the spending limit. Each tag consists of a key and an optional
        /// value.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period during which the spending limit is active.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimePeriod TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSpend. 
        /// <para>
        /// The total amount spent on the device so far during the current time period, in USD.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalSpend
        {
            get { return this._totalSpend; }
            set { this._totalSpend = value; }
        }

        // Check to see if TotalSpend property is set
        internal bool IsSetTotalSpend()
        {
            return this._totalSpend != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the spending limit was last modified, in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}