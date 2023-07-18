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
    /// Container for the parameters to the CreateAutoMLJobV2 operation.
    /// Creates an Autopilot job also referred to as Autopilot experiment or AutoML job V2.
    /// 
    ///  <note> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJobV2.html">CreateAutoMLJobV2</a>
    /// and <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJobV2.html">DescribeAutoMLJobV2</a>
    /// are new versions of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJob.html">CreateAutoMLJob</a>
    /// and <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJob.html">DescribeAutoMLJob</a>
    /// which offer backward compatibility.
    /// </para>
    ///  
    /// <para>
    ///  <code>CreateAutoMLJobV2</code> can manage tabular problem types identical to those
    /// of its previous version <code>CreateAutoMLJob</code>, as well as non-tabular problem
    /// types such as image or text classification.
    /// </para>
    ///  
    /// <para>
    /// Find guidelines about how to migrate a <code>CreateAutoMLJob</code> to <code>CreateAutoMLJobV2</code>
    /// in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development-create-experiment-api.html#autopilot-create-experiment-api-migrate-v1-v2">Migrate
    /// a CreateAutoMLJob to CreateAutoMLJobV2</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For the list of available problem types supported by <code>CreateAutoMLJobV2</code>,
    /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLProblemTypeConfig.html">AutoMLProblemTypeConfig</a>.
    /// </para>
    ///  
    /// <para>
    /// You can find the best-performing model after you run an AutoML job V2 by calling <a
    /// href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJobV2.html">DescribeAutoMLJobV2</a>.
    /// </para>
    /// </summary>
    public partial class CreateAutoMLJobV2Request : AmazonSageMakerRequest
    {
        private List<AutoMLJobChannel> _autoMLJobInputDataConfig = new List<AutoMLJobChannel>();
        private string _autoMLJobName;
        private AutoMLJobObjective _autoMLJobObjective;
        private AutoMLProblemTypeConfig _autoMLProblemTypeConfig;
        private AutoMLDataSplitConfig _dataSplitConfig;
        private ModelDeployConfig _modelDeployConfig;
        private AutoMLOutputDataConfig _outputDataConfig;
        private string _roleArn;
        private AutoMLSecurityConfig _securityConfig;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AutoMLJobInputDataConfig. 
        /// <para>
        /// An array of channel objects describing the input data and their location. Each channel
        /// is a named input source. Similar to the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJob.html#sagemaker-CreateAutoMLJob-request-InputDataConfig">InputDataConfig</a>
        /// attribute in the <code>CreateAutoMLJob</code> input parameters. The supported formats
        /// depend on the problem type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For tabular problem types: <code>S3Prefix</code>, <code>ManifestFile</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For image classification: <code>S3Prefix</code>, <code>ManifestFile</code>, <code>AugmentedManifestFile</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For text classification: <code>S3Prefix</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For time-series forecasting: <code>S3Prefix</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<AutoMLJobChannel> AutoMLJobInputDataConfig
        {
            get { return this._autoMLJobInputDataConfig; }
            set { this._autoMLJobInputDataConfig = value; }
        }

        // Check to see if AutoMLJobInputDataConfig property is set
        internal bool IsSetAutoMLJobInputDataConfig()
        {
            return this._autoMLJobInputDataConfig != null && this._autoMLJobInputDataConfig.Count > 0; 
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
        /// Specifies a metric to minimize or maximize as the objective of a job. If not specified,
        /// the default objective metric depends on the problem type. For the list of default
        /// values per problem type, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLJobObjective.html">AutoMLJobObjective</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For tabular problem types, you must either provide both the <code>AutoMLJobObjective</code>
        /// and indicate the type of supervised learning problem in <code>AutoMLProblemTypeConfig</code>
        /// (<code>TabularJobConfig.ProblemType</code>), or none at all.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property AutoMLProblemTypeConfig. 
        /// <para>
        /// Defines the configuration settings of one of the supported problem types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLProblemTypeConfig AutoMLProblemTypeConfig
        {
            get { return this._autoMLProblemTypeConfig; }
            set { this._autoMLProblemTypeConfig = value; }
        }

        // Check to see if AutoMLProblemTypeConfig property is set
        internal bool IsSetAutoMLProblemTypeConfig()
        {
            return this._autoMLProblemTypeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DataSplitConfig. 
        /// <para>
        /// This structure specifies how to split the data into train and validation datasets.
        /// </para>
        ///  
        /// <para>
        /// The validation and training datasets must contain the same headers. For jobs created
        /// by calling <code>CreateAutoMLJob</code>, the validation dataset must be less than
        /// 2 GB in size.
        /// </para>
        ///  <note> 
        /// <para>
        /// This attribute must not be set for the time-series forecasting problem type, as Autopilot
        /// automatically splits the input dataset into training and validation sets.
        /// </para>
        ///  </note>
        /// </summary>
        public AutoMLDataSplitConfig DataSplitConfig
        {
            get { return this._dataSplitConfig; }
            set { this._dataSplitConfig = value; }
        }

        // Check to see if DataSplitConfig property is set
        internal bool IsSetDataSplitConfig()
        {
            return this._dataSplitConfig != null;
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
        /// artifacts from an AutoML job.
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
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// The security configuration for traffic encryption or Amazon VPC settings.
        /// </para>
        /// </summary>
        public AutoMLSecurityConfig SecurityConfig
        {
            get { return this._securityConfig; }
            set { this._securityConfig = value; }
        }

        // Check to see if SecurityConfig property is set
        internal bool IsSetSecurityConfig()
        {
            return this._securityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, such as by purpose, owner, or environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web ServicesResources</a>. Tag keys must be unique per resource.
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