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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Includes information about a quantum task.
    /// </summary>
    public partial class QuantumTaskSummary
    {
        private DateTime? _createdAt;
        private string _deviceArn;
        private DateTime? _endedAt;
        private string _outputs3Bucket;
        private string _outputs3Directory;
        private string _quantumTaskArn;
        private long? _shots;
        private QuantumTaskStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the task was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device the task ran on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time at which the task finished.
        /// </para>
        /// </summary>
        public DateTime EndedAt
        {
            get { return this._endedAt.GetValueOrDefault(); }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputS3Bucket. 
        /// <para>
        /// The S3 bucket where the task result file is stored..
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputS3Bucket
        {
            get { return this._outputs3Bucket; }
            set { this._outputs3Bucket = value; }
        }

        // Check to see if OutputS3Bucket property is set
        internal bool IsSetOutputS3Bucket()
        {
            return this._outputs3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3Directory. 
        /// <para>
        /// The folder in the S3 bucket where the task result file is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputS3Directory
        {
            get { return this._outputs3Directory; }
            set { this._outputs3Directory = value; }
        }

        // Check to see if OutputS3Directory property is set
        internal bool IsSetOutputS3Directory()
        {
            return this._outputs3Directory != null;
        }

        /// <summary>
        /// Gets and sets the property QuantumTaskArn. 
        /// <para>
        /// The ARN of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string QuantumTaskArn
        {
            get { return this._quantumTaskArn; }
            set { this._quantumTaskArn = value; }
        }

        // Check to see if QuantumTaskArn property is set
        internal bool IsSetQuantumTaskArn()
        {
            return this._quantumTaskArn != null;
        }

        /// <summary>
        /// Gets and sets the property Shots. 
        /// <para>
        /// The shots used for the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long Shots
        {
            get { return this._shots.GetValueOrDefault(); }
            set { this._shots = value; }
        }

        // Check to see if Shots property is set
        internal bool IsSetShots()
        {
            return this._shots.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuantumTaskStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Displays the key, value pairs of tags associated with this quantum task.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}