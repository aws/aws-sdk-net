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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetDataQualityRulesetEvaluationRun operation.
    /// </summary>
    public partial class GetDataQualityRulesetEvaluationRunResponse : AmazonWebServiceResponse
    {
        private DataQualityEvaluationRunAdditionalRunOptions _additionalRunOptions;
        private DateTime? _completedOn;
        private DataSource _dataSource;
        private string _errorString;
        private int? _executionTime;
        private DateTime? _lastModifiedOn;
        private int? _numberOfWorkers;
        private List<string> _resultIds = new List<string>();
        private string _role;
        private List<string> _rulesetNames = new List<string>();
        private string _runId;
        private DateTime? _startedOn;
        private TaskStatusType _status;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property AdditionalRunOptions. 
        /// <para>
        /// Additional run options you can specify for an evaluation run.
        /// </para>
        /// </summary>
        public DataQualityEvaluationRunAdditionalRunOptions AdditionalRunOptions
        {
            get { return this._additionalRunOptions; }
            set { this._additionalRunOptions = value; }
        }

        // Check to see if AdditionalRunOptions property is set
        internal bool IsSetAdditionalRunOptions()
        {
            return this._additionalRunOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time when this run was completed.
        /// </para>
        /// </summary>
        public DateTime CompletedOn
        {
            get { return this._completedOn.GetValueOrDefault(); }
            set { this._completedOn = value; }
        }

        // Check to see if CompletedOn property is set
        internal bool IsSetCompletedOn()
        {
            return this._completedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source (an Glue table) associated with this evaluation run.
        /// </para>
        /// </summary>
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorString. 
        /// <para>
        /// The error strings that are associated with the run.
        /// </para>
        /// </summary>
        public string ErrorString
        {
            get { return this._errorString; }
            set { this._errorString = value; }
        }

        // Check to see if ErrorString property is set
        internal bool IsSetErrorString()
        {
            return this._errorString != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The amount of time (in seconds) that the run consumed resources.
        /// </para>
        /// </summary>
        public int ExecutionTime
        {
            get { return this._executionTime.GetValueOrDefault(); }
            set { this._executionTime = value; }
        }

        // Check to see if ExecutionTime property is set
        internal bool IsSetExecutionTime()
        {
            return this._executionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// A timestamp. The last point in time when this data quality rule recommendation run
        /// was modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedOn
        {
            get { return this._lastModifiedOn.GetValueOrDefault(); }
            set { this._lastModifiedOn = value; }
        }

        // Check to see if LastModifiedOn property is set
        internal bool IsSetLastModifiedOn()
        {
            return this._lastModifiedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of <code>G.1X</code> workers to be used in the run. The default is 5.
        /// </para>
        /// </summary>
        public int NumberOfWorkers
        {
            get { return this._numberOfWorkers.GetValueOrDefault(); }
            set { this._numberOfWorkers = value; }
        }

        // Check to see if NumberOfWorkers property is set
        internal bool IsSetNumberOfWorkers()
        {
            return this._numberOfWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultIds. 
        /// <para>
        /// A list of result IDs for the data quality results for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ResultIds
        {
            get { return this._resultIds; }
            set { this._resultIds = value; }
        }

        // Check to see if ResultIds property is set
        internal bool IsSetResultIds()
        {
            return this._resultIds != null && this._resultIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// An IAM role supplied to encrypt the results of the run.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property RulesetNames. 
        /// <para>
        /// A list of ruleset names for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> RulesetNames
        {
            get { return this._rulesetNames; }
            set { this._rulesetNames = value; }
        }

        // Check to see if RulesetNames property is set
        internal bool IsSetRulesetNames()
        {
            return this._rulesetNames != null && this._rulesetNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique run identifier associated with this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time when this run started.
        /// </para>
        /// </summary>
        public DateTime StartedOn
        {
            get { return this._startedOn.GetValueOrDefault(); }
            set { this._startedOn = value; }
        }

        // Check to see if StartedOn property is set
        internal bool IsSetStartedOn()
        {
            return this._startedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for this run.
        /// </para>
        /// </summary>
        public TaskStatusType Status
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
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout for a run in minutes. This is the maximum time that a run can consume
        /// resources before it is terminated and enters <code>TIMEOUT</code> status. The default
        /// is 2,880 minutes (48 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Timeout
        {
            get { return this._timeout.GetValueOrDefault(); }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

    }
}