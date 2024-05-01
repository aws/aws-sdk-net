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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Staging information related to source server.
    /// </summary>
    public partial class StagingArea
    {
        private string _errorMessage;
        private string _stagingAccountID;
        private string _stagingSourceServerArn;
        private ExtensionStatus _status;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Shows an error message that occurred when DRS tried to access the staging source server.
        /// In this case StagingArea$status will have value EXTENSION_ERROR
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
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
        /// Gets and sets the property StagingAccountID. 
        /// <para>
        /// Account ID of the account to which source server belongs. If this source server is
        /// extended - shows Account ID of staging source server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string StagingAccountID
        {
            get { return this._stagingAccountID; }
            set { this._stagingAccountID = value; }
        }

        // Check to see if StagingAccountID property is set
        internal bool IsSetStagingAccountID()
        {
            return this._stagingAccountID != null;
        }

        /// <summary>
        /// Gets and sets the property StagingSourceServerArn. 
        /// <para>
        /// Arn of the staging source server if this source server is extended
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string StagingSourceServerArn
        {
            get { return this._stagingSourceServerArn; }
            set { this._stagingSourceServerArn = value; }
        }

        // Check to see if StagingSourceServerArn property is set
        internal bool IsSetStagingSourceServerArn()
        {
            return this._stagingSourceServerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of Source server extension. Possible values: (a) NOT_EXTENDED - This is a source
        /// server that is replicating in the current account. (b) EXTENDED - Source server is
        /// extended from a staging source server. In this case, the value of stagingSourceServerArn
        /// is pointing to the Arn of the source server in the staging account. (c) EXTENSION_ERROR
        /// - Some issue occurred when accessing staging source server. In this case, errorMessage
        /// field will contain an error message that explains what happened.
        /// </para>
        /// </summary>
        public ExtensionStatus Status
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