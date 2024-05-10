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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Statistics for the checks performed during the audit.
    /// </summary>
    public partial class TaskStatistics
    {
        private int? _canceledChecks;
        private int? _compliantChecks;
        private int? _failedChecks;
        private int? _inProgressChecks;
        private int? _nonCompliantChecks;
        private int? _totalChecks;
        private int? _waitingForDataCollectionChecks;

        /// <summary>
        /// Gets and sets the property CanceledChecks. 
        /// <para>
        /// The number of checks that did not run because the audit was canceled.
        /// </para>
        /// </summary>
        public int? CanceledChecks
        {
            get { return this._canceledChecks; }
            set { this._canceledChecks = value; }
        }

        // Check to see if CanceledChecks property is set
        internal bool IsSetCanceledChecks()
        {
            return this._canceledChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompliantChecks. 
        /// <para>
        /// The number of checks that found compliant resources.
        /// </para>
        /// </summary>
        public int? CompliantChecks
        {
            get { return this._compliantChecks; }
            set { this._compliantChecks = value; }
        }

        // Check to see if CompliantChecks property is set
        internal bool IsSetCompliantChecks()
        {
            return this._compliantChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedChecks. 
        /// <para>
        /// The number of checks.
        /// </para>
        /// </summary>
        public int? FailedChecks
        {
            get { return this._failedChecks; }
            set { this._failedChecks = value; }
        }

        // Check to see if FailedChecks property is set
        internal bool IsSetFailedChecks()
        {
            return this._failedChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InProgressChecks. 
        /// <para>
        /// The number of checks in progress.
        /// </para>
        /// </summary>
        public int? InProgressChecks
        {
            get { return this._inProgressChecks; }
            set { this._inProgressChecks = value; }
        }

        // Check to see if InProgressChecks property is set
        internal bool IsSetInProgressChecks()
        {
            return this._inProgressChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantChecks. 
        /// <para>
        /// The number of checks that found noncompliant resources.
        /// </para>
        /// </summary>
        public int? NonCompliantChecks
        {
            get { return this._nonCompliantChecks; }
            set { this._nonCompliantChecks = value; }
        }

        // Check to see if NonCompliantChecks property is set
        internal bool IsSetNonCompliantChecks()
        {
            return this._nonCompliantChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalChecks. 
        /// <para>
        /// The number of checks in this audit.
        /// </para>
        /// </summary>
        public int? TotalChecks
        {
            get { return this._totalChecks; }
            set { this._totalChecks = value; }
        }

        // Check to see if TotalChecks property is set
        internal bool IsSetTotalChecks()
        {
            return this._totalChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WaitingForDataCollectionChecks. 
        /// <para>
        /// The number of checks waiting for data collection.
        /// </para>
        /// </summary>
        public int? WaitingForDataCollectionChecks
        {
            get { return this._waitingForDataCollectionChecks; }
            set { this._waitingForDataCollectionChecks = value; }
        }

        // Check to see if WaitingForDataCollectionChecks property is set
        internal bool IsSetWaitingForDataCollectionChecks()
        {
            return this._waitingForDataCollectionChecks.HasValue; 
        }

    }
}