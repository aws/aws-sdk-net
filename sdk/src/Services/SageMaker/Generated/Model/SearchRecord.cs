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
    /// A single resource returned as part of the <a>Search</a> API response.
    /// </summary>
    public partial class SearchRecord
    {
        private Endpoint _endpoint;
        private Experiment _experiment;
        private FeatureGroup _featureGroup;
        private FeatureMetadata _featureMetadata;
        private HyperParameterTuningJobSearchEntity _hyperParameterTuningJob;
        private ModelDashboardModel _model;
        private ModelCard _modelCard;
        private ModelPackage _modelPackage;
        private ModelPackageGroup _modelPackageGroup;
        private Pipeline _pipeline;
        private PipelineExecution _pipelineExecution;
        private Project _project;
        private TrainingJob _trainingJob;
        private Trial _trial;
        private TrialComponent _trialComponent;

        /// <summary>
        /// Gets and sets the property Endpoint.
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

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
        /// Gets and sets the property FeatureGroup.
        /// </summary>
        public FeatureGroup FeatureGroup
        {
            get { return this._featureGroup; }
            set { this._featureGroup = value; }
        }

        // Check to see if FeatureGroup property is set
        internal bool IsSetFeatureGroup()
        {
            return this._featureGroup != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureMetadata. 
        /// <para>
        /// The feature metadata used to search through the features.
        /// </para>
        /// </summary>
        public FeatureMetadata FeatureMetadata
        {
            get { return this._featureMetadata; }
            set { this._featureMetadata = value; }
        }

        // Check to see if FeatureMetadata property is set
        internal bool IsSetFeatureMetadata()
        {
            return this._featureMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJob. 
        /// <para>
        /// The properties of a hyperparameter tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobSearchEntity HyperParameterTuningJob
        {
            get { return this._hyperParameterTuningJob; }
            set { this._hyperParameterTuningJob = value; }
        }

        // Check to see if HyperParameterTuningJob property is set
        internal bool IsSetHyperParameterTuningJob()
        {
            return this._hyperParameterTuningJob != null;
        }

        /// <summary>
        /// Gets and sets the property Model.
        /// </summary>
        public ModelDashboardModel Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property ModelCard. 
        /// <para>
        /// An Amazon SageMaker Model Card that documents details about a machine learning model.
        /// </para>
        /// </summary>
        public ModelCard ModelCard
        {
            get { return this._modelCard; }
            set { this._modelCard = value; }
        }

        // Check to see if ModelCard property is set
        internal bool IsSetModelCard()
        {
            return this._modelCard != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackage.
        /// </summary>
        public ModelPackage ModelPackage
        {
            get { return this._modelPackage; }
            set { this._modelPackage = value; }
        }

        // Check to see if ModelPackage property is set
        internal bool IsSetModelPackage()
        {
            return this._modelPackage != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroup.
        /// </summary>
        public ModelPackageGroup ModelPackageGroup
        {
            get { return this._modelPackageGroup; }
            set { this._modelPackageGroup = value; }
        }

        // Check to see if ModelPackageGroup property is set
        internal bool IsSetModelPackageGroup()
        {
            return this._modelPackageGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Pipeline.
        /// </summary>
        public Pipeline Pipeline
        {
            get { return this._pipeline; }
            set { this._pipeline = value; }
        }

        // Check to see if Pipeline property is set
        internal bool IsSetPipeline()
        {
            return this._pipeline != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecution.
        /// </summary>
        public PipelineExecution PipelineExecution
        {
            get { return this._pipelineExecution; }
            set { this._pipelineExecution = value; }
        }

        // Check to see if PipelineExecution property is set
        internal bool IsSetPipelineExecution()
        {
            return this._pipelineExecution != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The properties of a project.
        /// </para>
        /// </summary>
        public Project Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
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