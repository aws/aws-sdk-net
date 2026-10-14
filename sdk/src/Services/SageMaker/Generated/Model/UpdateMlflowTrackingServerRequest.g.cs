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
    /// Container for the parameters to the UpdateMlflowTrackingServer operation. Updates
    /// properties of an existing MLflow Tracking Server.
    /// </summary>
    public partial class UpdateMlflowTrackingServerRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The new S3 URI for the general purpose bucket to use as the artifact store for the
        /// MLflow Tracking Server.
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
        /// Whether to enable or disable automatic registration of new MLflow models to the SageMaker
        /// Model Registry. To enable automatic model registration, set this value to <c>True</c>.
        /// To disable automatic model registration, set this value to <c>False</c>. If not specified,
        /// <c>AutomaticModelRegistration</c> defaults to <c>False</c> 
        /// </para>
        /// </summary>
        public bool? AutomaticModelRegistration { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticModelRegistration property is set.
        /// </summary>
        internal bool IsSetAutomaticModelRegistration() => this.AutomaticModelRegistration.HasValue;

        /// <summary>
        /// Gets and sets the property S3BucketOwnerAccountId. 
        /// <para>
        /// The new expected Amazon Web Services account ID that owns the Amazon S3 bucket for
        /// artifact storage.
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
        /// Whether to enable or disable Amazon S3 Bucket Owenrship Verifaction whenever the MLflow
        /// Tracking Server interacts with Amazon Amazon S3.
        /// </para>
        /// </summary>
        public bool? S3BucketOwnerVerification { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwnerVerification property is set.
        /// </summary>
        internal bool IsSetS3BucketOwnerVerification() => this.S3BucketOwnerVerification.HasValue;

        /// <summary>
        /// Gets and sets the property TrackingServerName. 
        /// <para>
        /// The name of the MLflow Tracking Server to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TrackingServerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerName property is set.
        /// </summary>
        internal bool IsSetTrackingServerName() => this.TrackingServerName != null;

        /// <summary>
        /// Gets and sets the property TrackingServerSize. 
        /// <para>
        /// The new size for the MLflow Tracking Server.
        /// </para>
        /// </summary>
        public TrackingServerSize TrackingServerSize { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerSize property is set.
        /// </summary>
        internal bool IsSetTrackingServerSize() => this.TrackingServerSize != null;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The new weekly maintenance window start day and time to update. The maintenance window
        /// day and time should be in Coordinated Universal Time (UTC) 24-hour standard time.
        /// For example: TUE:03:30.
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
