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
    /// Container for the parameters to the CreateMlflowApp operation.
    /// Creates an MLflow Tracking Server using a general purpose Amazon S3 bucket as the
    /// artifact store.
    /// </summary>
    public partial class CreateMlflowAppRequest : AmazonSageMakerRequest
    {
        private AccountDefaultStatus _accountDefaultStatus;
        private string _artifactStoreUri;
        private List<string> _defaultDomainIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ModelRegistrationMode _modelRegistrationMode;
        private string _name;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
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
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The S3 URI for a general purpose bucket to use as the MLflow App artifact store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
        /// Gets and sets the property DefaultDomainIdList. 
        /// <para>
        /// List of SageMaker domain IDs for which this MLflow App is used as the default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property ModelRegistrationMode. 
        /// <para>
        /// Whether to enable or disable automatic registration of new MLflow models to the SageMaker
        /// Model Registry. To enable automatic model registration, set this value to <c>AutoModelRegistrationEnabled</c>.
        /// To disable automatic model registration, set this value to <c>AutoModelRegistrationDisabled</c>.
        /// If not specified, <c>AutomaticModelRegistration</c> defaults to <c>AutoModelRegistrationDisabled</c>.
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
        /// A string identifying the MLflow app name. This string is not part of the tracking
        /// server ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// uses to access the artifact store in Amazon S3. The role should have the <c>AmazonS3FullAccess</c>
        /// permission.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Tags consisting of key-value pairs used to manage metadata for the MLflow App.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week in Coordinated Universal Time (UTC) 24-hour standard
        /// time that weekly maintenance updates are scheduled. For example: TUE:03:30.
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