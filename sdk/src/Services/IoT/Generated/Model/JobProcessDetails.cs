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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The job process details.
    /// </summary>
    public partial class JobProcessDetails
    {
        private int? _numberOfCanceledThings;
        private int? _numberOfFailedThings;
        private int? _numberOfInProgressThings;
        private int? _numberOfQueuedThings;
        private int? _numberOfRejectedThings;
        private int? _numberOfRemovedThings;
        private int? _numberOfSucceededThings;
        private int? _numberOfTimedOutThings;
        private List<string> _processingTargets = new List<string>();

        /// <summary>
        /// Gets and sets the property NumberOfCanceledThings. 
        /// <para>
        /// The number of things that cancelled the job.
        /// </para>
        /// </summary>
        public int NumberOfCanceledThings
        {
            get { return this._numberOfCanceledThings.GetValueOrDefault(); }
            set { this._numberOfCanceledThings = value; }
        }

        // Check to see if NumberOfCanceledThings property is set
        internal bool IsSetNumberOfCanceledThings()
        {
            return this._numberOfCanceledThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfFailedThings. 
        /// <para>
        /// The number of things that failed executing the job.
        /// </para>
        /// </summary>
        public int NumberOfFailedThings
        {
            get { return this._numberOfFailedThings.GetValueOrDefault(); }
            set { this._numberOfFailedThings = value; }
        }

        // Check to see if NumberOfFailedThings property is set
        internal bool IsSetNumberOfFailedThings()
        {
            return this._numberOfFailedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfInProgressThings. 
        /// <para>
        /// The number of things currently executing the job.
        /// </para>
        /// </summary>
        public int NumberOfInProgressThings
        {
            get { return this._numberOfInProgressThings.GetValueOrDefault(); }
            set { this._numberOfInProgressThings = value; }
        }

        // Check to see if NumberOfInProgressThings property is set
        internal bool IsSetNumberOfInProgressThings()
        {
            return this._numberOfInProgressThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfQueuedThings. 
        /// <para>
        /// The number of things that are awaiting execution of the job.
        /// </para>
        /// </summary>
        public int NumberOfQueuedThings
        {
            get { return this._numberOfQueuedThings.GetValueOrDefault(); }
            set { this._numberOfQueuedThings = value; }
        }

        // Check to see if NumberOfQueuedThings property is set
        internal bool IsSetNumberOfQueuedThings()
        {
            return this._numberOfQueuedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRejectedThings. 
        /// <para>
        /// The number of things that rejected the job.
        /// </para>
        /// </summary>
        public int NumberOfRejectedThings
        {
            get { return this._numberOfRejectedThings.GetValueOrDefault(); }
            set { this._numberOfRejectedThings = value; }
        }

        // Check to see if NumberOfRejectedThings property is set
        internal bool IsSetNumberOfRejectedThings()
        {
            return this._numberOfRejectedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRemovedThings. 
        /// <para>
        /// The number of things that are no longer scheduled to execute the job because they
        /// have been deleted or have been removed from the group that was a target of the job.
        /// </para>
        /// </summary>
        public int NumberOfRemovedThings
        {
            get { return this._numberOfRemovedThings.GetValueOrDefault(); }
            set { this._numberOfRemovedThings = value; }
        }

        // Check to see if NumberOfRemovedThings property is set
        internal bool IsSetNumberOfRemovedThings()
        {
            return this._numberOfRemovedThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfSucceededThings. 
        /// <para>
        /// The number of things which successfully completed the job.
        /// </para>
        /// </summary>
        public int NumberOfSucceededThings
        {
            get { return this._numberOfSucceededThings.GetValueOrDefault(); }
            set { this._numberOfSucceededThings = value; }
        }

        // Check to see if NumberOfSucceededThings property is set
        internal bool IsSetNumberOfSucceededThings()
        {
            return this._numberOfSucceededThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfTimedOutThings. 
        /// <para>
        /// The number of things whose job execution status is <code>TIMED_OUT</code>.
        /// </para>
        /// </summary>
        public int NumberOfTimedOutThings
        {
            get { return this._numberOfTimedOutThings.GetValueOrDefault(); }
            set { this._numberOfTimedOutThings = value; }
        }

        // Check to see if NumberOfTimedOutThings property is set
        internal bool IsSetNumberOfTimedOutThings()
        {
            return this._numberOfTimedOutThings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProcessingTargets. 
        /// <para>
        /// The target devices to which the job execution is being rolled out. This value will
        /// be null after the job execution has finished rolling out to all the target devices.
        /// </para>
        /// </summary>
        public List<string> ProcessingTargets
        {
            get { return this._processingTargets; }
            set { this._processingTargets = value; }
        }

        // Check to see if ProcessingTargets property is set
        internal bool IsSetProcessingTargets()
        {
            return this._processingTargets != null && this._processingTargets.Count > 0; 
        }

    }
}