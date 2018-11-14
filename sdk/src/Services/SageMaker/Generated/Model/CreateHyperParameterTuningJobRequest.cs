/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHyperParameterTuningJob operation.
    /// Starts a hyperparameter tuning job. A hyperparameter tuning job finds the best version
    /// of a model by running many training jobs on your dataset using the algorithm you choose
    /// and values for hyperparameters within ranges that you specify. It then chooses the
    /// hyperparameter values that result in a model that performs the best, as measured by
    /// an objective metric that you choose.
    /// </summary>
    public partial class CreateHyperParameterTuningJobRequest : AmazonSageMakerRequest
    {
        private HyperParameterTuningJobConfig _hyperParameterTuningJobConfig;
        private string _hyperParameterTuningJobName;
        private List<Tag> _tags = new List<Tag>();
        private HyperParameterTrainingJobDefinition _trainingJobDefinition;
        private HyperParameterTuningJobWarmStartConfig _warmStartConfig;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobConfig. 
        /// <para>
        /// The <a>HyperParameterTuningJobConfig</a> object that describes the tuning job, including
        /// the search strategy, the objective metric used to evaluate training jobs, ranges of
        /// parameters to search, and resource limits for the tuning job. For more information,
        /// see <a>automatic-model-tuning</a> 
        /// </para>
        /// </summary>
        public HyperParameterTuningJobConfig HyperParameterTuningJobConfig
        {
            get { return this._hyperParameterTuningJobConfig; }
            set { this._hyperParameterTuningJobConfig = value; }
        }

        // Check to see if HyperParameterTuningJobConfig property is set
        internal bool IsSetHyperParameterTuningJobConfig()
        {
            return this._hyperParameterTuningJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobName. 
        /// <para>
        /// The name of the tuning job. This name is the prefix for the names of all training
        /// jobs that this tuning job launches. The name must be unique within the same AWS account
        /// and AWS Region. The name must have { } to { } characters. Valid characters are a-z,
        /// A-Z, 0-9, and : + = @ _ % - (hyphen). The name is not case sensitive.
        /// </para>
        /// </summary>
        public string HyperParameterTuningJobName
        {
            get { return this._hyperParameterTuningJobName; }
            set { this._hyperParameterTuningJobName = value; }
        }

        // Check to see if HyperParameterTuningJobName property is set
        internal bool IsSetHyperParameterTuningJobName()
        {
            return this._hyperParameterTuningJobName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your AWS resources in
        /// different ways, for example, by purpose, owner, or environment. For more information,
        /// see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">AWS
        /// Tagging Strategies</a>.
        /// </para>
        ///  
        /// <para>
        /// Tags that you specify for the tuning job are also added to all training jobs that
        /// the tuning job launches.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TrainingJobDefinition. 
        /// <para>
        /// The <a>HyperParameterTrainingJobDefinition</a> object that describes the training
        /// jobs that this tuning job launches, including static hyperparameters, input data configuration,
        /// output data configuration, resource configuration, and stopping condition.
        /// </para>
        /// </summary>
        public HyperParameterTrainingJobDefinition TrainingJobDefinition
        {
            get { return this._trainingJobDefinition; }
            set { this._trainingJobDefinition = value; }
        }

        // Check to see if TrainingJobDefinition property is set
        internal bool IsSetTrainingJobDefinition()
        {
            return this._trainingJobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property WarmStartConfig. 
        /// <para>
        /// Specifies configuration for starting the hyperparameter tuning job using one or more
        /// previous tuning jobs as a starting point. The results of previous tuning jobs are
        /// used to inform which combinations of hyperparameters to search over in the new tuning
        /// job.
        /// </para>
        ///  
        /// <para>
        /// All training jobs launched by the new hyperparameter tuning job are evaluated by using
        /// the objective metric. If you specify <code>IDENTICAL_DATA_AND_ALGORITHM</code> as
        /// the <code>WarmStartType</code> for the warm start configuration, the training job
        /// that performs the best in the new tuning job is compared to the best training jobs
        /// from the parent tuning jobs. From these, the training job that performs the best as
        /// measured by the objective metric is returned as the overall best training job.
        /// </para>
        ///  <note> 
        /// <para>
        /// All training jobs launched by parent hyperparameter tuning jobs and the new hyperparameter
        /// tuning jobs count against the limit of training jobs for the tuning job.
        /// </para>
        ///  </note>
        /// </summary>
        public HyperParameterTuningJobWarmStartConfig WarmStartConfig
        {
            get { return this._warmStartConfig; }
            set { this._warmStartConfig = value; }
        }

        // Check to see if WarmStartConfig property is set
        internal bool IsSetWarmStartConfig()
        {
            return this._warmStartConfig != null;
        }

    }
}