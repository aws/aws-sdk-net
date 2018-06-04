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
    /// Starts a hyperparameter tuning job.
    /// </summary>
    public partial class CreateHyperParameterTuningJobRequest : AmazonSageMakerRequest
    {
        private HyperParameterTuningJobConfig _hyperParameterTuningJobConfig;
        private string _hyperParameterTuningJobName;
        private List<Tag> _tags = new List<Tag>();
        private HyperParameterTrainingJobDefinition _trainingJobDefinition;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobConfig. 
        /// <para>
        /// The object that describes the tuning job, including the search strategy, metric used
        /// to evaluate training jobs, ranges of parameters to search, and resource limits for
        /// the tuning job.
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
        /// and AWS Region. Names are not case sensitive, and must be between 1-32 characters.
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
        /// see <a href="http://docs.aws.amazon.com//awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
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
        /// The object that describes the training jobs that this tuning job launches, including
        /// static hyperparameters, input data configuration, output data configuration, resource
        /// configuration, and stopping condition.
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

    }
}