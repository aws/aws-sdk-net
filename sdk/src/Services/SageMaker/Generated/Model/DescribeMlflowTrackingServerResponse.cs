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
    /// This is the response object from the DescribeMlflowTrackingServer operation.
    /// </summary>
    public partial class DescribeMlflowTrackingServerResponse : AmazonWebServiceResponse
    {
        private string _artifactStoreUri;
        private bool? _automaticModelRegistration;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private IsTrackingServerActive _isActive;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private string _mlflowVersion;
        private string _roleArn;
        private string _trackingServerArn;
        private TrackingServerMaintenanceStatus _trackingServerMaintenanceStatus;
        private string _trackingServerName;
        private TrackingServerSize _trackingServerSize;
        private TrackingServerStatus _trackingServerStatus;
        private string _trackingServerUrl;
        private string _weeklyMaintenanceWindowStart;

        /// <summary>
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The S3 URI of the general purpose bucket used as the MLflow Tracking Server artifact
        /// store.
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
        /// Gets and sets the property AutomaticModelRegistration. 
        /// <para>
        /// Whether automatic registration of new MLflow models to the SageMaker Model Registry
        /// is enabled.
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
        /// The timestamp of when the described MLflow Tracking Server was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsActive. 
        /// <para>
        /// Whether the described MLflow Tracking Server is currently active.
        /// </para>
        /// </summary>
        public IsTrackingServerActive IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }

        // Check to see if IsActive property is set
        internal bool IsSetIsActive()
        {
            return this._isActive != null;
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
        /// The timestamp of when the described MLflow Tracking Server was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MlflowVersion. 
        /// <para>
        /// The MLflow version used for the described tracking server.
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
        /// The Amazon Resource Name (ARN) for an IAM role in your account that the described
        /// MLflow Tracking Server uses to access the artifact store in Amazon S3.
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
        /// Gets and sets the property TrackingServerArn. 
        /// <para>
        /// The ARN of the described tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string TrackingServerArn
        {
            get { return this._trackingServerArn; }
            set { this._trackingServerArn = value; }
        }

        // Check to see if TrackingServerArn property is set
        internal bool IsSetTrackingServerArn()
        {
            return this._trackingServerArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingServerMaintenanceStatus. 
        /// <para>
        ///  The current maintenance status of the described MLflow Tracking Server. 
        /// </para>
        /// </summary>
        public TrackingServerMaintenanceStatus TrackingServerMaintenanceStatus
        {
            get { return this._trackingServerMaintenanceStatus; }
            set { this._trackingServerMaintenanceStatus = value; }
        }

        // Check to see if TrackingServerMaintenanceStatus property is set
        internal bool IsSetTrackingServerMaintenanceStatus()
        {
            return this._trackingServerMaintenanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingServerName. 
        /// <para>
        /// The name of the described tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// The size of the described tracking server.
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
        /// Gets and sets the property TrackingServerStatus. 
        /// <para>
        /// The current creation status of the described MLflow Tracking Server.
        /// </para>
        /// </summary>
        public TrackingServerStatus TrackingServerStatus
        {
            get { return this._trackingServerStatus; }
            set { this._trackingServerStatus = value; }
        }

        // Check to see if TrackingServerStatus property is set
        internal bool IsSetTrackingServerStatus()
        {
            return this._trackingServerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingServerUrl. 
        /// <para>
        /// The URL to connect to the MLflow user interface for the described tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string TrackingServerUrl
        {
            get { return this._trackingServerUrl; }
            set { this._trackingServerUrl = value; }
        }

        // Check to see if TrackingServerUrl property is set
        internal bool IsSetTrackingServerUrl()
        {
            return this._trackingServerUrl != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The day and time of the week when weekly maintenance occurs on the described tracking
        /// server.
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