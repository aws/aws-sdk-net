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
    /// Container for the parameters to the CreateMlflowApp operation. Creates an MLflow Tracking
    /// Server using a general purpose Amazon S3 bucket as the artifact store.
    /// </summary>
    public partial class CreateMlflowAppRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AccountDefaultStatus. 
        /// <para>
        /// Indicates whether this MLflow app is the default for the entire account.
        /// </para>
        /// </summary>
        public AccountDefaultStatus AccountDefaultStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccountDefaultStatus property is set.
        /// </summary>
        internal bool IsSetAccountDefaultStatus() => this.AccountDefaultStatus != null;

        /// <summary>
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The S3 URI for a general purpose bucket to use as the MLflow App artifact store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string ArtifactStoreUri { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactStoreUri property is set.
        /// </summary>
        internal bool IsSetArtifactStoreUri() => this.ArtifactStoreUri != null;

        /// <summary>
        /// Gets and sets the property DefaultDomainIdList. 
        /// <para>
        /// List of SageMaker domain IDs for which this MLflow App is used as the default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DefaultDomainIdList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DefaultDomainIdList property is set.
        /// </summary>
        internal bool IsSetDefaultDomainIdList() => this.DefaultDomainIdList != null && (this.DefaultDomainIdList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services KMS key used to encrypt the data at rest associated
        /// with the MLflow App. If you don't specify a value, the MLflow App is not encrypted
        /// with a customer-managed key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property ModelRegistrationMode. 
        /// <para>
        /// Whether to enable or disable automatic registration of new MLflow models to the SageMaker
        /// Model Registry. To enable automatic model registration, set this value to <c>AutoModelRegistrationEnabled</c>.
        /// To disable automatic model registration, set this value to <c>AutoModelRegistrationDisabled</c>.
        /// If not specified, <c>AutomaticModelRegistration</c> defaults to <c>AutoModelRegistrationDisabled</c>.
        /// </para>
        /// </summary>
        public ModelRegistrationMode ModelRegistrationMode { get; set; }

        /// <summary>
        /// Checks to see if the ModelRegistrationMode property is set.
        /// </summary>
        internal bool IsSetModelRegistrationMode() => this.ModelRegistrationMode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A string identifying the MLflow app name. This string is not part of the tracking
        /// server ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for an IAM role in your account that the MLflow App
        /// uses to access the artifact store in Amazon S3. The role should have the <c>AmazonS3FullAccess</c>
        /// permission.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags consisting of key-value pairs used to manage metadata for the MLflow App.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week in Coordinated Universal Time (UTC) 24-hour standard
        /// time that weekly maintenance updates are scheduled. For example: TUE:03:30.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 9)]
        public string WeeklyMaintenanceWindowStart { get; set; }

        /// <summary>
        /// Checks to see if the WeeklyMaintenanceWindowStart property is set.
        /// </summary>
        internal bool IsSetWeeklyMaintenanceWindowStart() => this.WeeklyMaintenanceWindowStart != null;
    }
}
