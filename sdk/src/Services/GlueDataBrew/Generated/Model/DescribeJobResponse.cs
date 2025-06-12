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
    /// This is the response object from the DescribeJob operation.
    /// </summary>
    public partial class DescribeJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _createDate;
        private string _createdBy;
        private List<DatabaseOutput> _databaseOutputs = AWSConfigs.InitializeCollections ? new List<DatabaseOutput>() : null;
        private List<DataCatalogOutput> _dataCatalogOutputs = AWSConfigs.InitializeCollections ? new List<DataCatalogOutput>() : null;
        private string _datasetName;
        private string _encryptionKeyArn;
        private EncryptionMode _encryptionMode;
        private JobSample _jobSample;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedDate;
        private LogSubscription _logSubscription;
        private int? _maxCapacity;
        private int? _maxRetries;
        private string _name;
        private List<Output> _outputs = AWSConfigs.InitializeCollections ? new List<Output>() : null;
        private ProfileConfiguration _profileConfiguration;
        private string _projectName;
        private RecipeReference _recipeReference;
        private string _resourceArn;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _timeout;
        private JobType _type;
        private List<ValidationConfiguration> _validationConfigurations = AWSConfigs.InitializeCollections ? new List<ValidationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the job was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier (user name) of the user associated with the creation of the job.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
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
        /// The dataset that the job acts upon.
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
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an encryption key that is used to protect the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

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
        public EncryptionMode EncryptionMode
        {
            get { return this._encryptionMode; }
            set { this._encryptionMode = value; }
        }

        // Check to see if EncryptionMode property is set
        internal bool IsSetEncryptionMode()
        {
            return this._encryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property JobSample. 
        /// <para>
        /// Sample configuration for profile jobs only. Determines the number of rows on which
        /// the profile job will be executed.
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
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The identifier (user name) of the user who last modified the job.
        /// </para>
        /// </summary>
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time that the job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogSubscription. 
        /// <para>
        /// Indicates whether Amazon CloudWatch logging is enabled for this job.
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
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum number of compute nodes that DataBrew can consume when the job processes
        /// data.
        /// </para>
        /// </summary>
        public int? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of times to retry the job after a job run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MaxRetries
        {
            get { return this._maxRetries; }
            set { this._maxRetries = value; }
        }

        // Check to see if MaxRetries property is set
        internal bool IsSetMaxRetries()
        {
            return this._maxRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=240)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// One or more artifacts that represent the output from running the job.
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
        /// Gets and sets the property ProfileConfiguration. 
        /// <para>
        /// Configuration for profile jobs. Used to select columns, do evaluations, and override
        /// default parameters of evaluations. When configuration is null, the profile job will
        /// run with default settings.
        /// </para>
        /// </summary>
        public ProfileConfiguration ProfileConfiguration
        {
            get { return this._profileConfiguration; }
            set { this._profileConfiguration = value; }
        }

        // Check to see if ProfileConfiguration property is set
        internal bool IsSetProfileConfiguration()
        {
            return this._profileConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The DataBrew project associated with this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeReference.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the Identity and Access Management (IAM) role to be assumed when DataBrew
        /// runs the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata tags associated with this job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The job's timeout in minutes. A job that attempts to run longer than this timeout
        /// period ends with a status of <c>TIMEOUT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

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
        public JobType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationConfigurations. 
        /// <para>
        /// List of validation configurations that are applied to the profile job.
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