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
    /// Represents all of the attributes of a DataBrew job.
    /// </summary>
    public partial class Job
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the job was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who created the job.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

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
        /// A dataset that the job is to process.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an encryption key that is used to protect the job
        /// output. For more information, see <a href="https://docs.aws.amazon.com/databrew/latest/dg/encryption-security-configuration.html">Encrypting
        /// data written by DataBrew jobs</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The encryption mode for the job, which can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SSE-KMS</c> - Server-side encryption with keys managed by KMS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SSE-S3</c> - Server-side encryption with keys managed by Amazon S3.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncryptionMode EncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionMode property is set.
        /// </summary>
        internal bool IsSetEncryptionMode() => this.EncryptionMode != null;

        /// <summary>
        /// Gets and sets the property JobSample. 
        /// <para>
        /// A sample configuration for profile jobs only, which determines the number of rows
        /// on which the profile job is run. If a <c>JobSample</c> value isn't provided, the default
        /// value is used. The default value is CUSTOM_ROWS for the mode parameter and 20,000
        /// for the size parameter.
        /// </para>
        /// </summary>
        public JobSample JobSample { get; set; }

        /// <summary>
        /// Checks to see if the JobSample property is set.
        /// </summary>
        internal bool IsSetJobSample() => this.JobSample != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last modified the job.
        /// </para>
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The modification date and time of the job.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LogSubscription. 
        /// <para>
        /// The current status of Amazon CloudWatch logging for the job.
        /// </para>
        /// </summary>
        public LogSubscription LogSubscription { get; set; }

        /// <summary>
        /// Checks to see if the LogSubscription property is set.
        /// </summary>
        internal bool IsSetLogSubscription() => this.LogSubscription != null;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum number of nodes that can be consumed when the job processes data.
        /// </para>
        /// </summary>
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of times to retry the job after a job run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetries property is set.
        /// </summary>
        internal bool IsSetMaxRetries() => this.MaxRetries.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 240)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// One or more artifacts that represent output from running the job.
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
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that the job is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property RecipeReference. 
        /// <para>
        /// A set of steps that the job runs.
        /// </para>
        /// </summary>
        public RecipeReference RecipeReference { get; set; }

        /// <summary>
        /// Checks to see if the RecipeReference property is set.
        /// </summary>
        internal bool IsSetRecipeReference() => this.RecipeReference != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role to be assumed for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags that have been applied to the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The job's timeout in minutes. A job that attempts to run longer than this timeout
        /// period ends with a status of <c>TIMEOUT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The job type of the job, which must be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROFILE</c> - A job to analyze a dataset, to determine its size, data types, data
        /// distribution, and more.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RECIPE</c> - A job to apply one or more transformations to a dataset.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public JobType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

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
