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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the PutRestoreValidationResult operation.
    /// This request allows you to send your independent self-run restore test validation
    /// results. <c>RestoreJobId</c> and <c>ValidationStatus</c> are required. Optionally,
    /// you can input a <c>ValidationStatusMessage</c>.
    /// </summary>
    public partial class PutRestoreValidationResultRequest : AmazonBackupRequest
    {
        private string _restoreJobId;
        private RestoreValidationStatus _validationStatus;
        private string _validationStatusMessage;

        /// <summary>
        /// Gets and sets the property RestoreJobId. 
        /// <para>
        /// This is a unique identifier of a restore job within Backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestoreJobId
        {
            get { return this._restoreJobId; }
            set { this._restoreJobId = value; }
        }

        // Check to see if RestoreJobId property is set
        internal bool IsSetRestoreJobId()
        {
            return this._restoreJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The status of your restore validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RestoreValidationStatus ValidationStatus
        {
            get { return this._validationStatus; }
            set { this._validationStatus = value; }
        }

        // Check to see if ValidationStatus property is set
        internal bool IsSetValidationStatus()
        {
            return this._validationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStatusMessage. 
        /// <para>
        /// This is an optional message string you can input to describe the validation status
        /// for the restore test validation.
        /// </para>
        /// </summary>
        public string ValidationStatusMessage
        {
            get { return this._validationStatusMessage; }
            set { this._validationStatusMessage = value; }
        }

        // Check to see if ValidationStatusMessage property is set
        internal bool IsSetValidationStatusMessage()
        {
            return this._validationStatusMessage != null;
        }

    }
}