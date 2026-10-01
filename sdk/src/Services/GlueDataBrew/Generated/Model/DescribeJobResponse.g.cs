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
    /// This is the response object from the DescribeJob operation.
    /// </summary>
    public partial class DescribeJobResponse : AmazonWebServiceResponse
    {
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
        /// The identifier (user name) of the user associated with the creation of the job.
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
        /// The dataset that the job acts upon.
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
        /// The Amazon Resource Name (ARN) of an encryption key that is used to protect the job.
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
        /// Sample configuration for profile jobs only. Determines the number of rows on which
        /// the profile job will be executed.
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
        /// The identifier (user name) of the user who last modified the job.
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
        /// The date and time that the job was last modified.
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
        /// Indicates whether Amazon CloudWatch logging is enabled for this job.
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
        /// The maximum number of compute nodes that DataBrew can consume when the job processes
        /// data.
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
        /// The name of the job.
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
        /// One or more artifacts that represent the output from running the job.
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
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The DataBrew project associated with this job.
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
        /// </summary>
        public RecipeReference RecipeReference { get; set; }

        /// <summary>
        /// Checks to see if the RecipeReference property is set.
        /// </summary>
        internal bool IsSetRecipeReference() => this.RecipeReference != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job.
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
        /// The ARN of the Identity and Access Management (IAM) role to be assumed when DataBrew
        /// runs the job.
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
        /// Metadata tags associated with this job.
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
        /// The job type, which must be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROFILE</c> - The job analyzes the dataset to determine its size, data types,
        /// data distribution, and more.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RECIPE</c> - The job applies one or more transformations to a dataset.
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
