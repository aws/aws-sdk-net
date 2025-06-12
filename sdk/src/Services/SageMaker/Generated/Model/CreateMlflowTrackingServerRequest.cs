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
    /// Container for the parameters to the CreateMlflowTrackingServer operation.
    /// Creates an MLflow Tracking Server using a general purpose Amazon S3 bucket as the
    /// artifact store. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/mlflow-create-tracking-server.html">Create
    /// an MLflow Tracking Server</a>.
    /// </summary>
    public partial class CreateMlflowTrackingServerRequest : AmazonSageMakerRequest
    {
        private string _artifactStoreUri;
        private bool? _automaticModelRegistration;
        private string _mlflowVersion;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trackingServerName;
        private TrackingServerSize _trackingServerSize;
        private string _weeklyMaintenanceWindowStart;

        /// <summary>
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The S3 URI for a general purpose bucket to use as the MLflow Tracking Server artifact
        /// store.
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
        /// Gets and sets the property AutomaticModelRegistration. 
        /// <para>
        /// Whether to enable or disable automatic registration of new MLflow models to the SageMaker
        /// Model Registry. To enable automatic model registration, set this value to <c>True</c>.
        /// To disable automatic model registration, set this value to <c>False</c>. If not specified,
        /// <c>AutomaticModelRegistration</c> defaults to <c>False</c>.
        /// </para>
        /// </summary>
        public bool? AutomaticModelRegistration
        {
            get { return this._automaticModelRegistration; }
            set { this._automaticModelRegistration = value; }
        }

        // Check to see if AutomaticModelRegistration property is set
        internal bool IsSetAutomaticModelRegistration()
        {
            return this._automaticModelRegistration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MlflowVersion. 
        /// <para>
        /// The version of MLflow that the tracking server uses. To see which MLflow versions
        /// are available to use, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/mlflow.html#mlflow-create-tracking-server-how-it-works">How
        /// it works</a>.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for an IAM role in your account that the MLflow Tracking
        /// Server uses to access the artifact store in Amazon S3. The role should have <c>AmazonS3FullAccess</c>
        /// permissions. For more information on IAM permissions for tracking server creation,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/mlflow-create-tracking-server-iam.html">Set
        /// up IAM permissions for MLflow</a>.
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
        /// Tags consisting of key-value pairs used to manage metadata for the tracking server.
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
        /// Gets and sets the property TrackingServerName. 
        /// <para>
        /// A unique string identifying the tracking server name. This string is part of the tracking
        /// server ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TrackingServerName
        {
            get { return this._trackingServerName; }
            set { this._trackingServerName = value; }
        }

        // Check to see if TrackingServerName property is set
        internal bool IsSetTrackingServerName()
        {
            return this._trackingServerName != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingServerSize. 
        /// <para>
        /// The size of the tracking server you want to create. You can choose between <c>"Small"</c>,
        /// <c>"Medium"</c>, and <c>"Large"</c>. The default MLflow Tracking Server configuration
        /// size is <c>"Small"</c>. You can choose a size depending on the projected use of the
        /// tracking server such as the volume of data logged, number of users, and frequency
        /// of use. 
        /// </para>
        ///  
        /// <para>
        /// We recommend using a small tracking server for teams of up to 25 users, a medium tracking
        /// server for teams of up to 50 users, and a large tracking server for teams of up to
        /// 100 users. 
        /// </para>
        /// </summary>
        public TrackingServerSize TrackingServerSize
        {
            get { return this._trackingServerSize; }
            set { this._trackingServerSize = value; }
        }

        // Check to see if TrackingServerSize property is set
        internal bool IsSetTrackingServerSize()
        {
            return this._trackingServerSize != null;
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