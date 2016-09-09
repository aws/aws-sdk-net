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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Contains information about a WorkSpace that could not be created.
    /// </summary>
    public partial class FailedCreateWorkspaceRequest
    {
        private string _errorCode;
        private string _errorMessage;
        private WorkspaceRequest _workspaceRequest;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The textual error message.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceRequest. 
        /// <para>
        /// A <a>FailedCreateWorkspaceRequest$WorkspaceRequest</a> object that contains the information
        /// about the WorkSpace that could not be created.
        /// </para>
        /// </summary>
        public WorkspaceRequest WorkspaceRequest
        {
            get { return this._workspaceRequest; }
            set { this._workspaceRequest = value; }
        }

        // Check to see if WorkspaceRequest property is set
        internal bool IsSetWorkspaceRequest()
        {
            return this._workspaceRequest != null;
        }

    }
}