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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration information for profiling rules.
    /// </summary>
    public partial class ProfilerRuleConfiguration
    {
        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to deploy a custom rule for profiling a training job.
        /// </para>
        /// </summary>
        public ProcessingInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// Path to local storage location for output of rules. Defaults to <c>/opt/ml/processing/output/rule/</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string LocalPath { get; set; }

        /// <summary>
        /// Checks to see if the LocalPath property is set.
        /// </summary>
        internal bool IsSetLocalPath() => this.LocalPath != null;

        /// <summary>
        /// Gets and sets the property RuleConfigurationName. 
        /// <para>
        /// The name of the rule configuration. It must be unique relative to other rule configuration
        /// names.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string RuleConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the RuleConfigurationName property is set.
        /// </summary>
        internal bool IsSetRuleConfigurationName() => this.RuleConfigurationName != null;

        /// <summary>
        /// Gets and sets the property RuleEvaluatorImage. 
        /// <para>
        /// The Amazon Elastic Container Registry Image for the managed rule evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string RuleEvaluatorImage { get; set; }

        /// <summary>
        /// Checks to see if the RuleEvaluatorImage property is set.
        /// </summary>
        internal bool IsSetRuleEvaluatorImage() => this.RuleEvaluatorImage != null;

        /// <summary>
        /// Gets and sets the property RuleParameters. 
        /// <para>
        /// Runtime configuration for rule container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> RuleParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RuleParameters property is set.
        /// </summary>
        internal bool IsSetRuleParameters() => this.RuleParameters != null && (this.RuleParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// Path to Amazon S3 storage location for rules.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3OutputPath { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputPath property is set.
        /// </summary>
        internal bool IsSetS3OutputPath() => this.S3OutputPath != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size, in GB, of the ML storage volume attached to the processing instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? VolumeSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInGB property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInGB() => this.VolumeSizeInGB.HasValue;
    }
}
