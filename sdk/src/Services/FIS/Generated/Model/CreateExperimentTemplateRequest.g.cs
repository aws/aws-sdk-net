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

namespace Amazon.FIS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateExperimentTemplate operation. Creates an
    /// experiment template. <para> An experiment template includes the following components:
    /// </para> <ul> <li> <para> <b>Targets</b>: A target can be a specific resource in your
    /// Amazon Web Services environment, or one or more resources that match criteria that
    /// you specify, for example, resources that have specific tags. </para> </li> <li> <para>
    /// <b>Actions</b>: The actions to carry out on the target. You can specify multiple actions,
    /// the duration of each action, and when to start each action during an experiment. </para>
    /// </li> <li> <para> <b>Stop conditions</b>: If a stop condition is triggered while an
    /// experiment is running, the experiment is automatically stopped. You can define a stop
    /// condition as a CloudWatch alarm. </para> </li> </ul> <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/fis/latest/userguide/experiment-templates.html">experiment
    /// templates</a> in the <i>Fault Injection Service User Guide</i>. </para>
    /// </summary>
    public partial class CreateExperimentTemplateRequest : AmazonFISRequest
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions for the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, CreateExperimentTemplateActionInput> Actions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CreateExperimentTemplateActionInput>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the experiment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExperimentOptions. 
        /// <para>
        /// The experiment options for the experiment template.
        /// </para>
        /// </summary>
        public CreateExperimentTemplateExperimentOptionsInput ExperimentOptions { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentOptions property is set.
        /// </summary>
        internal bool IsSetExperimentOptions() => this.ExperimentOptions != null;

        /// <summary>
        /// Gets and sets the property ExperimentReportConfiguration. 
        /// <para>
        /// The experiment report configuration for the experiment template.
        /// </para>
        /// </summary>
        public CreateExperimentTemplateReportConfigurationInput ExperimentReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentReportConfiguration property is set.
        /// </summary>
        internal bool IsSetExperimentReportConfiguration() => this.ExperimentReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The configuration for experiment logging.
        /// </para>
        /// </summary>
        public CreateExperimentTemplateLogConfigurationInput LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that grants the FIS service permission
        /// to perform service actions on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StopConditions. 
        /// <para>
        /// The stop conditions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<CreateExperimentTemplateStopConditionInput> StopConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateExperimentTemplateStopConditionInput>() : null;

        /// <summary>
        /// Checks to see if the StopConditions property is set.
        /// </summary>
        internal bool IsSetStopConditions() => this.StopConditions != null && (this.StopConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the experiment template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets for the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, CreateExperimentTemplateTargetInput> Targets { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CreateExperimentTemplateTargetInput>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
