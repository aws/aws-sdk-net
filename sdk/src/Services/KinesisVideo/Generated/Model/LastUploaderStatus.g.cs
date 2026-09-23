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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The latest status of a stream’s edge to cloud uploader job.
    /// </summary>
    public partial class LastUploaderStatus
    {
        /// <summary>
        /// Gets and sets the property JobStatusDetails. 
        /// <para>
        /// A description of an uploader job’s latest status.
        /// </para>
        /// </summary>
        public string JobStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the JobStatusDetails property is set.
        /// </summary>
        internal bool IsSetJobStatusDetails() => this.JobStatusDetails != null;

        /// <summary>
        /// Gets and sets the property LastCollectedTime. 
        /// <para>
        /// The timestamp at which the uploader job was last executed and media collected to the
        /// cloud.
        /// </para>
        /// </summary>
        public DateTime? LastCollectedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastCollectedTime property is set.
        /// </summary>
        internal bool IsSetLastCollectedTime() => this.LastCollectedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp at which the uploader status was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property UploaderStatus. 
        /// <para>
        /// The status of the latest uploader job.
        /// </para>
        /// </summary>
        public UploaderStatus UploaderStatus { get; set; }

        /// <summary>
        /// Checks to see if the UploaderStatus property is set.
        /// </summary>
        internal bool IsSetUploaderStatus() => this.UploaderStatus != null;
    }
}
