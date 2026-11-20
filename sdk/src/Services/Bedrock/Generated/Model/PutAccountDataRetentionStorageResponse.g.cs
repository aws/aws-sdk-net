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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the PutAccountDataRetentionStorage operation.
    /// </summary>
    public partial class PutAccountDataRetentionStorageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KmsKeyStatus. 
        /// <para>
        /// Validation state of the KMS key. Present only when storageDestination is customer_managed.
        /// </para>
        /// </summary>
        public DataRetentionStorageResourceStatus KmsKeyStatus { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyStatus property is set.
        /// </summary>
        internal bool IsSetKmsKeyStatus() => this.KmsKeyStatus != null;

        /// <summary>
        /// Gets and sets the property ModelProvider. 
        /// <para>
        /// Model provider this configuration applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataRetentionStorageModelProvider ModelProvider { get; set; }

        /// <summary>
        /// Checks to see if the ModelProvider property is set.
        /// </summary>
        internal bool IsSetModelProvider() => this.ModelProvider != null;

        /// <summary>
        /// Gets and sets the property S3BucketStatus. 
        /// <para>
        /// Validation state of the bucket. Present only when storageDestination is customer_managed.
        /// </para>
        /// </summary>
        public DataRetentionStorageResourceStatus S3BucketStatus { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketStatus property is set.
        /// </summary>
        internal bool IsSetS3BucketStatus() => this.S3BucketStatus != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Scope addressed by the operation that returned this record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataRetentionStorageScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// The stored destination and key. Present only when storageDestination is customer_managed.
        /// </para>
        /// </summary>
        public DataRetentionStorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;

        /// <summary>
        /// Gets and sets the property StorageDestination. 
        /// <para>
        /// Where this record delivers retained data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataRetentionStorageDestination StorageDestination { get; set; }

        /// <summary>
        /// Checks to see if the StorageDestination property is set.
        /// </summary>
        internal bool IsSetStorageDestination() => this.StorageDestination != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Time the stored record last changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
