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
    /// Container for the parameters to the UpdateMlflowTrackingServer operation.
    /// Updates properties of an existing MLflow Tracking Server.
    /// </summary>
    public partial class UpdateMlflowTrackingServerRequest : AmazonSageMakerRequest
    {
        private string _artifactStoreUri;
        private bool? _automaticModelRegistration;
        private string _trackingServerName;
        private TrackingServerSize _trackingServerSize;
        private string _weeklyMaintenanceWindowStart;

        /// <summary>
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The new S3 URI for the general purpose bucket to use as the artifact store for the
        /// MLflow Tracking Server.
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
        /// Whether to enable or disable automatic registration of new MLflow models to the SageMaker
        /// Model Registry. To enable automatic model registration, set this value to <c>True</c>.
        /// To disable automatic model registration, set this value to <c>False</c>. If not specified,
        /// <c>AutomaticModelRegistration</c> defaults to <c>False</c> 
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
        /// Gets and sets the property TrackingServerName. 
        /// <para>
        /// The name of the MLflow Tracking Server to update.
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
        /// The new size for the MLflow Tracking Server.
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
        /// The new weekly maintenance window start day and time to update. The maintenance window
        /// day and time should be in Coordinated Universal Time (UTC) 24-hour standard time.
        /// For example: TUE:03:30.
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