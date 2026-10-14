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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// An archive resource for storing and retaining emails.
    /// </summary>
    public partial class Archive
    {
        /// <summary>
        /// Gets and sets the property ArchiveId. 
        /// <para>
        /// The unique identifier of the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 66)]
        public string ArchiveId { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveId property is set.
        /// </summary>
        internal bool IsSetArchiveId() => this.ArchiveId != null;

        /// <summary>
        /// Gets and sets the property ArchiveName. 
        /// <para>
        /// The unique name assigned to the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ArchiveName { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveName property is set.
        /// </summary>
        internal bool IsSetArchiveName() => this.ArchiveName != null;

        /// <summary>
        /// Gets and sets the property ArchiveState. 
        /// <para>
        /// The current state of the archive:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> – The archive is ready and available for use. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_DELETION</c> – The archive has been marked for deletion and will be permanently
        /// deleted in 30 days. No further modifications can be made in this state. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ArchiveState ArchiveState { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveState property is set.
        /// </summary>
        internal bool IsSetArchiveState() => this.ArchiveState != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The timestamp of when the archive was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;
    }
}
