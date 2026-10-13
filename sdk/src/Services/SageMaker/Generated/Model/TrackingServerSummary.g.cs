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
    /// The summary of the tracking server to list.
    /// </summary>
    public partial class TrackingServerSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of a listed tracking server.
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
        /// The activity status of a listed tracking server.
        /// </para>
        /// </summary>
        public IsTrackingServerActive IsActive { get; set; }

        /// <summary>
        /// Checks to see if the IsActive property is set.
        /// </summary>
        internal bool IsSetIsActive() => this.IsActive != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time of a listed tracking server.
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
        /// The MLflow version used for a listed tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public string MlflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the MlflowVersion property is set.
        /// </summary>
        internal bool IsSetMlflowVersion() => this.MlflowVersion != null;

        /// <summary>
        /// Gets and sets the property TrackingServerArn. 
        /// <para>
        /// The ARN of a listed tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string TrackingServerArn { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerArn property is set.
        /// </summary>
        internal bool IsSetTrackingServerArn() => this.TrackingServerArn != null;

        /// <summary>
        /// Gets and sets the property TrackingServerName. 
        /// <para>
        /// The name of a listed tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TrackingServerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerName property is set.
        /// </summary>
        internal bool IsSetTrackingServerName() => this.TrackingServerName != null;

        /// <summary>
        /// Gets and sets the property TrackingServerStatus. 
        /// <para>
        /// The creation status of a listed tracking server.
        /// </para>
        /// </summary>
        public TrackingServerStatus TrackingServerStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerStatus property is set.
        /// </summary>
        internal bool IsSetTrackingServerStatus() => this.TrackingServerStatus != null;
    }
}
