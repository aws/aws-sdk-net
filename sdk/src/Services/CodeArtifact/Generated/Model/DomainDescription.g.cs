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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Information about a domain. A domain is a container for repositories. When you create
    /// a domain, it is empty until you add one or more repositories.
    /// </summary>
    public partial class DomainDescription
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssetSizeBytes. 
        /// <para>
        ///  The total size of all assets in the domain. 
        /// </para>
        /// </summary>
        public long? AssetSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the AssetSizeBytes property is set.
        /// </summary>
        internal bool IsSetAssetSizeBytes() => this.AssetSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        ///  A timestamp that represents the date and time the domain was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        ///  The ARN of an Key Management Service (KMS) key associated with a domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        ///  The Amazon Web Services account ID that owns the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property RepositoryCount. 
        /// <para>
        ///  The number of repositories in the domain. 
        /// </para>
        /// </summary>
        public int? RepositoryCount { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryCount property is set.
        /// </summary>
        internal bool IsSetRepositoryCount() => this.RepositoryCount.HasValue;

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket that is used to store package
        /// assets in the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string S3BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketArn property is set.
        /// </summary>
        internal bool IsSetS3BucketArn() => this.S3BucketArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of a domain. 
        /// </para>
        /// </summary>
        public DomainStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
