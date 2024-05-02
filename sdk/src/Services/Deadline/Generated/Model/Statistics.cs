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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// A list of statistics for a session.
    /// </summary>
    public partial class Statistics
    {
        private DateTime? _aggregationEndTime;
        private DateTime? _aggregationStartTime;
        private Stats _costInUsd;
        private int? _count;
        private string _fleetId;
        private string _instanceType;
        private string _jobId;
        private string _jobName;
        private string _licenseProduct;
        private string _queueId;
        private Stats _runtimeInSeconds;
        private UsageType _usageType;
        private string _userId;

        /// <summary>
        /// Gets and sets the property AggregationEndTime. 
        /// <para>
        /// The end time for the aggregation.
        /// </para>
        /// </summary>
        public DateTime? AggregationEndTime
        {
            get { return this._aggregationEndTime; }
            set { this._aggregationEndTime = value; }
        }

        // Check to see if AggregationEndTime property is set
        internal bool IsSetAggregationEndTime()
        {
            return this._aggregationEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AggregationStartTime. 
        /// <para>
        /// The start time for the aggregation.
        /// </para>
        /// </summary>
        public DateTime? AggregationStartTime
        {
            get { return this._aggregationStartTime; }
            set { this._aggregationStartTime = value; }
        }

        // Check to see if AggregationStartTime property is set
        internal bool IsSetAggregationStartTime()
        {
            return this._aggregationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CostInUsd. 
        /// <para>
        /// How the statistics should appear in USD. Options include: minimum, maximum, average
        /// or sum.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Stats CostInUsd
        {
            get { return this._costInUsd; }
            set { this._costInUsd = value; }
        }

        // Check to see if CostInUsd property is set
        internal bool IsSetCostInUsd()
        {
            return this._costInUsd != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of instances in a list of statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The fleet ID.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The job name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseProduct. 
        /// <para>
        /// The licensed product.
        /// </para>
        /// </summary>
        public string LicenseProduct
        {
            get { return this._licenseProduct; }
            set { this._licenseProduct = value; }
        }

        // Check to see if LicenseProduct property is set
        internal bool IsSetLicenseProduct()
        {
            return this._licenseProduct != null;
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue ID.
        /// </para>
        /// </summary>
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeInSeconds. 
        /// <para>
        /// The total aggregated runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Stats RuntimeInSeconds
        {
            get { return this._runtimeInSeconds; }
            set { this._runtimeInSeconds = value; }
        }

        // Check to see if RuntimeInSeconds property is set
        internal bool IsSetRuntimeInSeconds()
        {
            return this._runtimeInSeconds != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The type of usage for the statistics.
        /// </para>
        /// </summary>
        public UsageType UsageType
        {
            get { return this._usageType; }
            set { this._usageType = value; }
        }

        // Check to see if UsageType property is set
        internal bool IsSetUsageType()
        {
            return this._usageType != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}