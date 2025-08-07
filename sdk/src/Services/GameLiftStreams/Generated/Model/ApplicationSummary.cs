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
    /// Describes an application resource that represents a collection of content for streaming
    /// with Amazon GameLift Streams. To retrieve additional application details, call <a
    /// href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetApplication.html">GetApplication</a>.
    /// </summary>
    public partial class ApplicationSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private RuntimeEnvironment _runtimeEnvironment;
        private ApplicationStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that's assigned to an application resource and uniquely
        /// identifies the application across all Amazon Web Services Regions. Format is <c>arn:aws:gameliftstreams:[AWS
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
        /// Gets and sets the property Id. 
        /// <para>
        /// An ID that uniquely identifies the application resource. Example ID: <c>a-9ZY8X7Wv6</c>.
        /// 
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

    }
}