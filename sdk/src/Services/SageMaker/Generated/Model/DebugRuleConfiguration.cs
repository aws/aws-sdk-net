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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration information for SageMaker Debugger rules for debugging. To learn more
    /// about how to configure the <code>DebugRuleConfiguration</code> parameter, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/debugger-createtrainingjob-api.html">Use
    /// the SageMaker and Debugger Configuration API Operations to Create, Update, and Debug
    /// Your Training Job</a>.
    /// </summary>
    public partial class DebugRuleConfiguration
    {
        private ProcessingInstanceType _instanceType;
        private string _localPath;
        private string _ruleConfigurationName;
        private string _ruleEvaluatorImage;
        private Dictionary<string, string> _ruleParameters = new Dictionary<string, string>();
        private string _s3OutputPath;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to deploy a custom rule for debugging a training job.
        /// </para>
        /// </summary>
        public ProcessingInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// Path to local storage location for output of rules. Defaults to <code>/opt/ml/processing/output/rule/</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string LocalPath
        {
            get { return this._localPath; }
            set { this._localPath = value; }
        }

        // Check to see if LocalPath property is set
        internal bool IsSetLocalPath()
        {
            return this._localPath != null;
        }

        /// <summary>
        /// Gets and sets the property RuleConfigurationName. 
        /// <para>
        /// The name of the rule configuration. It must be unique relative to other rule configuration
        /// names.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RuleConfigurationName
        {
            get { return this._ruleConfigurationName; }
            set { this._ruleConfigurationName = value; }
        }

        // Check to see if RuleConfigurationName property is set
        internal bool IsSetRuleConfigurationName()
        {
            return this._ruleConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property RuleEvaluatorImage. 
        /// <para>
        /// The Amazon Elastic Container (ECR) Image for the managed rule evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string RuleEvaluatorImage
        {
            get { return this._ruleEvaluatorImage; }
            set { this._ruleEvaluatorImage = value; }
        }

        // Check to see if RuleEvaluatorImage property is set
        internal bool IsSetRuleEvaluatorImage()
        {
            return this._ruleEvaluatorImage != null;
        }

        /// <summary>
        /// Gets and sets the property RuleParameters. 
        /// <para>
        /// Runtime configuration for rule container.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> RuleParameters
        {
            get { return this._ruleParameters; }
            set { this._ruleParameters = value; }
        }

        // Check to see if RuleParameters property is set
        internal bool IsSetRuleParameters()
        {
            return this._ruleParameters != null && this._ruleParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// Path to Amazon S3 storage location for rules.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string S3OutputPath
        {
            get { return this._s3OutputPath; }
            set { this._s3OutputPath = value; }
        }

        // Check to see if S3OutputPath property is set
        internal bool IsSetS3OutputPath()
        {
            return this._s3OutputPath != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size, in GB, of the ML storage volume attached to the processing instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int VolumeSizeInGB
        {
            get { return this._volumeSizeInGB.GetValueOrDefault(); }
            set { this._volumeSizeInGB = value; }
        }

        // Check to see if VolumeSizeInGB property is set
        internal bool IsSetVolumeSizeInGB()
        {
            return this._volumeSizeInGB.HasValue; 
        }

    }
}