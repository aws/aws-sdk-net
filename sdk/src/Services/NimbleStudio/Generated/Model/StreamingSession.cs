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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class StreamingSession
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _ec2InstanceType;
        private string _launchProfileId;
        private string _sessionId;
        private StreamingSessionState _state;
        private StreamingSessionStatusCode _statusCode;
        private string _statusMessage;
        private string _streamingImageId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _terminateAt;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the resource.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the resource was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user ID of the user that created the streaming session.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceType. 
        /// <para>
        /// The EC2 Instance type used for the streaming session.
        /// </para>
        /// </summary>
        public string Ec2InstanceType
        {
            get { return this._ec2InstanceType; }
            set { this._ec2InstanceType = value; }
        }

        // Check to see if Ec2InstanceType property is set
        internal bool IsSetEc2InstanceType()
        {
            return this._ec2InstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchProfileId. 
        /// <para>
        /// The ID of the launch profile used to control access from the streaming session.
        /// </para>
        /// </summary>
        public string LaunchProfileId
        {
            get { return this._launchProfileId; }
            set { this._launchProfileId = value; }
        }

        // Check to see if LaunchProfileId property is set
        internal bool IsSetLaunchProfileId()
        {
            return this._launchProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID.
        /// </para>
        /// </summary>
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state.
        /// </para>
        /// </summary>
        public StreamingSessionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code.
        /// </para>
        /// </summary>
        public StreamingSessionStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for the streaming session.
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
        /// Gets and sets the property StreamingImageId. 
        /// <para>
        /// The ID of the streaming image.
        /// </para>
        /// </summary>
        [AWSProperty(Max=22)]
        public string StreamingImageId
        {
            get { return this._streamingImageId; }
            set { this._streamingImageId = value; }
        }

        // Check to see if StreamingImageId property is set
        internal bool IsSetStreamingImageId()
        {
            return this._streamingImageId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of labels, in the form of key:value pairs, that apply to this resource.
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

        /// <summary>
        /// Gets and sets the property TerminateAt. 
        /// <para>
        /// The time the streaming session will automatically terminate if not terminated by the
        /// user.
        /// </para>
        /// </summary>
        public DateTime TerminateAt
        {
            get { return this._terminateAt.GetValueOrDefault(); }
            set { this._terminateAt = value; }
        }

        // Check to see if TerminateAt property is set
        internal bool IsSetTerminateAt()
        {
            return this._terminateAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the resource was updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user ID of the user that most recently updated the resource.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}