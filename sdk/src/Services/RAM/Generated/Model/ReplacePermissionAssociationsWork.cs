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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// A structure that represents the background work that RAM performs when you invoke
    /// the <a>ReplacePermissionAssociations</a> operation.
    /// </summary>
    public partial class ReplacePermissionAssociationsWork
    {
        private DateTime? _creationTime;
        private string _fromPermissionArn;
        private string _fromPermissionVersion;
        private string _id;
        private DateTime? _lastUpdatedTime;
        private ReplacePermissionAssociationsWorkStatus _status;
        private string _statusMessage;
        private string _toPermissionArn;
        private string _toPermissionVersion;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time when this asynchronous background task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FromPermissionArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the managed permission that this background task is replacing.
        /// </para>
        /// </summary>
        public string FromPermissionArn
        {
            get { return this._fromPermissionArn; }
            set { this._fromPermissionArn = value; }
        }

        // Check to see if FromPermissionArn property is set
        internal bool IsSetFromPermissionArn()
        {
            return this._fromPermissionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FromPermissionVersion. 
        /// <para>
        /// The version of the managed permission that this background task is replacing.
        /// </para>
        /// </summary>
        public string FromPermissionVersion
        {
            get { return this._fromPermissionVersion; }
            set { this._fromPermissionVersion = value; }
        }

        // Check to see if FromPermissionVersion property is set
        internal bool IsSetFromPermissionVersion()
        {
            return this._fromPermissionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the background task associated with one <a>ReplacePermissionAssociations</a>
        /// request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time when the status of this background task was last updated.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the current status of the background tasks for the specified ID. The output
        /// is one of the following strings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReplacePermissionAssociationsWorkStatus Status
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
        /// Specifies the reason for a <c>FAILED</c> status. This field is present only when there
        /// <c>status</c> is <c>FAILED</c>.
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
        /// Gets and sets the property ToPermissionArn. 
        /// <para>
        /// The ARN of the managed permission that this background task is associating with the
        /// resource shares in place of the managed permission and version specified in <c>fromPermissionArn</c>
        /// and <c>fromPermissionVersion</c>.
        /// </para>
        /// </summary>
        public string ToPermissionArn
        {
            get { return this._toPermissionArn; }
            set { this._toPermissionArn = value; }
        }

        // Check to see if ToPermissionArn property is set
        internal bool IsSetToPermissionArn()
        {
            return this._toPermissionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ToPermissionVersion. 
        /// <para>
        /// The version of the managed permission that this background task is associating with
        /// the resource shares. This is always the version that is currently the default for
        /// this managed permission.
        /// </para>
        /// </summary>
        public string ToPermissionVersion
        {
            get { return this._toPermissionVersion; }
            set { this._toPermissionVersion = value; }
        }

        // Check to see if ToPermissionVersion property is set
        internal bool IsSetToPermissionVersion()
        {
            return this._toPermissionVersion != null;
        }

    }
}