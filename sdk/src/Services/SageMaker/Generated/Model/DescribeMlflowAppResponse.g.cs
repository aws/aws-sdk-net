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
    /// This is the response object from the DescribeMlflowApp operation.
    /// </summary>
    public partial class DescribeMlflowAppResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the MLflow App.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The S3 URI of the general purpose bucket used as the MLflow App artifact store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ArtifactStoreUri { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactStoreUri property is set.
        /// </summary>
        internal bool IsSetArtifactStoreUri() => this.ArtifactStoreUri != null;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the MLflow App was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultDomainIdList. 
        /// <para>
        /// List of SageMaker Domain IDs for which this MLflow App is the default.
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
        /// with the MLflow App. This field is absent if the MLflow App is not encrypted with
        /// a customer-managed key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the MLflow App was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaintenanceStatus. 
        /// <para>
        /// Current maintenance status of the MLflow App.
        /// </para>
        /// </summary>
        public MaintenanceStatus MaintenanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceStatus property is set.
        /// </summary>
        internal bool IsSetMaintenanceStatus() => this.MaintenanceStatus != null;

        /// <summary>
        /// Gets and sets the property MlflowVersion. 
        /// <para>
        /// The MLflow version used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public string MlflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the MlflowVersion property is set.
        /// </summary>
        internal bool IsSetMlflowVersion() => this.MlflowVersion != null;

        /// <summary>
        /// Gets and sets the property ModelRegistrationMode. 
        /// <para>
        /// Whether automatic registration of new MLflow models to the SageMaker Model Registry
        /// is enabled.
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
        /// The name of the MLflow App.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for an IAM role in your account that the MLflow App
        /// uses to access the artifact store in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current creation status of the described MLflow App.
        /// </para>
        /// </summary>
        public MlflowAppStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week when weekly maintenance occurs.
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
