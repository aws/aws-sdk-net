/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The execution status details of the cluster step.
    /// </summary>
    public partial class StepStatus
    {
        private FailureDetails _failureDetails;
        private StepState _state;
        private StepStateChangeReason _stateChangeReason;
        private StepTimeline _timeline;

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// The details for the step failure including reason, message, and log file path where
        /// the root cause was identified.
        /// </para>
        /// </summary>
        public FailureDetails FailureDetails
        {
            get { return this._failureDetails; }
            set { this._failureDetails = value; }
        }

        // Check to see if FailureDetails property is set
        internal bool IsSetFailureDetails()
        {
            return this._failureDetails != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The execution state of the cluster step.
        /// </para>
        /// </summary>
        public StepState State
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
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// The reason for the step execution status change.
        /// </para>
        /// </summary>
        public StepStateChangeReason StateChangeReason
        {
            get { return this._stateChangeReason; }
            set { this._stateChangeReason = value; }
        }

        // Check to see if StateChangeReason property is set
        internal bool IsSetStateChangeReason()
        {
            return this._stateChangeReason != null;
        }

        /// <summary>
        /// Gets and sets the property Timeline. 
        /// <para>
        /// The timeline of the cluster step status over time.
        /// </para>
        /// </summary>
        public StepTimeline Timeline
        {
            get { return this._timeline; }
            set { this._timeline = value; }
        }

        // Check to see if Timeline property is set
        internal bool IsSetTimeline()
        {
            return this._timeline != null;
        }

    }
}