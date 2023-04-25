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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the DescribeDiscoveryJob operation.
    /// </summary>
    public partial class DescribeDiscoveryJobResponse : AmazonWebServiceResponse
    {
        private int? _collectionDurationMinutes;
        private string _discoveryJobArn;
        private DateTime? _jobEndTime;
        private DateTime? _jobStartTime;
        private DiscoveryJobStatus _status;
        private string _storageSystemArn;

        /// <summary>
        /// Gets and sets the property CollectionDurationMinutes. 
        /// <para>
        /// The number of minutes that the discovery job runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=44640)]
        public int CollectionDurationMinutes
        {
            get { return this._collectionDurationMinutes.GetValueOrDefault(); }
            set { this._collectionDurationMinutes = value; }
        }

        // Check to see if CollectionDurationMinutes property is set
        internal bool IsSetCollectionDurationMinutes()
        {
            return this._collectionDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DiscoveryJobArn. 
        /// <para>
        /// The ARN of the discovery job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DiscoveryJobArn
        {
            get { return this._discoveryJobArn; }
            set { this._discoveryJobArn = value; }
        }

        // Check to see if DiscoveryJobArn property is set
        internal bool IsSetDiscoveryJobArn()
        {
            return this._discoveryJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobEndTime. 
        /// <para>
        /// The time when the discovery job ended.
        /// </para>
        /// </summary>
        public DateTime JobEndTime
        {
            get { return this._jobEndTime.GetValueOrDefault(); }
            set { this._jobEndTime = value; }
        }

        // Check to see if JobEndTime property is set
        internal bool IsSetJobEndTime()
        {
            return this._jobEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobStartTime. 
        /// <para>
        /// The time when the discovery job started.
        /// </para>
        /// </summary>
        public DateTime JobStartTime
        {
            get { return this._jobStartTime.GetValueOrDefault(); }
            set { this._jobStartTime = value; }
        }

        // Check to see if JobStartTime property is set
        internal bool IsSetJobStartTime()
        {
            return this._jobStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of a discovery job. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-job-statuses.html#discovery-job-statuses-table">Discovery
        /// job statuses</a>.
        /// </para>
        /// </summary>
        public DiscoveryJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StorageSystemArn. 
        /// <para>
        /// The ARN of the on-premises storage system you're running the discovery job on.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string StorageSystemArn
        {
            get { return this._storageSystemArn; }
            set { this._storageSystemArn = value; }
        }

        // Check to see if StorageSystemArn property is set
        internal bool IsSetStorageSystemArn()
        {
            return this._storageSystemArn != null;
        }

    }
}