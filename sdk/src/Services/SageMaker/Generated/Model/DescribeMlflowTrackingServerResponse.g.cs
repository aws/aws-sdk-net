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
    /// This is the response object from the DescribeMlflowTrackingServer operation.
    /// </summary>
    public partial class DescribeMlflowTrackingServerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The S3 URI of the general purpose bucket used as the MLflow Tracking Server artifact
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ArtifactStoreUri { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactStoreUri property is set.
        /// </summary>
        internal bool IsSetArtifactStoreUri() => this.ArtifactStoreUri != null;

        /// <summary>
        /// Gets and sets the property AutomaticModelRegistration. 
        /// <para>
        /// Whether automatic registration of new MLflow models to the SageMaker Model Registry
        /// is enabled.
        /// </para>
        /// </summary>
        public bool? AutomaticModelRegistration { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticModelRegistration property is set.
        /// </summary>
        internal bool IsSetAutomaticModelRegistration() => this.AutomaticModelRegistration.HasValue;

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
        /// The timestamp of when the described MLflow Tracking Server was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// Whether the described MLflow Tracking Server is currently active.
        /// </para>
        /// </summary>
        public IsTrackingServerActive IsActive { get; set; }

        /// <summary>
        /// Checks to see if the IsActive property is set.
        /// </summary>
        internal bool IsSetIsActive() => this.IsActive != null;

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
        /// The timestamp of when the described MLflow Tracking Server was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MlflowVersion. 
        /// <para>
        /// The MLflow version used for the described tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public string MlflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the MlflowVersion property is set.
        /// </summary>
        internal bool IsSetMlflowVersion() => this.MlflowVersion != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for an IAM role in your account that the described
        /// MLflow Tracking Server uses to access the artifact store in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwnerAccountId. 
        /// <para>
        /// Expected Amazon Web Services account ID that owns the Amazon S3 bucket for artifact
        /// storage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string S3BucketOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetS3BucketOwnerAccountId() => this.S3BucketOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwnerVerification. 
        /// <para>
        /// Whether Amazon S3 Bucket Ownership checks are enabled whenever the tracking server
        /// interacts with Amazon Amazon S3.
        /// </para>
        /// </summary>
        public bool? S3BucketOwnerVerification { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwnerVerification property is set.
        /// </summary>
        internal bool IsSetS3BucketOwnerVerification() => this.S3BucketOwnerVerification.HasValue;

        /// <summary>
        /// Gets and sets the property TrackingServerArn. 
        /// <para>
        /// The ARN of the described tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string TrackingServerArn { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerArn property is set.
        /// </summary>
        internal bool IsSetTrackingServerArn() => this.TrackingServerArn != null;

        /// <summary>
        /// Gets and sets the property TrackingServerMaintenanceStatus. 
        /// <para>
        ///  The current maintenance status of the described MLflow Tracking Server. 
        /// </para>
        /// </summary>
        public TrackingServerMaintenanceStatus TrackingServerMaintenanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerMaintenanceStatus property is set.
        /// </summary>
        internal bool IsSetTrackingServerMaintenanceStatus() => this.TrackingServerMaintenanceStatus != null;

        /// <summary>
        /// Gets and sets the property TrackingServerName. 
        /// <para>
        /// The name of the described tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TrackingServerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerName property is set.
        /// </summary>
        internal bool IsSetTrackingServerName() => this.TrackingServerName != null;

        /// <summary>
        /// Gets and sets the property TrackingServerSize. 
        /// <para>
        /// The size of the described tracking server.
        /// </para>
        /// </summary>
        public TrackingServerSize TrackingServerSize { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerSize property is set.
        /// </summary>
        internal bool IsSetTrackingServerSize() => this.TrackingServerSize != null;

        /// <summary>
        /// Gets and sets the property TrackingServerStatus. 
        /// <para>
        /// The current creation status of the described MLflow Tracking Server.
        /// </para>
        /// </summary>
        public TrackingServerStatus TrackingServerStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerStatus property is set.
        /// </summary>
        internal bool IsSetTrackingServerStatus() => this.TrackingServerStatus != null;

        /// <summary>
        /// Gets and sets the property TrackingServerUrl. 
        /// <para>
        /// The URL to connect to the MLflow user interface for the described tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string TrackingServerUrl { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerUrl property is set.
        /// </summary>
        internal bool IsSetTrackingServerUrl() => this.TrackingServerUrl != null;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week when weekly maintenance occurs on the described tracking
        /// server.
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
