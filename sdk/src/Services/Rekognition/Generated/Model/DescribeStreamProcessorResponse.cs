/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the DescribeStreamProcessor operation.
    /// </summary>
    public partial class DescribeStreamProcessorResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTimestamp;
        private StreamProcessorInput _input;
        private DateTime? _lastUpdateTimestamp;
        private string _name;
        private StreamProcessorOutput _output;
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
        public DateTime CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
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
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The time, in Unix format, the stream processor was last updated. For example, when
        /// the stream processor moves from a running state to a failed state, or when the user
        /// starts or stops the stream processor.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp.GetValueOrDefault(); }
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
        /// Gets and sets the property Output. 
        /// <para>
        /// Kinesis data stream to which Rekognition Video puts the analysis results.
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
        /// Face recognition input parameters that are being used by the stream processor. Includes
        /// the collection to use for face recognition and the face attributes to detect.
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