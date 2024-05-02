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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
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
namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// This is the response object from the UpdateConnection operation.
    /// </summary>
    public partial class UpdateConnectionResponse : AmazonWebServiceResponse
    {
        private string _connectionArn;
        private ConnectionState _connectionState;
        private DateTime? _creationTime;
        private DateTime? _lastAuthorizedTime;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The ARN of the connection that was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// The state of the connection that was updated.
        /// </para>
        /// </summary>
        public ConnectionState ConnectionState
        {
            get { return this._connectionState; }
            set { this._connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this._connectionState != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp for the time that the connection was created.
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
        /// Gets and sets the property LastAuthorizedTime. 
        /// <para>
        /// A time stamp for the time that the connection was last authorized.
        /// </para>
        /// </summary>
        public DateTime? LastAuthorizedTime
        {
            get { return this._lastAuthorizedTime; }
            set { this._lastAuthorizedTime = value; }
        }

        // Check to see if LastAuthorizedTime property is set
        internal bool IsSetLastAuthorizedTime()
        {
            return this._lastAuthorizedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A time stamp for the time that the connection was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}