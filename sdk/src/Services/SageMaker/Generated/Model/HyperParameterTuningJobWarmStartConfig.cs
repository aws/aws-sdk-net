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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies the configuration for a hyperparameter tuning job that uses one or more
    /// previous hyperparameter tuning jobs as a starting point. The results of previous tuning
    /// jobs are used to inform which combinations of hyperparameters to search over in the
    /// new tuning job.
    /// 
    ///  
    /// <para>
    /// All training jobs launched by the new hyperparameter tuning job are evaluated by using
    /// the objective metric, and the training job that performs the best is compared to the
    /// best training jobs from the parent tuning jobs. From these, the training job that
    /// performs the best as measured by the objective metric is returned as the overall best
    /// training job.
    /// </para>
    ///  <note> 
    /// <para>
    /// All training jobs launched by parent hyperparameter tuning jobs and the new hyperparameter
    /// tuning jobs count against the limit of training jobs for the tuning job.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class HyperParameterTuningJobWarmStartConfig
    {
        private List<ParentHyperParameterTuningJob> _parentHyperParameterTuningJobs = AWSConfigs.InitializeCollections ? new List<ParentHyperParameterTuningJob>() : null;
        private HyperParameterTuningJobWarmStartType _warmStartType;

        /// <summary>
        /// Gets and sets the property ParentHyperParameterTuningJobs. 
        /// <para>
        /// An array of hyperparameter tuning jobs that are used as the starting point for the
        /// new hyperparameter tuning job. For more information about warm starting a hyperparameter
        /// tuning job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-warm-start.html">Using
        /// a Previous Hyperparameter Tuning Job as a Starting Point</a>.
        /// </para>
        ///  
        /// <para>
        /// Hyperparameter tuning jobs created before October 1, 2018 cannot be used as parent
        /// jobs for warm start tuning jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<ParentHyperParameterTuningJob> ParentHyperParameterTuningJobs
        {
            get { return this._parentHyperParameterTuningJobs; }
            set { this._parentHyperParameterTuningJobs = value; }
        }

        // Check to see if ParentHyperParameterTuningJobs property is set
        internal bool IsSetParentHyperParameterTuningJobs()
        {
            return this._parentHyperParameterTuningJobs != null && (this._parentHyperParameterTuningJobs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WarmStartType. 
        /// <para>
        /// Specifies one of the following:
        /// </para>
        ///  <dl> <dt>IDENTICAL_DATA_AND_ALGORITHM</dt> <dd> 
        /// <para>
        /// The new hyperparameter tuning job uses the same input data and training image as the
        /// parent tuning jobs. You can change the hyperparameter ranges to search and the maximum
        /// number of training jobs that the hyperparameter tuning job launches. You cannot use
        /// a new version of the training algorithm, unless the changes in the new version do
        /// not affect the algorithm itself. For example, changes that improve logging or adding
        /// support for a different data format are allowed. You can also change hyperparameters
        /// from tunable to static, and from static to tunable, but the total number of static
        /// plus tunable hyperparameters must remain the same as it is in all parent jobs. The
        /// objective metric for the new tuning job must be the same as for all parent jobs.
        /// </para>
        ///  </dd> <dt>TRANSFER_LEARNING</dt> <dd> 
        /// <para>
        /// The new hyperparameter tuning job can include input data, hyperparameter ranges, maximum
        /// number of concurrent training jobs, and maximum number of training jobs that are different
        /// than those of its parent hyperparameter tuning jobs. The training image can also be
        /// a different version from the version used in the parent hyperparameter tuning job.
        /// You can also change hyperparameters from tunable to static, and from static to tunable,
        /// but the total number of static plus tunable hyperparameters must remain the same as
        /// it is in all parent jobs. The objective metric for the new tuning job must be the
        /// same as for all parent jobs.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public HyperParameterTuningJobWarmStartType WarmStartType
        {
            get { return this._warmStartType; }
            set { this._warmStartType = value; }
        }

        // Check to see if WarmStartType property is set
        internal bool IsSetWarmStartType()
        {
            return this._warmStartType != null;
        }

    }
}