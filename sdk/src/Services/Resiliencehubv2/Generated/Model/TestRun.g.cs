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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Represents a single run of a test. Configuration is snapshotted from the test and
    /// service at the time the run is started.
    /// </summary>
    public partial class TestRun
    {
        /// <summary>
        /// Gets and sets the property AccountTargeting. 
        /// <para>
        /// Indicates whether the test run targets resources in a single AWS account or across
        /// multiple accounts.
        /// </para>
        /// </summary>
        public AccountTargeting AccountTargeting { get; set; }

        /// <summary>
        /// Checks to see if the AccountTargeting property is set.
        /// </summary>
        internal bool IsSetAccountTargeting() => this.AccountTargeting != null;

        /// <summary>
        /// Gets and sets the property DevOpsAgentInvestigation. 
        /// <para>
        /// The DevOps Agent investigation result for the test run, present when the integration
        /// is enabled for the service.
        /// </para>
        /// </summary>
        public DevOpsAgentInvestigation DevOpsAgentInvestigation { get; set; }

        /// <summary>
        /// Checks to see if the DevOpsAgentInvestigation property is set.
        /// </summary>
        internal bool IsSetDevOpsAgentInvestigation() => this.DevOpsAgentInvestigation != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the test run ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A human-readable reason for test run failure. Only present when the status is FAILED
        /// or ERROR.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property EventCount. 
        /// <para>
        /// The number of events recorded for the test run. Use ListTestRunEvents to retrieve
        /// the details.
        /// </para>
        /// </summary>
        public int? EventCount { get; set; }

        /// <summary>
        /// Checks to see if the EventCount property is set.
        /// </summary>
        internal bool IsSetEventCount() => this.EventCount.HasValue;

        /// <summary>
        /// Gets and sets the property Experiments. 
        /// <para>
        /// The AWS Fault Injection Service (AWS FIS) experiments run as part of the test run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExperimentDetails> Experiments { get; set; } = AWSConfigs.InitializeCollections ? new List<ExperimentDetails>() : null;

        /// <summary>
        /// Checks to see if the Experiments property is set.
        /// </summary>
        internal bool IsSetExperiments() => this.Experiments != null && (this.Experiments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The logging configuration snapshotted from the test when the run was started.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameter values used for the test run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public Dictionary<string, List<string>> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// The permission model snapshotted from the service when the run was started.
        /// </para>
        /// </summary>
        public PermissionModel PermissionModel { get; set; }

        /// <summary>
        /// Checks to see if the PermissionModel property is set.
        /// </summary>
        internal bool IsSetPermissionModel() => this.PermissionModel != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The resilience policy snapshotted from the service when the run was started.
        /// </para>
        /// </summary>
        public TestRunPolicySnapshot Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property RegionSwitchExecutionId. 
        /// <para>
        /// The identifier of the ARC Region switch execution detected during the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RegionSwitchExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the RegionSwitchExecutionId property is set.
        /// </summary>
        internal bool IsSetRegionSwitchExecutionId() => this.RegionSwitchExecutionId != null;

        /// <summary>
        /// Gets and sets the property RegionSwitchPlanArn. 
        /// <para>
        /// The ARN of the ARC Region switch plan associated with the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 31)]
        public string RegionSwitchPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the RegionSwitchPlanArn property is set.
        /// </summary>
        internal bool IsSetRegionSwitchPlanArn() => this.RegionSwitchPlanArn != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Regions snapshotted from the service when the run was started.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportConfiguration. 
        /// <para>
        /// The report configuration snapshotted from the service when the run was started.
        /// </para>
        /// </summary>
        public TestRunReportConfiguration ReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReportConfiguration property is set.
        /// </summary>
        internal bool IsSetReportConfiguration() => this.ReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReportOutput. 
        /// <para>
        /// The report generation result for the test run. Present after report generation completes
        /// or fails.
        /// </para>
        /// </summary>
        public ReportGenerationResult ReportOutput { get; set; }

        /// <summary>
        /// Checks to see if the ReportOutput property is set.
        /// </summary>
        internal bool IsSetReportOutput() => this.ReportOutput != null;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The IAM execution role name snapshotted from the test when the run was started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 576)]
        public string RoleName { get; set; }

        /// <summary>
        /// Checks to see if the RoleName property is set.
        /// </summary>
        internal bool IsSetRoleName() => this.RoleName != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service the test run belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 31)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the test run started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TestRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StopConditions. 
        /// <para>
        /// The stop conditions snapshotted from the test when the run was started.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StopCondition> StopConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<StopCondition>() : null;

        /// <summary>
        /// Checks to see if the StopConditions property is set.
        /// </summary>
        internal bool IsSetStopConditions() => this.StopConditions != null && (this.StopConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TestId. 
        /// <para>
        /// The identifier of the test that was run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string TestId { get; set; }

        /// <summary>
        /// Checks to see if the TestId property is set.
        /// </summary>
        internal bool IsSetTestId() => this.TestId != null;

        /// <summary>
        /// Gets and sets the property TestRunId. 
        /// <para>
        /// The unique identifier of the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string TestRunId { get; set; }

        /// <summary>
        /// Checks to see if the TestRunId property is set.
        /// </summary>
        internal bool IsSetTestRunId() => this.TestRunId != null;

        /// <summary>
        /// Gets and sets the property TestTemplateArn. 
        /// <para>
        /// The ARN of the test template snapshotted from the test when the run was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string TestTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TestTemplateArn property is set.
        /// </summary>
        internal bool IsSetTestTemplateArn() => this.TestTemplateArn != null;
    }
}
