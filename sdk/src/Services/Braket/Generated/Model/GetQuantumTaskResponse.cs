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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Braket.Model
{
    /// <summary>
    /// This is the response object from the GetQuantumTask operation.
    /// </summary>
    public partial class GetQuantumTaskResponse : AmazonWebServiceResponse
    {
        private ActionMetadata _actionMetadata;
        private List<Association> _associations = AWSConfigs.InitializeCollections ? new List<Association>() : null;
        private DateTime? _createdAt;
        private string _deviceArn;
        private string _deviceParameters;
        private DateTime? _endedAt;
        private string _failureReason;
        private string _jobArn;
        private long? _numSuccessfulShots;
        private string _outputs3Bucket;
        private string _outputs3Directory;
        private string _quantumTaskArn;
        private QuantumTaskQueueInfo _queueInfo;
        private long? _shots;
        private QuantumTaskStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ActionMetadata. 
        /// <para>
        /// Metadata about the action performed by the quantum task, including information about
        /// the type of action and program counts.
        /// </para>
        /// </summary>
        public ActionMetadata ActionMetadata
        {
            get { return this._actionMetadata; }
            set { this._actionMetadata = value; }
        }

        // Check to see if ActionMetadata property is set
        internal bool IsSetActionMetadata()
        {
            return this._actionMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Associations. 
        /// <para>
        /// The list of Amazon Braket resources associated with the quantum task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Association> Associations
        {
            get { return this._associations; }
            set { this._associations = value; }
        }

        // Check to see if Associations property is set
        internal bool IsSetAssociations()
        {
            return this._associations != null && (this._associations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the quantum task was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
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
        /// The ARN of the device the quantum task was run on.
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
        /// Gets and sets the property DeviceParameters. 
        /// <para>
        /// The parameters for the device on which the quantum task ran.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeviceParameters
        {
            get { return this._deviceParameters; }
            set { this._deviceParameters = value; }
        }

        // Check to see if DeviceParameters property is set
        internal bool IsSetDeviceParameters()
        {
            return this._deviceParameters != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time at which the quantum task ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that a quantum task failed.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN of the Amazon Braket job associated with the quantum task.
        /// </para>
        /// </summary>
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property NumSuccessfulShots. 
        /// <para>
        /// The number of successful shots for the quantum task. This is available after a successfully
        /// completed quantum task.
        /// </para>
        /// </summary>
        public long? NumSuccessfulShots
        {
            get { return this._numSuccessfulShots; }
            set { this._numSuccessfulShots = value; }
        }

        // Check to see if NumSuccessfulShots property is set
        internal bool IsSetNumSuccessfulShots()
        {
            return this._numSuccessfulShots.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputS3Bucket. 
        /// <para>
        /// The S3 bucket where quantum task results are stored.
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
        /// The folder in the S3 bucket where quantum task results are stored.
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
        /// The ARN of the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property QueueInfo. 
        /// <para>
        /// Queue information for the requested quantum task. Only returned if <c>QueueInfo</c>
        /// is specified in the <c>additionalAttributeNames"</c> field in the <c>GetQuantumTask</c>
        /// API request.
        /// </para>
        /// </summary>
        public QuantumTaskQueueInfo QueueInfo
        {
            get { return this._queueInfo; }
            set { this._queueInfo = value; }
        }

        // Check to see if QueueInfo property is set
        internal bool IsSetQueueInfo()
        {
            return this._queueInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Shots. 
        /// <para>
        /// The number of shots used in the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? Shots
        {
            get { return this._shots; }
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
        /// The status of the quantum task.
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
        /// The tags that belong to this quantum task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}