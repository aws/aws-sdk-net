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
    /// Represents all of the attributes of a DataBrew job.
    /// </summary>
    public partial class Job
    {
        private string _accountId;
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
        private string _projectName;
        private RecipeReference _recipeReference;
        private string _resourceArn;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _timeout;
        private JobType _type;
        private List<ValidationConfiguration> _validationConfigurations = AWSConfigs.InitializeCollections ? new List<ValidationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

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
        /// The Amazon Resource Name (ARN) of the user who created the job.
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
        /// A dataset that the job is to process.
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
        /// The Amazon Resource Name (ARN) of an encryption key that is used to protect the job
        /// output. For more information, see <a href="https://docs.aws.amazon.com/databrew/latest/dg/encryption-security-configuration.html">Encrypting
        /// data written by DataBrew jobs</a> 
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
        /// A sample configuration for profile jobs only, which determines the number of rows
        /// on which the profile job is run. If a <c>JobSample</c> value isn't provided, the default
        /// value is used. The default value is CUSTOM_ROWS for the mode parameter and 20,000
        /// for the size parameter.
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
        /// The Amazon Resource Name (ARN) of the user who last modified the job.
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
        /// The modification date and time of the job.
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
        /// The current status of Amazon CloudWatch logging for the job.
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
        /// The maximum number of nodes that can be consumed when the job processes data.
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
        /// The unique name of the job.
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
        /// One or more artifacts that represent output from running the job.
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
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that the job is associated with.
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
        /// <para>
        /// A set of steps that the job runs.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) for the job.
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
        /// The Amazon Resource Name (ARN) of the role to be assumed for this job.
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
        /// Metadata tags that have been applied to the job.
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