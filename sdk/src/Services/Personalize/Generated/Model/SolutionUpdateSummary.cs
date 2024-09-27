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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Provides a summary of the properties of a solution update. For a complete listing,
    /// call the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolution.html">DescribeSolution</a>
    /// API.
    /// </summary>
    public partial class SolutionUpdateSummary
    {
        private DateTime? _creationDateTime;
        private string _failureReason;
        private DateTime? _lastUpdatedDateTime;
        private bool? _performAutoTraining;
        private SolutionUpdateConfig _solutionUpdateConfig;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the solution update was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a solution update fails, the reason behind the failure.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) that the solution update was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformAutoTraining. 
        /// <para>
        /// Whether the solution automatically creates solution versions.
        /// </para>
        /// </summary>
        public bool? PerformAutoTraining
        {
            get { return this._performAutoTraining; }
            set { this._performAutoTraining = value; }
        }

        // Check to see if PerformAutoTraining property is set
        internal bool IsSetPerformAutoTraining()
        {
            return this._performAutoTraining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SolutionUpdateConfig. 
        /// <para>
        /// The configuration details of the solution.
        /// </para>
        /// </summary>
        public SolutionUpdateConfig SolutionUpdateConfig
        {
            get { return this._solutionUpdateConfig; }
            set { this._solutionUpdateConfig = value; }
        }

        // Check to see if SolutionUpdateConfig property is set
        internal bool IsSetSolutionUpdateConfig()
        {
            return this._solutionUpdateConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the solution update. A solution update can be in one of the following
        /// states:
        /// </para>
        ///  
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}