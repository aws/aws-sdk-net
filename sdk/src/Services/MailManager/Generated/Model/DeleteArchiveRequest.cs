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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteArchive operation.
    /// Initiates deletion of an email archive. This changes the archive state to pending
    /// deletion. In this state, no new emails can be added, and existing archived emails
    /// become inaccessible (search, export, download). The archive and all of its contents
    /// will be permanently deleted 30 days after entering the pending deletion state, regardless
    /// of the configured retention period.
    /// </summary>
    public partial class DeleteArchiveRequest : AmazonMailManagerRequest
    {
        private string _archiveId;

        /// <summary>
        /// Gets and sets the property ArchiveId. 
        /// <para>
        /// The identifier of the archive to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=66)]
        public string ArchiveId
        {
            get { return this._archiveId; }
            set { this._archiveId = value; }
        }

        // Check to see if ArchiveId property is set
        internal bool IsSetArchiveId()
        {
            return this._archiveId != null;
        }

    }
}