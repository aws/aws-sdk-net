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
    /// Find the best-performing model after you run an Autopilot job by calling .
    /// </para>
    ///  
    /// <para>
    /// For information about how to use Autopilot, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html">Automate
    /// Model Development with Amazon SageMaker Autopilot</a>.
    /// </para>
    /// </summary>
    public partial class CreateAutoMLJobRequest : AmazonSageMakerRequest
    {
        private AutoMLJobConfig _autoMLJobConfig;
        private string _autoMLJobName;
        private AutoMLJobObjective _autoMLJobObjective;
        private bool? _generateCandidateDefinitionsOnly;
        private List<AutoMLChannel> _inputDataConfig = new List<AutoMLChannel>();
        private ModelDeployConfig _modelDeployConfig;
        private AutoMLOutputDataConfig _outputDataConfig;
        private ProblemType _problemType;
        private string _roleArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AutoMLJobConfig. 
        /// <para>
        /// A collection of settings used to configure an AutoML job.
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
        /// Identifies an Autopilot job. The name must be unique to your account and is case insensitive.
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
        /// Defines the objective metric used to measure the predictive quality of an AutoML job.
        /// You provide an <a>AutoMLJobObjective$MetricName</a> and Autopilot infers whether to
        /// minimize or maximize it.
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
        /// Generates possible candidates without training the models. A candidate is a combination
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
        /// An array of channel objects that describes the input data and its location. Each channel
        /// is a named input source. Similar to <code>InputDataConfig</code> supported by . Format(s)
        /// supported: CSV, Parquet. A minimum of 500 rows is required for the training dataset.
        /// There is not a minimum number of rows required for the validation dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
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
        /// Gets and sets the property ModelDeployConfig. 
        /// <para>
        /// Specifies how to generate the endpoint name for an automatic one-click Autopilot model
        /// deployment.
        /// </para>
        /// </summary>
        public ModelDeployConfig ModelDeployConfig
        {
            get { return this._modelDeployConfig; }
            set { this._modelDeployConfig = value; }
        }

        // Check to see if ModelDeployConfig property is set
        internal bool IsSetModelDeployConfig()
        {
            return this._modelDeployConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Provides information about encryption and the Amazon S3 output path needed to store
        /// artifacts from an AutoML job. Format(s) supported: CSV.
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
        /// Defines the type of supervised learning available for the candidates. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development-problem-types.html">
        /// Amazon SageMaker Autopilot problem types and algorithm support</a>.
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