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
    /// The summary of the tracking server to list.
    /// </summary>
    public partial class TrackingServerSummary
    {
        private DateTime? _creationTime;
        private IsTrackingServerActive _isActive;
        private DateTime? _lastModifiedTime;
        private string _mlflowVersion;
        private string _trackingServerArn;
        private string _trackingServerName;
        private TrackingServerStatus _trackingServerStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of a listed tracking server.
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
        /// The activity status of a listed tracking server.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time of a listed tracking server.
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
        /// The MLflow version used for a listed tracking server.
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
        /// Gets and sets the property TrackingServerArn. 
        /// <para>
        /// The ARN of a listed tracking server.
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
        /// Gets and sets the property TrackingServerName. 
        /// <para>
        /// The name of a listed tracking server.
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
        /// Gets and sets the property TrackingServerStatus. 
        /// <para>
        /// The creation status of a listed tracking server.
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

    }
}