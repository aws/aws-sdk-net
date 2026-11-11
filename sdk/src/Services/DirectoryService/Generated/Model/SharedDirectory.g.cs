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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Details about the shared directory in the directory owner account for which the share
    /// request in the directory consumer account has been accepted.
    /// </summary>
    public partial class SharedDirectory
    {
        /// <summary>
        /// Gets and sets the property CreatedDateTime. 
        /// <para>
        /// The date and time that the shared directory was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDateTime property is set.
        /// </summary>
        internal bool IsSetCreatedDateTime() => this.CreatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the shared directory was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// Identifier of the directory owner account, which contains the directory that has been
        /// shared to the consumer account.
        /// </para>
        /// </summary>
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property OwnerDirectoryId. 
        /// <para>
        /// Identifier of the directory in the directory owner account. 
        /// </para>
        /// </summary>
        public string OwnerDirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerDirectoryId property is set.
        /// </summary>
        internal bool IsSetOwnerDirectoryId() => this.OwnerDirectoryId != null;

        /// <summary>
        /// Gets and sets the property ShareMethod. 
        /// <para>
        /// The method used when sharing a directory to determine whether the directory should
        /// be shared within your Amazon Web Services organization (<c>ORGANIZATIONS</c>) or with
        /// any Amazon Web Services account by sending a shared directory request (<c>HANDSHAKE</c>).
        /// </para>
        /// </summary>
        public ShareMethod ShareMethod { get; set; }

        /// <summary>
        /// Checks to see if the ShareMethod property is set.
        /// </summary>
        internal bool IsSetShareMethod() => this.ShareMethod != null;

        /// <summary>
        /// Gets and sets the property ShareNotes. 
        /// <para>
        /// A directory share request that is sent by the directory owner to the directory consumer.
        /// The request includes a typed message to help the directory consumer administrator
        /// determine whether to approve or reject the share invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string ShareNotes { get; set; }

        /// <summary>
        /// Checks to see if the ShareNotes property is set.
        /// </summary>
        internal bool IsSetShareNotes() => this.ShareNotes != null;

        /// <summary>
        /// Gets and sets the property ShareStatus. 
        /// <para>
        /// Current directory status of the shared Managed Microsoft AD directory.
        /// </para>
        /// </summary>
        public ShareStatus ShareStatus { get; set; }

        /// <summary>
        /// Checks to see if the ShareStatus property is set.
        /// </summary>
        internal bool IsSetShareStatus() => this.ShareStatus != null;

        /// <summary>
        /// Gets and sets the property SharedAccountId. 
        /// <para>
        /// Identifier of the directory consumer account that has access to the shared directory
        /// (<c>OwnerDirectoryId</c>) in the directory owner account.
        /// </para>
        /// </summary>
        public string SharedAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SharedAccountId property is set.
        /// </summary>
        internal bool IsSetSharedAccountId() => this.SharedAccountId != null;

        /// <summary>
        /// Gets and sets the property SharedDirectoryId. 
        /// <para>
        /// Identifier of the shared directory in the directory consumer account. This identifier
        /// is different for each directory owner account.
        /// </para>
        /// </summary>
        public string SharedDirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the SharedDirectoryId property is set.
        /// </summary>
        internal bool IsSetSharedDirectoryId() => this.SharedDirectoryId != null;
    }
}
