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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CanceledChecks. 
        /// <para>
        /// The number of checks that did not run because the audit was canceled.
        /// </para>
        /// </summary>
        public int? CanceledChecks { get; set; }

        /// <summary>
        /// Checks to see if the CanceledChecks property is set.
        /// </summary>
        internal bool IsSetCanceledChecks() => this.CanceledChecks.HasValue;

        /// <summary>
        /// Gets and sets the property CompliantChecks. 
        /// <para>
        /// The number of checks that found compliant resources.
        /// </para>
        /// </summary>
        public int? CompliantChecks { get; set; }

        /// <summary>
        /// Checks to see if the CompliantChecks property is set.
        /// </summary>
        internal bool IsSetCompliantChecks() => this.CompliantChecks.HasValue;

        /// <summary>
        /// Gets and sets the property FailedChecks. 
        /// <para>
        /// The number of checks.
        /// </para>
        /// </summary>
        public int? FailedChecks { get; set; }

        /// <summary>
        /// Checks to see if the FailedChecks property is set.
        /// </summary>
        internal bool IsSetFailedChecks() => this.FailedChecks.HasValue;

        /// <summary>
        /// Gets and sets the property InProgressChecks. 
        /// <para>
        /// The number of checks in progress.
        /// </para>
        /// </summary>
        public int? InProgressChecks { get; set; }

        /// <summary>
        /// Checks to see if the InProgressChecks property is set.
        /// </summary>
        internal bool IsSetInProgressChecks() => this.InProgressChecks.HasValue;

        /// <summary>
        /// Gets and sets the property NonCompliantChecks. 
        /// <para>
        /// The number of checks that found noncompliant resources.
        /// </para>
        /// </summary>
        public int? NonCompliantChecks { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantChecks property is set.
        /// </summary>
        internal bool IsSetNonCompliantChecks() => this.NonCompliantChecks.HasValue;

        /// <summary>
        /// Gets and sets the property TotalChecks. 
        /// <para>
        /// The number of checks in this audit.
        /// </para>
        /// </summary>
        public int? TotalChecks { get; set; }

        /// <summary>
        /// Checks to see if the TotalChecks property is set.
        /// </summary>
        internal bool IsSetTotalChecks() => this.TotalChecks.HasValue;

        /// <summary>
        /// Gets and sets the property WaitingForDataCollectionChecks. 
        /// <para>
        /// The number of checks waiting for data collection.
        /// </para>
        /// </summary>
        public int? WaitingForDataCollectionChecks { get; set; }

        /// <summary>
        /// Checks to see if the WaitingForDataCollectionChecks property is set.
        /// </summary>
        internal bool IsSetWaitingForDataCollectionChecks() => this.WaitingForDataCollectionChecks.HasValue;
    }
}
