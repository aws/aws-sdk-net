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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// You can use queues to manage the resources that are available to your AWS account
    /// for running multiple transcoding jobs at the same time. If you don't specify a queue,
    /// the service sends all jobs through the default queue. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-queues.html.
    /// </summary>
    public partial class Queue
    {
        private string _arn;
        private int? _concurrentJobs;
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _lastUpdated;
        private string _name;
        private PricingPlan _pricingPlan;
        private int? _progressingJobsCount;
        private ReservationPlan _reservationPlan;
        private List<ServiceOverride> _serviceOverrides = AWSConfigs.InitializeCollections ? new List<ServiceOverride>() : null;
        private QueueStatus _status;
        private int? _submittedJobsCount;
        private Type _type;

        /// <summary>
        /// Gets and sets the property Arn. An identifier for this resource that is unique within
        /// all of AWS.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ConcurrentJobs. The maximum number of jobs your queue can
        /// process concurrently.
        /// </summary>
        public int? ConcurrentJobs
        {
            get { return this._concurrentJobs; }
            set { this._concurrentJobs = value; }
        }

        // Check to see if ConcurrentJobs property is set
        internal bool IsSetConcurrentJobs()
        {
            return this._concurrentJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp in epoch seconds for when you
        /// created the queue.
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. An optional description that you create for
        /// each queue.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. The timestamp in epoch seconds for when you
        /// most recently updated the queue.
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. A name that you create for each queue. Each name
        /// must be unique within your account.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PricingPlan. Specifies whether the pricing plan for the
        /// queue is on-demand or reserved. For on-demand, you pay per minute, billed in increments
        /// of .01 minute. For reserved, you pay for the transcoding capacity of the entire queue,
        /// regardless of how much or how little you use it. Reserved pricing requires a 12-month
        /// commitment.
        /// </summary>
        public PricingPlan PricingPlan
        {
            get { return this._pricingPlan; }
            set { this._pricingPlan = value; }
        }

        // Check to see if PricingPlan property is set
        internal bool IsSetPricingPlan()
        {
            return this._pricingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressingJobsCount. The estimated number of jobs with
        /// a PROGRESSING status.
        /// </summary>
        public int? ProgressingJobsCount
        {
            get { return this._progressingJobsCount; }
            set { this._progressingJobsCount = value; }
        }

        // Check to see if ProgressingJobsCount property is set
        internal bool IsSetProgressingJobsCount()
        {
            return this._progressingJobsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservationPlan. Details about the pricing plan for your
        /// reserved queue. Required for reserved queues and not applicable to on-demand queues.
        /// </summary>
        public ReservationPlan ReservationPlan
        {
            get { return this._reservationPlan; }
            set { this._reservationPlan = value; }
        }

        // Check to see if ReservationPlan property is set
        internal bool IsSetReservationPlan()
        {
            return this._reservationPlan != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceOverrides. A list of any service overrides applied
        /// by MediaConvert to the settings that you have configured. If you see any overrides,
        /// we recommend that you contact AWS Support.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceOverride> ServiceOverrides
        {
            get { return this._serviceOverrides; }
            set { this._serviceOverrides = value; }
        }

        // Check to see if ServiceOverrides property is set
        internal bool IsSetServiceOverrides()
        {
            return this._serviceOverrides != null && (this._serviceOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. Queues can be ACTIVE or PAUSED. If you pause a
        /// queue, the service won't begin processing jobs in that queue. Jobs that are running
        /// when you pause the queue continue to run until they finish or result in an error.
        /// </summary>
        public QueueStatus Status
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
        /// Gets and sets the property SubmittedJobsCount. The estimated number of jobs with a
        /// SUBMITTED status.
        /// </summary>
        public int? SubmittedJobsCount
        {
            get { return this._submittedJobsCount; }
            set { this._submittedJobsCount = value; }
        }

        // Check to see if SubmittedJobsCount property is set
        internal bool IsSetSubmittedJobsCount()
        {
            return this._submittedJobsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. Specifies whether this on-demand queue is system
        /// or custom. System queues are built in. You can't modify or delete system queues. You
        /// can create and modify custom queues.
        /// </summary>
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}