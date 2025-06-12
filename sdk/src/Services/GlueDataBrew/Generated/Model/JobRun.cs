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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents one run of a DataBrew job.
    /// </summary>
    public partial class JobRun
    {
        private int? _attempt;
        private DateTime? _completedOn;
        private List<DatabaseOutput> _databaseOutputs = AWSConfigs.InitializeCollections ? new List<DatabaseOutput>() : null;
        private List<DataCatalogOutput> _dataCatalogOutputs = AWSConfigs.InitializeCollections ? new List<DataCatalogOutput>() : null;
        private string _datasetName;
        private string _errorMessage;
        private int? _executionTime;
        private string _jobName;
        private JobSample _jobSample;
        private string _logGroupName;
        private LogSubscription _logSubscription;
        private List<Output> _outputs = AWSConfigs.InitializeCollections ? new List<Output>() : null;
        private RecipeReference _recipeReference;
        private string _runId;
        private string _startedBy;
        private DateTime? _startedOn;
        private JobRunState _state;
        private List<ValidationConfiguration> _validationConfigurations = AWSConfigs.InitializeCollections ? new List<ValidationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The number of times that DataBrew has attempted to run the job.
        /// </para>
        /// </summary>
        public int? Attempt
        {
            get { return this._attempt; }
            set { this._attempt = value; }
        }

        // Check to see if Attempt property is set
        internal bool IsSetAttempt()
        {
            return this._attempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time when the job completed processing.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn
        {
            get { return this._completedOn; }
            set { this._completedOn = value; }
        }

        // Check to see if CompletedOn property is set
        internal bool IsSetCompletedOn()
        {
            return this._completedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseOutputs. 
        /// <para>
        /// Represents a list of JDBC database output objects which defines the output destination
        /// for a DataBrew recipe job to write into.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<DatabaseOutput> DatabaseOutputs
        {
            get { return this._databaseOutputs; }
            set { this._databaseOutputs = value; }
        }

        // Check to see if DatabaseOutputs property is set
        internal bool IsSetDatabaseOutputs()
        {
            return this._databaseOutputs != null && (this._databaseOutputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataCatalogOutputs. 
        /// <para>
        /// One or more artifacts that represent the Glue Data Catalog output from running the
        /// job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<DataCatalogOutput> DataCatalogOutputs
        {
            get { return this._dataCatalogOutputs; }
            set { this._dataCatalogOutputs = value; }
        }

        // Check to see if DataCatalogOutputs property is set
        internal bool IsSetDataCatalogOutputs()
        {
            return this._dataCatalogOutputs != null && (this._dataCatalogOutputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset for the job to process.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message indicating an error (if any) that was encountered when the job ran.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The amount of time, in seconds, during which a job run consumed resources.
        /// </para>
        /// </summary>
        public int? ExecutionTime
        {
            get { return this._executionTime; }
            set { this._executionTime = value; }
        }

        // Check to see if ExecutionTime property is set
        internal bool IsSetExecutionTime()
        {
            return this._executionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job being processed during this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=240)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobSample. 
        /// <para>
        /// A sample configuration for profile jobs only, which determines the number of rows
        /// on which the profile job is run. If a <c>JobSample</c> value isn't provided, the default
        /// is used. The default value is CUSTOM_ROWS for the mode parameter and 20,000 for the
        /// size parameter.
        /// </para>
        /// </summary>
        public JobSample JobSample
        {
            get { return this._jobSample; }
            set { this._jobSample = value; }
        }

        // Check to see if JobSample property is set
        internal bool IsSetJobSample()
        {
            return this._jobSample != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of an Amazon CloudWatch log group, where the job writes diagnostic messages
        /// when it runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property LogSubscription. 
        /// <para>
        /// The current status of Amazon CloudWatch logging for the job run.
        /// </para>
        /// </summary>
        public LogSubscription LogSubscription
        {
            get { return this._logSubscription; }
            set { this._logSubscription = value; }
        }

        // Check to see if LogSubscription property is set
        internal bool IsSetLogSubscription()
        {
            return this._logSubscription != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// One or more output artifacts from a job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecipeReference. 
        /// <para>
        /// The set of steps processed by the job.
        /// </para>
        /// </summary>
        public RecipeReference RecipeReference
        {
            get { return this._recipeReference; }
            set { this._recipeReference = value; }
        }

        // Check to see if RecipeReference property is set
        internal bool IsSetRecipeReference()
        {
            return this._recipeReference != null;
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who initiated the job run. 
        /// </para>
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time when the job run began. 
        /// </para>
        /// </summary>
        public DateTime? StartedOn
        {
            get { return this._startedOn; }
            set { this._startedOn = value; }
        }

        // Check to see if StartedOn property is set
        internal bool IsSetStartedOn()
        {
            return this._startedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the job run entity itself.
        /// </para>
        /// </summary>
        public JobRunState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationConfigurations. 
        /// <para>
        /// List of validation configurations that are applied to the profile job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ValidationConfiguration> ValidationConfigurations
        {
            get { return this._validationConfigurations; }
            set { this._validationConfigurations = value; }
        }

        // Check to see if ValidationConfigurations property is set
        internal bool IsSetValidationConfigurations()
        {
            return this._validationConfigurations != null && (this._validationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}