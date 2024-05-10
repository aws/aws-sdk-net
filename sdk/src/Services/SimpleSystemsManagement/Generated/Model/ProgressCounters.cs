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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An aggregate of step execution statuses displayed in the Amazon Web Services Systems
    /// Manager console for a multi-Region and multi-account Automation execution.
    /// </summary>
    public partial class ProgressCounters
    {
        private int? _cancelledSteps;
        private int? _failedSteps;
        private int? _successSteps;
        private int? _timedOutSteps;
        private int? _totalSteps;

        /// <summary>
        /// Gets and sets the property CancelledSteps. 
        /// <para>
        /// The total number of steps that the system cancelled in all specified Amazon Web Services
        /// Regions and Amazon Web Services accounts for the current Automation execution.
        /// </para>
        /// </summary>
        public int? CancelledSteps
        {
            get { return this._cancelledSteps; }
            set { this._cancelledSteps = value; }
        }

        // Check to see if CancelledSteps property is set
        internal bool IsSetCancelledSteps()
        {
            return this._cancelledSteps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedSteps. 
        /// <para>
        /// The total number of steps that failed to run in all specified Amazon Web Services
        /// Regions and Amazon Web Services accounts for the current Automation execution.
        /// </para>
        /// </summary>
        public int? FailedSteps
        {
            get { return this._failedSteps; }
            set { this._failedSteps = value; }
        }

        // Check to see if FailedSteps property is set
        internal bool IsSetFailedSteps()
        {
            return this._failedSteps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuccessSteps. 
        /// <para>
        /// The total number of steps that successfully completed in all specified Amazon Web
        /// Services Regions and Amazon Web Services accounts for the current Automation execution.
        /// </para>
        /// </summary>
        public int? SuccessSteps
        {
            get { return this._successSteps; }
            set { this._successSteps = value; }
        }

        // Check to see if SuccessSteps property is set
        internal bool IsSetSuccessSteps()
        {
            return this._successSteps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimedOutSteps. 
        /// <para>
        /// The total number of steps that timed out in all specified Amazon Web Services Regions
        /// and Amazon Web Services accounts for the current Automation execution.
        /// </para>
        /// </summary>
        public int? TimedOutSteps
        {
            get { return this._timedOutSteps; }
            set { this._timedOutSteps = value; }
        }

        // Check to see if TimedOutSteps property is set
        internal bool IsSetTimedOutSteps()
        {
            return this._timedOutSteps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSteps. 
        /// <para>
        /// The total number of steps run in all specified Amazon Web Services Regions and Amazon
        /// Web Services accounts for the current Automation execution.
        /// </para>
        /// </summary>
        public int? TotalSteps
        {
            get { return this._totalSteps; }
            set { this._totalSteps = value; }
        }

        // Check to see if TotalSteps property is set
        internal bool IsSetTotalSteps()
        {
            return this._totalSteps.HasValue; 
        }

    }
}