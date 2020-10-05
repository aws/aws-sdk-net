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
    /// Container for the parameters to the CreateAutoMLJob operation.
    /// Creates an Autopilot job.
    /// 
    ///  
    /// <para>
    /// Find the best performing model after you run an Autopilot job by calling . Deploy
    /// that model by following the steps described in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/ex1-deploy-model.html">Step
    /// 6.1: Deploy the Model to Amazon SageMaker Hosting Services</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about how to use Autopilot, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html">
    /// Automate Model Development with Amazon SageMaker Autopilot</a>.
    /// </para>
    /// </summary>
    public partial class CreateAutoMLJobRequest : AmazonSageMakerRequest
    {
        private AutoMLJobConfig _autoMLJobConfig;
        private string _autoMLJobName;
        private AutoMLJobObjective _autoMLJobObjective;
        private bool? _generateCandidateDefinitionsOnly;
        private List<AutoMLChannel> _inputDataConfig = new List<AutoMLChannel>();
        private AutoMLOutputDataConfig _outputDataConfig;
        private ProblemType _problemType;
        private string _roleArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AutoMLJobConfig. 
        /// <para>
        /// Contains CompletionCriteria and SecurityConfig.
        /// </para>
        /// </summary>
        public AutoMLJobConfig AutoMLJobConfig
        {
            get { return this._autoMLJobConfig; }
            set { this._autoMLJobConfig = value; }
        }

        // Check to see if AutoMLJobConfig property is set
        internal bool IsSetAutoMLJobConfig()
        {
            return this._autoMLJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// Identifies an Autopilot job. Must be unique to your account and is case-insensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string AutoMLJobName
        {
            get { return this._autoMLJobName; }
            set { this._autoMLJobName = value; }
        }

        // Check to see if AutoMLJobName property is set
        internal bool IsSetAutoMLJobName()
        {
            return this._autoMLJobName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobObjective. 
        /// <para>
        /// Defines the objective of a an AutoML job. You provide a <a>AutoMLJobObjective$MetricName</a>
        /// and Autopilot infers whether to minimize or maximize it. If a metric is not specified,
        /// the most commonly used ObjectiveMetric for problem type is automaically selected.
        /// </para>
        /// </summary>
        public AutoMLJobObjective AutoMLJobObjective
        {
            get { return this._autoMLJobObjective; }
            set { this._autoMLJobObjective = value; }
        }

        // Check to see if AutoMLJobObjective property is set
        internal bool IsSetAutoMLJobObjective()
        {
            return this._autoMLJobObjective != null;
        }

        /// <summary>
        /// Gets and sets the property GenerateCandidateDefinitionsOnly. 
        /// <para>
        /// Generates possible candidates without training a model. A candidate is a combination
        /// of data preprocessors, algorithms, and algorithm parameter settings.
        /// </para>
        /// </summary>
        public bool GenerateCandidateDefinitionsOnly
        {
            get { return this._generateCandidateDefinitionsOnly.GetValueOrDefault(); }
            set { this._generateCandidateDefinitionsOnly = value; }
        }

        // Check to see if GenerateCandidateDefinitionsOnly property is set
        internal bool IsSetGenerateCandidateDefinitionsOnly()
        {
            return this._generateCandidateDefinitionsOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Similar to InputDataConfig supported by Tuning. Format(s) supported: CSV. Minimum
        /// of 500 rows.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<AutoMLChannel> InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null && this._inputDataConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Similar to OutputDataConfig supported by Tuning. Format(s) supported: CSV.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLOutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProblemType. 
        /// <para>
        /// Defines the kind of preprocessing and algorithms intended for the candidates. Options
        /// include: BinaryClassification, MulticlassClassification, and Regression.
        /// </para>
        /// </summary>
        public ProblemType ProblemType
        {
            get { return this._problemType; }
            set { this._problemType = value; }
        }

        // Check to see if ProblemType property is set
        internal bool IsSetProblemType()
        {
            return this._problemType != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that is used to access the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}