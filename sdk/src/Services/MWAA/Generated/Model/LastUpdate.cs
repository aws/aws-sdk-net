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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
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
namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Describes the status of the last update on the environment, and any errors that were
    /// encountered.
    /// </summary>
    public partial class LastUpdate
    {
        private DateTime? _createdAt;
        private UpdateError _error;
        private string _source;
        private UpdateStatus _status;
        private WorkerReplacementStrategy _workerReplacementStrategy;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The day and time of the last update on the environment.
        /// </para>
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
        /// Gets and sets the property Error. 
        /// <para>
        /// The error that was encountered during the last update of the environment.
        /// </para>
        /// </summary>
        public UpdateError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the last update to the environment. Includes internal processes by Amazon
        /// MWAA, such as an environment maintenance update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the last update on the environment.
        /// </para>
        /// </summary>
        public UpdateStatus Status
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
        /// Gets and sets the property WorkerReplacementStrategy. 
        /// <para>
        /// The worker replacement strategy used in the last update of the environment.
        /// </para>
        /// </summary>
        public WorkerReplacementStrategy WorkerReplacementStrategy
        {
            get { return this._workerReplacementStrategy; }
            set { this._workerReplacementStrategy = value; }
        }

        // Check to see if WorkerReplacementStrategy property is set
        internal bool IsSetWorkerReplacementStrategy()
        {
            return this._workerReplacementStrategy != null;
        }

    }
}