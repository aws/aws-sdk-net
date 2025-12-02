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
    /// This is the response object from the DescribeMlflowApp operation.
    /// </summary>
    public partial class DescribeMlflowAppResponse : AmazonWebServiceResponse
    {
        private AccountDefaultStatus _accountDefaultStatus;
        private string _arn;
        private string _artifactStoreUri;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private List<string> _defaultDomainIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private MaintenanceStatus _maintenanceStatus;
        private string _mlflowVersion;
        private ModelRegistrationMode _modelRegistrationMode;
        private string _name;
        private string _roleArn;
        private MlflowAppStatus _status;
        private string _weeklyMaintenanceWindowStart;

        /// <summary>
        /// Gets and sets the property AccountDefaultStatus. 
        /// <para>
        /// Indicates whether this MLflow app is the default for the entire account.
        /// </para>
        /// </summary>
        public AccountDefaultStatus AccountDefaultStatus
        {
            get { return this._accountDefaultStatus; }
            set { this._accountDefaultStatus = value; }
        }

        // Check to see if AccountDefaultStatus property is set
        internal bool IsSetAccountDefaultStatus()
        {
            return this._accountDefaultStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the MLflow App.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The S3 URI of the general purpose bucket used as the MLflow App artifact store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ArtifactStoreUri
        {
            get { return this._artifactStoreUri; }
            set { this._artifactStoreUri = value; }
        }

        // Check to see if ArtifactStoreUri property is set
        internal bool IsSetArtifactStoreUri()
        {
            return this._artifactStoreUri != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the MLflow App was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultDomainIdList. 
        /// <para>
        /// List of SageMaker Domain IDs for which this MLflow App is the default.
        /// </para>
        /// </summary>
        public List<string> DefaultDomainIdList
        {
            get { return this._defaultDomainIdList; }
            set { this._defaultDomainIdList = value; }
        }

        // Check to see if DefaultDomainIdList property is set
        internal bool IsSetDefaultDomainIdList()
        {
            return this._defaultDomainIdList != null && (this._defaultDomainIdList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the MLflow App was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaintenanceStatus. 
        /// <para>
        /// Current maintenance status of the MLflow App.
        /// </para>
        /// </summary>
        public MaintenanceStatus MaintenanceStatus
        {
            get { return this._maintenanceStatus; }
            set { this._maintenanceStatus = value; }
        }

        // Check to see if MaintenanceStatus property is set
        internal bool IsSetMaintenanceStatus()
        {
            return this._maintenanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MlflowVersion. 
        /// <para>
        /// The MLflow version used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public string MlflowVersion
        {
            get { return this._mlflowVersion; }
            set { this._mlflowVersion = value; }
        }

        // Check to see if MlflowVersion property is set
        internal bool IsSetMlflowVersion()
        {
            return this._mlflowVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ModelRegistrationMode. 
        /// <para>
        /// Whether automatic registration of new MLflow models to the SageMaker Model Registry
        /// is enabled.
        /// </para>
        /// </summary>
        public ModelRegistrationMode ModelRegistrationMode
        {
            get { return this._modelRegistrationMode; }
            set { this._modelRegistrationMode = value; }
        }

        // Check to see if ModelRegistrationMode property is set
        internal bool IsSetModelRegistrationMode()
        {
            return this._modelRegistrationMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the MLflow App.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for an IAM role in your account that the MLflow App
        /// uses to access the artifact store in Amazon S3.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current creation status of the described MLflow App.
        /// </para>
        /// </summary>
        public MlflowAppStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week when weekly maintenance occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9)]
        public string WeeklyMaintenanceWindowStart
        {
            get { return this._weeklyMaintenanceWindowStart; }
            set { this._weeklyMaintenanceWindowStart = value; }
        }

        // Check to see if WeeklyMaintenanceWindowStart property is set
        internal bool IsSetWeeklyMaintenanceWindowStart()
        {
            return this._weeklyMaintenanceWindowStart != null;
        }

    }
}