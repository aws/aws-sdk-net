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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Represents a single run of a test. Configuration is snapshotted from the test and
    /// service at the time the run is started.
    /// </summary>
    public partial class TestRun
    {
        private AccountTargeting _accountTargeting;
        private DateTime? _endedAt;
        private string _errorMessage;
        private int? _eventCount;
        private List<ExperimentDetails> _experiments = AWSConfigs.InitializeCollections ? new List<ExperimentDetails>() : null;
        private LoggingConfiguration _loggingConfiguration;
        private Dictionary<string, List<string>> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private PermissionModel _permissionModel;
        private TestRunPolicySnapshot _policy;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _regionSwitchExecutionId;
        private string _regionSwitchPlanArn;
        private TestRunReportConfiguration _reportConfiguration;
        private ReportGenerationResult _reportOutput;
        private string _roleName;
        private string _serviceArn;
        private DateTime? _startedAt;
        private TestRunStatus _status;
        private List<StopCondition> _stopConditions = AWSConfigs.InitializeCollections ? new List<StopCondition>() : null;
        private string _testId;
        private string _testRunId;
        private string _testTemplateArn;

        /// <summary>
        /// Gets and sets the property AccountTargeting. 
        /// <para>
        /// Indicates whether this test run targets a single account or multiple accounts.
        /// </para>
        /// </summary>
        public AccountTargeting AccountTargeting
        {
            get { return this._accountTargeting; }
            set { this._accountTargeting = value; }
        }

        // Check to see if AccountTargeting property is set
        internal bool IsSetAccountTargeting()
        {
            return this._accountTargeting != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the test run ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A human-readable reason for test run failure. Only present when the status is FAILED
        /// or ERROR.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EventCount. 
        /// <para>
        /// The number of events recorded for the test run. Use ListTestRunEvents to retrieve
        /// the details.
        /// </para>
        /// </summary>
        public int? EventCount
        {
            get { return this._eventCount; }
            set { this._eventCount = value; }
        }

        // Check to see if EventCount property is set
        internal bool IsSetEventCount()
        {
            return this._eventCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Experiments. 
        /// <para>
        /// The AWS Fault Injection Service (AWS FIS) experiments run as part of the test run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExperimentDetails> Experiments
        {
            get { return this._experiments; }
            set { this._experiments = value; }
        }

        // Check to see if Experiments property is set
        internal bool IsSetExperiments()
        {
            return this._experiments != null && (this._experiments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The logging configuration snapshotted from the test when the run was started.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameter values used for the test run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, List<string>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// The permission model snapshotted from the service when the run was started.
        /// </para>
        /// </summary>
        public PermissionModel PermissionModel
        {
            get { return this._permissionModel; }
            set { this._permissionModel = value; }
        }

        // Check to see if PermissionModel property is set
        internal bool IsSetPermissionModel()
        {
            return this._permissionModel != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The resilience policy snapshotted from the service when the run was started.
        /// </para>
        /// </summary>
        public TestRunPolicySnapshot Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Regions snapshotted from the service when the run was started.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegionSwitchExecutionId. 
        /// <para>
        /// The identifier of the ARC Region switch execution detected during the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string RegionSwitchExecutionId
        {
            get { return this._regionSwitchExecutionId; }
            set { this._regionSwitchExecutionId = value; }
        }

        // Check to see if RegionSwitchExecutionId property is set
        internal bool IsSetRegionSwitchExecutionId()
        {
            return this._regionSwitchExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property RegionSwitchPlanArn. 
        /// <para>
        /// The ARN of the ARC Region switch plan associated with the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=31)]
        public string RegionSwitchPlanArn
        {
            get { return this._regionSwitchPlanArn; }
            set { this._regionSwitchPlanArn = value; }
        }

        // Check to see if RegionSwitchPlanArn property is set
        internal bool IsSetRegionSwitchPlanArn()
        {
            return this._regionSwitchPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReportConfiguration. 
        /// <para>
        /// The report configuration snapshotted from the service when the run was started.
        /// </para>
        /// </summary>
        public TestRunReportConfiguration ReportConfiguration
        {
            get { return this._reportConfiguration; }
            set { this._reportConfiguration = value; }
        }

        // Check to see if ReportConfiguration property is set
        internal bool IsSetReportConfiguration()
        {
            return this._reportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ReportOutput. 
        /// <para>
        /// The report generation result for the test run. Present after report generation completes
        /// or fails.
        /// </para>
        /// </summary>
        public ReportGenerationResult ReportOutput
        {
            get { return this._reportOutput; }
            set { this._reportOutput = value; }
        }

        // Check to see if ReportOutput property is set
        internal bool IsSetReportOutput()
        {
            return this._reportOutput != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The IAM execution role name snapshotted from the test when the run was started.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=60)]
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service the test run belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=31)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the test run started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestRunStatus Status
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
        /// Gets and sets the property StopConditions. 
        /// <para>
        /// The stop conditions snapshotted from the test when the run was started.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StopCondition> StopConditions
        {
            get { return this._stopConditions; }
            set { this._stopConditions = value; }
        }

        // Check to see if StopConditions property is set
        internal bool IsSetStopConditions()
        {
            return this._stopConditions != null && (this._stopConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TestId. 
        /// <para>
        /// The identifier of the test that was run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestId
        {
            get { return this._testId; }
            set { this._testId = value; }
        }

        // Check to see if TestId property is set
        internal bool IsSetTestId()
        {
            return this._testId != null;
        }

        /// <summary>
        /// Gets and sets the property TestRunId. 
        /// <para>
        /// The unique identifier of the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestRunId
        {
            get { return this._testRunId; }
            set { this._testRunId = value; }
        }

        // Check to see if TestRunId property is set
        internal bool IsSetTestRunId()
        {
            return this._testRunId != null;
        }

        /// <summary>
        /// Gets and sets the property TestTemplateArn. 
        /// <para>
        /// The ARN of the test template snapshotted from the test when the run was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string TestTemplateArn
        {
            get { return this._testTemplateArn; }
            set { this._testTemplateArn = value; }
        }

        // Check to see if TestTemplateArn property is set
        internal bool IsSetTestTemplateArn()
        {
            return this._testTemplateArn != null;
        }

    }
}