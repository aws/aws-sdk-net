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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the DescribeStreamProcessor operation.
    /// </summary>
    public partial class DescribeStreamProcessorResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTimestamp;
        private StreamProcessorDataSharingPreference _dataSharingPreference;
        private StreamProcessorInput _input;
        private string _kmsKeyId;
        private DateTime? _lastUpdateTimestamp;
        private string _name;
        private StreamProcessorNotificationChannel _notificationChannel;
        private StreamProcessorOutput _output;
        private List<RegionOfInterest> _regionsOfInterest = AWSConfigs.InitializeCollections ? new List<RegionOfInterest>() : null;
        private string _roleArn;
        private StreamProcessorSettings _settings;
        private StreamProcessorStatus _status;
        private string _statusMessage;
        private string _streamProcessorArn;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// Date and time the stream processor was created
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSharingPreference. 
        /// <para>
        ///  Shows whether you are sharing data with Rekognition to improve model performance.
        /// You can choose this option at the account level or on a per-stream basis. Note that
        /// if you opt out at the account level this setting is ignored on individual streams.
        /// 
        /// </para>
        /// </summary>
        public StreamProcessorDataSharingPreference DataSharingPreference
        {
            get { return this._dataSharingPreference; }
            set { this._dataSharingPreference = value; }
        }

        // Check to see if DataSharingPreference property is set
        internal bool IsSetDataSharingPreference()
        {
            return this._dataSharingPreference != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Kinesis video stream that provides the source streaming video.
        /// </para>
        /// </summary>
        public StreamProcessorInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The identifier for your AWS Key Management Service key (AWS KMS key). This is an
        /// optional parameter for label detection stream processors. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The time, in Unix format, the stream processor was last updated. For example, when
        /// the stream processor moves from a running state to a failed state, or when the user
        /// starts or stops the stream processor.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp; }
            set { this._lastUpdateTimestamp = value; }
        }

        // Check to see if LastUpdateTimestamp property is set
        internal bool IsSetLastUpdateTimestamp()
        {
            return this._lastUpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the stream processor. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationChannel.
        /// </summary>
        public StreamProcessorNotificationChannel NotificationChannel
        {
            get { return this._notificationChannel; }
            set { this._notificationChannel = value; }
        }

        // Check to see if NotificationChannel property is set
        internal bool IsSetNotificationChannel()
        {
            return this._notificationChannel != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// Kinesis data stream to which Amazon Rekognition Video puts the analysis results.
        /// </para>
        /// </summary>
        public StreamProcessorOutput Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property RegionsOfInterest. 
        /// <para>
        ///  Specifies locations in the frames where Amazon Rekognition checks for objects or
        /// people. This is an optional parameter for label detection stream processors. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RegionOfInterest> RegionsOfInterest
        {
            get { return this._regionsOfInterest; }
            set { this._regionsOfInterest = value; }
        }

        // Check to see if RegionsOfInterest property is set
        internal bool IsSetRegionsOfInterest()
        {
            return this._regionsOfInterest != null && (this._regionsOfInterest.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// ARN of the IAM role that allows access to the stream processor.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// Input parameters used in a streaming video analyzed by a stream processor. You can
        /// use <c>FaceSearch</c> to recognize faces in a streaming video, or you can use <c>ConnectedHome</c>
        /// to detect labels.
        /// </para>
        /// </summary>
        public StreamProcessorSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the stream processor.
        /// </para>
        /// </summary>
        public StreamProcessorStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Detailed status message about the stream processor.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StreamProcessorArn. 
        /// <para>
        /// ARN of the stream processor.
        /// </para>
        /// </summary>
        public string StreamProcessorArn
        {
            get { return this._streamProcessorArn; }
            set { this._streamProcessorArn = value; }
        }

        // Check to see if StreamProcessorArn property is set
        internal bool IsSetStreamProcessorArn()
        {
            return this._streamProcessorArn != null;
        }

    }
}