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
    /// Container for the parameters to the UpdateExperimentTemplate operation.
    /// Updates the specified experiment template.
    /// </summary>
    public partial class UpdateExperimentTemplateRequest : AmazonFISRequest
    {
        private Dictionary<string, UpdateExperimentTemplateActionInputItem> _actions = AWSConfigs.InitializeCollections ? new Dictionary<string, UpdateExperimentTemplateActionInputItem>() : null;
        private string _description;
        private UpdateExperimentTemplateExperimentOptionsInput _experimentOptions;
        private UpdateExperimentTemplateReportConfigurationInput _experimentReportConfiguration;
        private string _id;
        private UpdateExperimentTemplateLogConfigurationInput _logConfiguration;
        private string _roleArn;
        private List<UpdateExperimentTemplateStopConditionInput> _stopConditions = AWSConfigs.InitializeCollections ? new List<UpdateExperimentTemplateStopConditionInput>() : null;
        private Dictionary<string, UpdateExperimentTemplateTargetInput> _targets = AWSConfigs.InitializeCollections ? new Dictionary<string, UpdateExperimentTemplateTargetInput>() : null;

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
        public Dictionary<string, UpdateExperimentTemplateActionInputItem> Actions
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the template.
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
        /// The experiment options for the experiment template.
        /// </para>
        /// </summary>
        public UpdateExperimentTemplateExperimentOptionsInput ExperimentOptions
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
        /// The experiment report configuration for the experiment template.
        /// </para>
        /// </summary>
        public UpdateExperimentTemplateReportConfigurationInput ExperimentReportConfiguration
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
        [AWSProperty(Required=true, Max=64)]
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
        public UpdateExperimentTemplateLogConfigurationInput LogConfiguration
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
        public List<UpdateExperimentTemplateStopConditionInput> StopConditions
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
        public Dictionary<string, UpdateExperimentTemplateTargetInput> Targets
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