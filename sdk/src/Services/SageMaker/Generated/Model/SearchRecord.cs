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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A single resource returned as part of the <a>Search</a> API response.
    /// </summary>
    public partial class SearchRecord
    {
        private Experiment _experiment;
        private TrainingJob _trainingJob;
        private Trial _trial;
        private TrialComponent _trialComponent;

        /// <summary>
        /// Gets and sets the property Experiment. 
        /// <para>
        /// The properties of an experiment.
        /// </para>
        /// </summary>
        public Experiment Experiment
        {
            get { return this._experiment; }
            set { this._experiment = value; }
        }

        // Check to see if Experiment property is set
        internal bool IsSetExperiment()
        {
            return this._experiment != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJob. 
        /// <para>
        /// The properties of a training job.
        /// </para>
        /// </summary>
        public TrainingJob TrainingJob
        {
            get { return this._trainingJob; }
            set { this._trainingJob = value; }
        }

        // Check to see if TrainingJob property is set
        internal bool IsSetTrainingJob()
        {
            return this._trainingJob != null;
        }

        /// <summary>
        /// Gets and sets the property Trial. 
        /// <para>
        /// The properties of a trial.
        /// </para>
        /// </summary>
        public Trial Trial
        {
            get { return this._trial; }
            set { this._trial = value; }
        }

        // Check to see if Trial property is set
        internal bool IsSetTrial()
        {
            return this._trial != null;
        }

        /// <summary>
        /// Gets and sets the property TrialComponent. 
        /// <para>
        /// The properties of a trial component.
        /// </para>
        /// </summary>
        public TrialComponent TrialComponent
        {
            get { return this._trialComponent; }
            set { this._trialComponent = value; }
        }

        // Check to see if TrialComponent property is set
        internal bool IsSetTrialComponent()
        {
            return this._trialComponent != null;
        }

    }
}