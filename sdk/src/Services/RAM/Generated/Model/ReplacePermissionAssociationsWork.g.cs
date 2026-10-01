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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// A structure that represents the background work that RAM performs when you invoke
    /// the <a>ReplacePermissionAssociations</a> operation.
    /// </summary>
    public partial class ReplacePermissionAssociationsWork
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time when this asynchronous background task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FromPermissionArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the managed permission that this background task is replacing.
        /// </para>
        /// </summary>
        public string FromPermissionArn { get; set; }

        /// <summary>
        /// Checks to see if the FromPermissionArn property is set.
        /// </summary>
        internal bool IsSetFromPermissionArn() => this.FromPermissionArn != null;

        /// <summary>
        /// Gets and sets the property FromPermissionVersion. 
        /// <para>
        /// The version of the managed permission that this background task is replacing.
        /// </para>
        /// </summary>
        public string FromPermissionVersion { get; set; }

        /// <summary>
        /// Checks to see if the FromPermissionVersion property is set.
        /// </summary>
        internal bool IsSetFromPermissionVersion() => this.FromPermissionVersion != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the background task associated with one <a>ReplacePermissionAssociations</a>
        /// request.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time when the status of this background task was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

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
        public ReplacePermissionAssociationsWorkStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Specifies the reason for a <c>FAILED</c> status. This field is present only when there
        /// <c>status</c> is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property ToPermissionArn. 
        /// <para>
        /// The ARN of the managed permission that this background task is associating with the
        /// resource shares in place of the managed permission and version specified in <c>fromPermissionArn</c>
        /// and <c>fromPermissionVersion</c>.
        /// </para>
        /// </summary>
        public string ToPermissionArn { get; set; }

        /// <summary>
        /// Checks to see if the ToPermissionArn property is set.
        /// </summary>
        internal bool IsSetToPermissionArn() => this.ToPermissionArn != null;

        /// <summary>
        /// Gets and sets the property ToPermissionVersion. 
        /// <para>
        /// The version of the managed permission that this background task is associating with
        /// the resource shares. This is always the version that is currently the default for
        /// this managed permission.
        /// </para>
        /// </summary>
        public string ToPermissionVersion { get; set; }

        /// <summary>
        /// Checks to see if the ToPermissionVersion property is set.
        /// </summary>
        internal bool IsSetToPermissionVersion() => this.ToPermissionVersion != null;
    }
}
