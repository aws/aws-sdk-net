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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The latest status of a stream’s edge to cloud uploader job.
    /// </summary>
    public partial class LastUploaderStatus
    {
        private string _jobStatusDetails;
        private DateTime? _lastCollectedTime;
        private DateTime? _lastUpdatedTime;
        private UploaderStatus _uploaderStatus;

        /// <summary>
        /// Gets and sets the property JobStatusDetails. 
        /// <para>
        /// A description of an uploader job’s latest status.
        /// </para>
        /// </summary>
        public string JobStatusDetails
        {
            get { return this._jobStatusDetails; }
            set { this._jobStatusDetails = value; }
        }

        // Check to see if JobStatusDetails property is set
        internal bool IsSetJobStatusDetails()
        {
            return this._jobStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LastCollectedTime. 
        /// <para>
        /// The timestamp at which the uploader job was last executed and media collected to the
        /// cloud.
        /// </para>
        /// </summary>
        public DateTime? LastCollectedTime
        {
            get { return this._lastCollectedTime; }
            set { this._lastCollectedTime = value; }
        }

        // Check to see if LastCollectedTime property is set
        internal bool IsSetLastCollectedTime()
        {
            return this._lastCollectedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp at which the uploader status was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploaderStatus. 
        /// <para>
        /// The status of the latest uploader job.
        /// </para>
        /// </summary>
        public UploaderStatus UploaderStatus
        {
            get { return this._uploaderStatus; }
            set { this._uploaderStatus = value; }
        }

        // Check to see if UploaderStatus property is set
        internal bool IsSetUploaderStatus()
        {
            return this._uploaderStatus != null;
        }

    }
}