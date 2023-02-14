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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Details about an instance refresh rollback.
    /// </summary>
    public partial class RollbackDetails
    {
        private int? _instancesToUpdateOnRollback;
        private int? _percentageCompleteOnRollback;
        private InstanceRefreshProgressDetails _progressDetailsOnRollback;
        private string _rollbackReason;
        private DateTime? _rollbackStartTime;

        /// <summary>
        /// Gets and sets the property InstancesToUpdateOnRollback. 
        /// <para>
        /// Indicates the value of <code>InstancesToUpdate</code> at the time the rollback started.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int InstancesToUpdateOnRollback
        {
            get { return this._instancesToUpdateOnRollback.GetValueOrDefault(); }
            set { this._instancesToUpdateOnRollback = value; }
        }

        // Check to see if InstancesToUpdateOnRollback property is set
        internal bool IsSetInstancesToUpdateOnRollback()
        {
            return this._instancesToUpdateOnRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentageCompleteOnRollback. 
        /// <para>
        /// Indicates the value of <code>PercentageComplete</code> at the time the rollback started.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int PercentageCompleteOnRollback
        {
            get { return this._percentageCompleteOnRollback.GetValueOrDefault(); }
            set { this._percentageCompleteOnRollback = value; }
        }

        // Check to see if PercentageCompleteOnRollback property is set
        internal bool IsSetPercentageCompleteOnRollback()
        {
            return this._percentageCompleteOnRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressDetailsOnRollback.
        /// </summary>
        public InstanceRefreshProgressDetails ProgressDetailsOnRollback
        {
            get { return this._progressDetailsOnRollback; }
            set { this._progressDetailsOnRollback = value; }
        }

        // Check to see if ProgressDetailsOnRollback property is set
        internal bool IsSetProgressDetailsOnRollback()
        {
            return this._progressDetailsOnRollback != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackReason. 
        /// <para>
        /// The reason for this instance refresh rollback (for example, whether a manual or automatic
        /// rollback was initiated).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1023)]
        public string RollbackReason
        {
            get { return this._rollbackReason; }
            set { this._rollbackReason = value; }
        }

        // Check to see if RollbackReason property is set
        internal bool IsSetRollbackReason()
        {
            return this._rollbackReason != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackStartTime. 
        /// <para>
        /// The date and time at which the rollback began.
        /// </para>
        /// </summary>
        public DateTime RollbackStartTime
        {
            get { return this._rollbackStartTime.GetValueOrDefault(); }
            set { this._rollbackStartTime = value; }
        }

        // Check to see if RollbackStartTime property is set
        internal bool IsSetRollbackStartTime()
        {
            return this._rollbackStartTime.HasValue; 
        }

    }
}