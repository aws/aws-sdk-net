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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataRepositoryAssociation operation. Updates
    /// the configuration of an existing data repository association on an Amazon FSx for
    /// Lustre file system. Data repository associations are supported on all FSx for Lustre
    /// 2.12 and 2.15 file systems, excluding <c>scratch_1</c> deployment type.
    /// </summary>
    public partial class UpdateDataRepositoryAssociationRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the data repository association that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 13, Max = 23)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ImportedFileChunkSize. 
        /// <para>
        /// For files imported from a data repository, this value determines the stripe count
        /// and maximum amount of data per file (in MiB) stored on a single physical disk. The
        /// maximum number of disks that a single file can be striped across is limited by the
        /// total number of disks that make up the file system.
        /// </para>
        ///  
        /// <para>
        /// The default chunk size is 1,024 MiB (1 GiB) and can go as high as 512,000 MiB (500
        /// GiB). Amazon S3 objects have a maximum size of 5 TB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512000)]
        public int? ImportedFileChunkSize { get; set; }

        /// <summary>
        /// Checks to see if the ImportedFileChunkSize property is set.
        /// </summary>
        internal bool IsSetImportedFileChunkSize() => this.ImportedFileChunkSize.HasValue;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The configuration for an Amazon S3 data repository linked to an Amazon FSx Lustre
        /// file system with a data repository association. The configuration defines which file
        /// events (new, changed, or deleted files or directories) are automatically imported
        /// from the linked data repository to the file system or automatically exported from
        /// the file system to the data repository.
        /// </para>
        /// </summary>
        public S3DataRepositoryConfiguration S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;
    }
}
