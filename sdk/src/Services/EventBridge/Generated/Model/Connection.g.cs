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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Contains information about a connection.
    /// </summary>
    public partial class Connection
    {
        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// The authorization type specified for the connection.
        /// </para>
        ///  <note> 
        /// <para>
        /// OAUTH tokens are refreshed when a 401 or 407 response is returned.
        /// </para>
        ///  </note>
        /// </summary>
        public ConnectionAuthorizationType AuthorizationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationType property is set.
        /// </summary>
        internal bool IsSetAuthorizationType() => this.AuthorizationType != null;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The ARN of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string ConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionArn property is set.
        /// </summary>
        internal bool IsSetConnectionArn() => this.ConnectionArn != null;

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// The state of the connection.
        /// </para>
        /// </summary>
        public ConnectionState ConnectionState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionState property is set.
        /// </summary>
        internal bool IsSetConnectionState() => this.ConnectionState != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp for the time that the connection was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastAuthorizedTime. 
        /// <para>
        /// A time stamp for the time that the connection was last authorized.
        /// </para>
        /// </summary>
        public DateTime? LastAuthorizedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAuthorizedTime property is set.
        /// </summary>
        internal bool IsSetLastAuthorizedTime() => this.LastAuthorizedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A time stamp for the time that the connection was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason that the connection is in the connection state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;
    }
}
