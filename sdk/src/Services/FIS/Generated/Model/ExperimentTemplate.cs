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
    /// Describes an experiment template.
    /// </summary>
    public partial class ExperimentTemplate
    {
        private Dictionary<string, ExperimentTemplateAction> _actions = AWSConfigs.InitializeCollections ? new Dictionary<string, ExperimentTemplateAction>() : null;
        private string _arn;
        private DateTime? _creationTime;
        private string _description;
        private ExperimentTemplateExperimentOptions _experimentOptions;
        private ExperimentTemplateReportConfiguration _experimentReportConfiguration;
        private string _id;
        private DateTime? _lastUpdateTime;
        private ExperimentTemplateLogConfiguration _logConfiguration;
        private string _roleArn;
        private List<ExperimentTemplateStopCondition> _stopConditions = AWSConfigs.InitializeCollections ? new List<ExperimentTemplateStopCondition>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _targetAccountConfigurationsCount;
        private Dictionary<string, ExperimentTemplateTarget> _targets = AWSConfigs.InitializeCollections ? new Dictionary<string, ExperimentTemplateTarget>() : null;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions for the experiment.
        /// </para>
        /// </summary>
        public Dictionary<string, ExperimentTemplateAction> Actions
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
        /// The Amazon Resource Name (ARN) of the experiment template.
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
        /// The time the experiment template was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the experiment template.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentOptions. 
        /// <para>
        /// The experiment options for an experiment template.
        /// </para>
        /// </summary>
        public ExperimentTemplateExperimentOptions ExperimentOptions
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
        /// Gets and sets the property ExperimentReportConfiguration. 
        /// <para>
        /// Describes the report configuration for the experiment template.
        /// </para>
        /// </summary>
        public ExperimentTemplateReportConfiguration ExperimentReportConfiguration
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the experiment template.
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
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time the experiment template was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The configuration for experiment logging.
        /// </para>
        /// </summary>
        public ExperimentTemplateLogConfiguration LogConfiguration
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
        /// The Amazon Resource Name (ARN) of an IAM role.
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
        /// Gets and sets the property StopConditions. 
        /// <para>
        /// The stop conditions for the experiment.
        /// </para>
        /// </summary>
        public List<ExperimentTemplateStopCondition> StopConditions
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
        /// The tags for the experiment template.
        /// </para>
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
        /// The count of target account configurations for the experiment template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TargetAccountConfigurationsCount
        {
            get { return this._targetAccountConfigurationsCount.GetValueOrDefault(); }
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
        /// </summary>
        public Dictionary<string, ExperimentTemplateTarget> Targets
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