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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object representing a job attempt.
    /// </summary>
    public partial class AttemptDetail
    {
        private AttemptContainerDetail _container;
        private long? _startedAt;
        private string _statusReason;
        private long? _stoppedAt;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// Details about the container in this job attempt.
        /// </para>
        /// </summary>
        public AttemptContainerDetail Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix time stamp (in seconds and milliseconds) for when the attempt was started
        /// (when the attempt transitioned from the <code>STARTING</code> state to the <code>RUNNING</code>
        /// state).
        /// </para>
        /// </summary>
        public long StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide additional details about the current status
        /// of the job attempt.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix time stamp (in seconds and milliseconds) for when the attempt was stopped
        /// (when the attempt transitioned from the <code>RUNNING</code> state to a terminal state,
        /// such as <code>SUCCEEDED</code> or <code>FAILED</code>).
        /// </para>
        /// </summary>
        public long StoppedAt
        {
            get { return this._stoppedAt.GetValueOrDefault(); }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

    }
}