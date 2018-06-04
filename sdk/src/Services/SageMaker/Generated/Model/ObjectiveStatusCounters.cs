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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies the number of training jobs that this hyperparameter tuning job launched,
    /// categorized by the status of their objective metric. The objective metric status shows
    /// whether the final objective metric for the training job has been evaluated by the
    /// tuning job and used in the hyperparameter tuning process.
    /// </summary>
    public partial class ObjectiveStatusCounters
    {
        private int? _failed;
        private int? _pending;
        private int? _succeeded;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of training jobs whose final objective metric was not evaluated and used
        /// in the hyperparameter tuning process. This typically occurs when the training job
        /// failed or did not emit an objective metric.
        /// </para>
        /// </summary>
        public int Failed
        {
            get { return this._failed.GetValueOrDefault(); }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// The number of training jobs that are in progress and pending evaluation of their final
        /// objective metric.
        /// </para>
        /// </summary>
        public int Pending
        {
            get { return this._pending.GetValueOrDefault(); }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Succeeded. 
        /// <para>
        /// The number of training jobs whose final objective metric was evaluated by the hyperparameter
        /// tuning job and used in the hyperparameter tuning process.
        /// </para>
        /// </summary>
        public int Succeeded
        {
            get { return this._succeeded.GetValueOrDefault(); }
            set { this._succeeded = value; }
        }

        // Check to see if Succeeded property is set
        internal bool IsSetSucceeded()
        {
            return this._succeeded.HasValue; 
        }

    }
}