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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
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
namespace Amazon.FIS.Model
{
    /// <summary>
    /// Describes an experiment.
    /// </summary>
    public partial class Experiment
    {
        private Dictionary<string, ExperimentAction> _actions = AWSConfigs.InitializeCollections ? new Dictionary<string, ExperimentAction>() : null;
        private string _arn;
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private ExperimentOptions _experimentOptions;
        private ExperimentReport _experimentReport;
        private ExperimentReportConfiguration _experimentReportConfiguration;
        private string _experimentTemplateId;
        private string _id;
        private ExperimentLogConfiguration _logConfiguration;
        private string _roleArn;
        private DateTime? _startTime;
        private ExperimentState _state;
        private List<ExperimentStopCondition> _stopConditions = AWSConfigs.InitializeCollections ? new List<ExperimentStopCondition>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _targetAccountConfigurationsCount;
        private Dictionary<string, ExperimentTarget> _targets = AWSConfigs.InitializeCollections ? new Dictionary<string, ExperimentTarget>() : null;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions for the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ExperimentAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the experiment was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the experiment ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExperimentOptions. 
        /// <para>
        /// The experiment options for the experiment.
        /// </para>
        /// </summary>
        public ExperimentOptions ExperimentOptions
        {
            get { return this._experimentOptions; }
            set { this._experimentOptions = value; }
        }

        // Check to see if ExperimentOptions property is set
        internal bool IsSetExperimentOptions()
        {
            return this._experimentOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentReport. 
        /// <para>
        /// The experiment report for the experiment.
        /// </para>
        /// </summary>
        public ExperimentReport ExperimentReport
        {
            get { return this._experimentReport; }
            set { this._experimentReport = value; }
        }

        // Check to see if ExperimentReport property is set
        internal bool IsSetExperimentReport()
        {
            return this._experimentReport != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentReportConfiguration. 
        /// <para>
        /// The experiment report configuration for the experiment.
        /// </para>
        /// </summary>
        public ExperimentReportConfiguration ExperimentReportConfiguration
        {
            get { return this._experimentReportConfiguration; }
            set { this._experimentReportConfiguration = value; }
        }

        // Check to see if ExperimentReportConfiguration property is set
        internal bool IsSetExperimentReportConfiguration()
        {
            return this._experimentReportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentTemplateId. 
        /// <para>
        /// The ID of the experiment template.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string ExperimentTemplateId
        {
            get { return this._experimentTemplateId; }
            set { this._experimentTemplateId = value; }
        }

        // Check to see if ExperimentTemplateId property is set
        internal bool IsSetExperimentTemplateId()
        {
            return this._experimentTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The configuration for experiment logging.
        /// </para>
        /// </summary>
        public ExperimentLogConfiguration LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that grants the FIS service permission
        /// to perform service actions on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the experiment started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the experiment.
        /// </para>
        /// </summary>
        public ExperimentState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StopConditions. 
        /// <para>
        /// The stop conditions for the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExperimentStopCondition> StopConditions
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetAccountConfigurationsCount. 
        /// <para>
        /// The count of target account configurations for the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TargetAccountConfigurationsCount
        {
            get { return this._targetAccountConfigurationsCount; }
            set { this._targetAccountConfigurationsCount = value; }
        }

        // Check to see if TargetAccountConfigurationsCount property is set
        internal bool IsSetTargetAccountConfigurationsCount()
        {
            return this._targetAccountConfigurationsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets for the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ExperimentTarget> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}