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
    /// Container for the parameters to the ShareDirectory operation. Shares a specified directory
    /// (<c>DirectoryId</c>) in your Amazon Web Services account (directory owner) with another
    /// Amazon Web Services account (directory consumer). With this operation you can use
    /// your directory from any Amazon Web Services account and from any Amazon VPC within
    /// an Amazon Web Services Region. <para> When you share your Managed Microsoft AD directory,
    /// Directory Service creates a shared directory in the directory consumer account. This
    /// shared directory contains the metadata to provide access to the directory within the
    /// directory owner account. The shared directory is visible in all VPCs in the directory
    /// consumer account. </para> <para> The <c>ShareMethod</c> parameter determines whether
    /// the specified directory can be shared between Amazon Web Services accounts inside
    /// the same Amazon Web Services organization (<c>ORGANIZATIONS</c>). It also determines
    /// whether you can share the directory with any other Amazon Web Services account either
    /// inside or outside of the organization (<c>HANDSHAKE</c>). </para> <para> The <c>ShareNotes</c>
    /// parameter is only used when <c>HANDSHAKE</c> is called, which sends a directory sharing
    /// request to the directory consumer. </para>
    /// </summary>
    public partial class ShareDirectoryRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier of the Managed Microsoft AD directory that you want to share with other
        /// Amazon Web Services accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property ShareMethod. 
        /// <para>
        /// The method used when sharing a directory to determine whether the directory should
        /// be shared within your Amazon Web Services organization (<c>ORGANIZATIONS</c>) or with
        /// any Amazon Web Services account by sending a directory sharing request (<c>HANDSHAKE</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property ShareTarget. 
        /// <para>
        /// Identifier for the directory consumer account with whom the directory is to be shared.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ShareTarget ShareTarget { get; set; }

        /// <summary>
        /// Checks to see if the ShareTarget property is set.
        /// </summary>
        internal bool IsSetShareTarget() => this.ShareTarget != null;
    }
}
