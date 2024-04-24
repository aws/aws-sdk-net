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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes an Amazon WorkSpaces client.
    /// </summary>
    public partial class ClientProperties
    {
        private LogUploadEnum _logUploadEnabled;
        private ReconnectEnum _reconnectEnabled;

        /// <summary>
        /// Gets and sets the property LogUploadEnabled. 
        /// <para>
        /// Specifies whether users can upload diagnostic log files of Amazon WorkSpaces client
        /// directly to WorkSpaces to troubleshoot issues when using the WorkSpaces client. When
        /// enabled, the log files will be sent to WorkSpaces automatically and will be applied
        /// to all users in the specified directory.
        /// </para>
        /// </summary>
        public LogUploadEnum LogUploadEnabled
        {
            get { return this._logUploadEnabled; }
            set { this._logUploadEnabled = value; }
        }

        // Check to see if LogUploadEnabled property is set
        internal bool IsSetLogUploadEnabled()
        {
            return this._logUploadEnabled != null;
        }

        /// <summary>
        /// Gets and sets the property ReconnectEnabled. 
        /// <para>
        /// Specifies whether users can cache their credentials on the Amazon WorkSpaces client.
        /// When enabled, users can choose to reconnect to their WorkSpaces without re-entering
        /// their credentials. 
        /// </para>
        /// </summary>
        public ReconnectEnum ReconnectEnabled
        {
            get { return this._reconnectEnabled; }
            set { this._reconnectEnabled = value; }
        }

        // Check to see if ReconnectEnabled property is set
        internal bool IsSetReconnectEnabled()
        {
            return this._reconnectEnabled != null;
        }

    }
}