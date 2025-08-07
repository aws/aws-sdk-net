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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// This is the response object from the UpdateApplication operation.
    /// </summary>
    public partial class UpdateApplicationResponse : AmazonWebServiceResponse
    {
        private string _applicationLogOutputUri;
        private List<string> _applicationLogPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _applicationSourceUri;
        private string _arn;
        private List<string> _associatedStreamGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private string _description;
        private string _executablePath;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private List<ReplicationStatus> _replicationStatuses = AWSConfigs.InitializeCollections ? new List<ReplicationStatus>() : null;
        private RuntimeEnvironment _runtimeEnvironment;
        private ApplicationStatus _status;
        private ApplicationStatusReason _statusReason;

        /// <summary>
        /// Gets and sets the property ApplicationLogOutputUri. 
        /// <para>
        /// An Amazon S3 URI to a bucket where you would like Amazon GameLift Streams to save
        /// application logs. Required if you specify one or more <c>ApplicationLogPaths</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ApplicationLogOutputUri
        {
            get { return this._applicationLogOutputUri; }
            set { this._applicationLogOutputUri = value; }
        }

        // Check to see if ApplicationLogOutputUri property is set
        internal bool IsSetApplicationLogOutputUri()
        {
            return this._applicationLogOutputUri != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationLogPaths. 
        /// <para>
        /// Locations of log files that your content generates during a stream session. Amazon
        /// GameLift Streams uploads log files to the Amazon S3 bucket that you specify in <c>ApplicationLogOutputUri</c>
        /// at the end of a stream session. To retrieve stored log files, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>
        /// and get the <c>LogFileLocationUri</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> ApplicationLogPaths
        {
            get { return this._applicationLogPaths; }
            set { this._applicationLogPaths = value; }
        }

        // Check to see if ApplicationLogPaths property is set
        internal bool IsSetApplicationLogPaths()
        {
            return this._applicationLogPaths != null && (this._applicationLogPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApplicationSourceUri. 
        /// <para>
        /// The original Amazon S3 location of uploaded stream content for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ApplicationSourceUri
        {
            get { return this._applicationSourceUri; }
            set { this._applicationSourceUri = value; }
        }

        // Check to see if ApplicationSourceUri property is set
        internal bool IsSetApplicationSourceUri()
        {
            return this._applicationSourceUri != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that's assigned to an application resource and uniquely identifies
        /// it across all Amazon Web Services Regions. Format is <c>arn:aws:gameliftstreams:[AWS
        /// Region]:[AWS account]:application/[resource ID]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property AssociatedStreamGroups. 
        /// <para>
        ///  A set of stream groups that this application is associated with. You can use any
        /// of these stream groups to stream your application. 
        /// </para>
        ///  
        /// <para>
        /// This value is a set of <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Names (ARNs)</a> that uniquely identify stream group resources. Example ARN:
        /// <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedStreamGroups
        {
            get { return this._associatedStreamGroups; }
            set { this._associatedStreamGroups = value; }
        }

        // Check to see if AssociatedStreamGroups property is set
        internal bool IsSetAssociatedStreamGroups()
        {
            return this._associatedStreamGroups != null && (this._associatedStreamGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was created. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable label for the application. You can edit this value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutablePath. 
        /// <para>
        /// The path and file name of the executable file that launches the content for streaming.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ExecutablePath
        {
            get { return this._executablePath; }
            set { this._executablePath = value; }
        }

        // Check to see if ExecutablePath property is set
        internal bool IsSetExecutablePath()
        {
            return this._executablePath != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique ID value that is assigned to the resource when it's created. Format example:
        /// <c>a-9ZY8X7Wv6</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was last updated. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatuses. 
        /// <para>
        /// A set of replication statuses for each location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicationStatus> ReplicationStatuses
        {
            get { return this._replicationStatuses; }
            set { this._replicationStatuses = value; }
        }

        // Check to see if ReplicationStatuses property is set
        internal bool IsSetReplicationStatuses()
        {
            return this._replicationStatuses != null && (this._replicationStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuntimeEnvironment. 
        /// <para>
        ///  Configuration settings that identify the operating system for an application resource.
        /// This can also include a compatibility layer and other drivers. 
        /// </para>
        ///  
        /// <para>
        /// A runtime environment can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For Linux applications 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Ubuntu 22.04 LTS (<c>Type=UBUNTU, Version=22_04_LTS</c>) 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  For Windows applications 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Microsoft Windows Server 2022 Base (<c>Type=WINDOWS, Version=2022</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 9.0-2 (<c>Type=PROTON, Version=20250516</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 8.0-5 (<c>Type=PROTON, Version=20241007</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 8.0-2c (<c>Type=PROTON, Version=20230704</c>)
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public RuntimeEnvironment RuntimeEnvironment
        {
            get { return this._runtimeEnvironment; }
            set { this._runtimeEnvironment = value; }
        }

        // Check to see if RuntimeEnvironment property is set
        internal bool IsSetRuntimeEnvironment()
        {
            return this._runtimeEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the application resource. Possible statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INITIALIZED</c>: Amazon GameLift Streams has received the request and is initiating
        /// the work flow to create an application. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROCESSING</c>: The create application work flow is in process. Amazon GameLift
        /// Streams is copying the content and caching for future deployment in a stream group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c>: The application is ready to deploy in a stream group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: An error occurred when setting up the application. See <c>StatusReason</c>
        /// for more information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: Amazon GameLift Streams is in the process of deleting the application.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApplicationStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short description of the status reason when the application is in <c>ERROR</c> status.
        /// </para>
        /// </summary>
        public ApplicationStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}