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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// This is the response object from the DescribeJobRun operation.
    /// </summary>
    public partial class DescribeJobRunResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The number of times that DataBrew has attempted to run the job.
        /// </para>
        /// </summary>
        public int? Attempt { get; set; }

        /// <summary>
        /// Checks to see if the Attempt property is set.
        /// </summary>
        internal bool IsSetAttempt() => this.Attempt.HasValue;

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time when the job completed processing.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Checks to see if the CompletedOn property is set.
        /// </summary>
        internal bool IsSetCompletedOn() => this.CompletedOn.HasValue;

        /// <summary>
        /// Gets and sets the property DataCatalogOutputs. 
        /// <para>
        /// One or more artifacts that represent the Glue Data Catalog output from running the
        /// job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<DataCatalogOutput> DataCatalogOutputs { get; set; } = AWSConfigs.InitializeCollections ? new List<DataCatalogOutput>() : null;

        /// <summary>
        /// Checks to see if the DataCatalogOutputs property is set.
        /// </summary>
        internal bool IsSetDataCatalogOutputs() => this.DataCatalogOutputs != null && (this.DataCatalogOutputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DatabaseOutputs. 
        /// <para>
        /// Represents a list of JDBC database output objects which defines the output destination
        /// for a DataBrew recipe job to write into.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<DatabaseOutput> DatabaseOutputs { get; set; } = AWSConfigs.InitializeCollections ? new List<DatabaseOutput>() : null;

        /// <summary>
        /// Checks to see if the DatabaseOutputs property is set.
        /// </summary>
        internal bool IsSetDatabaseOutputs() => this.DatabaseOutputs != null && (this.DatabaseOutputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset for the job to process.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message indicating an error (if any) that was encountered when the job ran.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The amount of time, in seconds, during which the job run consumed resources.
        /// </para>
        /// </summary>
        public int? ExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTime property is set.
        /// </summary>
        internal bool IsSetExecutionTime() => this.ExecutionTime.HasValue;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job being processed during this run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 240)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobSample. 
        /// <para>
        /// Sample configuration for profile jobs only. Determines the number of rows on which
        /// the profile job will be executed. If a JobSample value is not provided, the default
        /// value will be used. The default value is CUSTOM_ROWS for the mode parameter and 20000
        /// for the size parameter.
        /// </para>
        /// </summary>
        public JobSample JobSample { get; set; }

        /// <summary>
        /// Checks to see if the JobSample property is set.
        /// </summary>
        internal bool IsSetJobSample() => this.JobSample != null;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of an Amazon CloudWatch log group, where the job writes diagnostic messages
        /// when it runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property LogSubscription. 
        /// <para>
        /// The current status of Amazon CloudWatch logging for the job run.
        /// </para>
        /// </summary>
        public LogSubscription LogSubscription { get; set; }

        /// <summary>
        /// Checks to see if the LogSubscription property is set.
        /// </summary>
        internal bool IsSetLogSubscription() => this.LogSubscription != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// One or more output artifacts from a job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<Output> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<Output>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProfileConfiguration. 
        /// <para>
        /// Configuration for profile jobs. Used to select columns, do evaluations, and override
        /// default parameters of evaluations. When configuration is null, the profile job will
        /// run with default settings.
        /// </para>
        /// </summary>
        public ProfileConfiguration ProfileConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProfileConfiguration property is set.
        /// </summary>
        internal bool IsSetProfileConfiguration() => this.ProfileConfiguration != null;

        /// <summary>
        /// Gets and sets the property RecipeReference.
        /// </summary>
        public RecipeReference RecipeReference { get; set; }

        /// <summary>
        /// Checks to see if the RecipeReference property is set.
        /// </summary>
        internal bool IsSetRecipeReference() => this.RecipeReference != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who started the job run.
        /// </para>
        /// </summary>
        public string StartedBy { get; set; }

        /// <summary>
        /// Checks to see if the StartedBy property is set.
        /// </summary>
        internal bool IsSetStartedBy() => this.StartedBy != null;

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time when the job run began.
        /// </para>
        /// </summary>
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Checks to see if the StartedOn property is set.
        /// </summary>
        internal bool IsSetStartedOn() => this.StartedOn.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the job run entity itself.
        /// </para>
        /// </summary>
        public JobRunState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property ValidationConfigurations. 
        /// <para>
        /// List of validation configurations that are applied to the profile job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ValidationConfiguration> ValidationConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ValidationConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ValidationConfigurations property is set.
        /// </summary>
        internal bool IsSetValidationConfigurations() => this.ValidationConfigurations != null && (this.ValidationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
