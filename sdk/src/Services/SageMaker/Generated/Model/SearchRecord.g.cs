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
    /// A single resource returned as part of the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
    /// API response.
    /// </summary>
    public partial class SearchRecord
    {
        /// <summary>
        /// Gets and sets the property Endpoint.
        /// </summary>
        public Endpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Experiment. 
        /// <para>
        /// The properties of an experiment.
        /// </para>
        /// </summary>
        public Experiment Experiment { get; set; }

        /// <summary>
        /// Checks to see if the Experiment property is set.
        /// </summary>
        internal bool IsSetExperiment() => this.Experiment != null;

        /// <summary>
        /// Gets and sets the property FeatureGroup.
        /// </summary>
        public FeatureGroup FeatureGroup { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroup property is set.
        /// </summary>
        internal bool IsSetFeatureGroup() => this.FeatureGroup != null;

        /// <summary>
        /// Gets and sets the property FeatureMetadata. 
        /// <para>
        /// The feature metadata used to search through the features.
        /// </para>
        /// </summary>
        public FeatureMetadata FeatureMetadata { get; set; }

        /// <summary>
        /// Checks to see if the FeatureMetadata property is set.
        /// </summary>
        internal bool IsSetFeatureMetadata() => this.FeatureMetadata != null;

        /// <summary>
        /// Gets and sets the property HubContent. 
        /// <para>
        /// The properties of a hub content resource.
        /// </para>
        /// </summary>
        public HubContent HubContent { get; set; }

        /// <summary>
        /// Checks to see if the HubContent property is set.
        /// </summary>
        internal bool IsSetHubContent() => this.HubContent != null;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJob. 
        /// <para>
        /// The properties of a hyperparameter tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobSearchEntity HyperParameterTuningJob { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningJob property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningJob() => this.HyperParameterTuningJob != null;

        /// <summary>
        /// Gets and sets the property Job. 
        /// <para>
        /// The properties of a job.
        /// </para>
        /// </summary>
        public Job Job { get; set; }

        /// <summary>
        /// Checks to see if the Job property is set.
        /// </summary>
        internal bool IsSetJob() => this.Job != null;

        /// <summary>
        /// Gets and sets the property Model.
        /// </summary>
        public ModelDashboardModel Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property ModelCard. 
        /// <para>
        /// An Amazon SageMaker Model Card that documents details about a machine learning model.
        /// </para>
        /// </summary>
        public ModelCard ModelCard { get; set; }

        /// <summary>
        /// Checks to see if the ModelCard property is set.
        /// </summary>
        internal bool IsSetModelCard() => this.ModelCard != null;

        /// <summary>
        /// Gets and sets the property ModelPackage.
        /// </summary>
        public ModelPackage ModelPackage { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackage property is set.
        /// </summary>
        internal bool IsSetModelPackage() => this.ModelPackage != null;

        /// <summary>
        /// Gets and sets the property ModelPackageGroup.
        /// </summary>
        public ModelPackageGroup ModelPackageGroup { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageGroup property is set.
        /// </summary>
        internal bool IsSetModelPackageGroup() => this.ModelPackageGroup != null;

        /// <summary>
        /// Gets and sets the property Pipeline.
        /// </summary>
        public Pipeline Pipeline { get; set; }

        /// <summary>
        /// Checks to see if the Pipeline property is set.
        /// </summary>
        internal bool IsSetPipeline() => this.Pipeline != null;

        /// <summary>
        /// Gets and sets the property PipelineExecution.
        /// </summary>
        public PipelineExecution PipelineExecution { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExecution property is set.
        /// </summary>
        internal bool IsSetPipelineExecution() => this.PipelineExecution != null;

        /// <summary>
        /// Gets and sets the property PipelineVersion. 
        /// <para>
        /// The version of the pipeline.
        /// </para>
        /// </summary>
        public PipelineVersion PipelineVersion { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersion property is set.
        /// </summary>
        internal bool IsSetPipelineVersion() => this.PipelineVersion != null;

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The properties of a project.
        /// </para>
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Checks to see if the Project property is set.
        /// </summary>
        internal bool IsSetProject() => this.Project != null;

        /// <summary>
        /// Gets and sets the property TrainingJob. 
        /// <para>
        /// The properties of a training job.
        /// </para>
        /// </summary>
        public TrainingJob TrainingJob { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJob property is set.
        /// </summary>
        internal bool IsSetTrainingJob() => this.TrainingJob != null;

        /// <summary>
        /// Gets and sets the property Trial. 
        /// <para>
        /// The properties of a trial.
        /// </para>
        /// </summary>
        public Trial Trial { get; set; }

        /// <summary>
        /// Checks to see if the Trial property is set.
        /// </summary>
        internal bool IsSetTrial() => this.Trial != null;

        /// <summary>
        /// Gets and sets the property TrialComponent. 
        /// <para>
        /// The properties of a trial component.
        /// </para>
        /// </summary>
        public TrialComponent TrialComponent { get; set; }

        /// <summary>
        /// Checks to see if the TrialComponent property is set.
        /// </summary>
        internal bool IsSetTrialComponent() => this.TrialComponent != null;
    }
}
