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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies an encryption configuration.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property CloudWatchEncryption. 
        /// <para>
        /// The encryption configuration for Amazon CloudWatch.
        /// </para>
        /// </summary>
        public CloudWatchEncryption CloudWatchEncryption { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchEncryption property is set.
        /// </summary>
        internal bool IsSetCloudWatchEncryption() => this.CloudWatchEncryption != null;

        /// <summary>
        /// Gets and sets the property DataQualityEncryption. 
        /// <para>
        /// The encryption configuration for Glue Data Quality assets.
        /// </para>
        /// </summary>
        public DataQualityEncryption DataQualityEncryption { get; set; }

        /// <summary>
        /// Checks to see if the DataQualityEncryption property is set.
        /// </summary>
        internal bool IsSetDataQualityEncryption() => this.DataQualityEncryption != null;

        /// <summary>
        /// Gets and sets the property JobBookmarksEncryption. 
        /// <para>
        /// The encryption configuration for job bookmarks.
        /// </para>
        /// </summary>
        public JobBookmarksEncryption JobBookmarksEncryption { get; set; }

        /// <summary>
        /// Checks to see if the JobBookmarksEncryption property is set.
        /// </summary>
        internal bool IsSetJobBookmarksEncryption() => this.JobBookmarksEncryption != null;

        /// <summary>
        /// Gets and sets the property S3Encryption. 
        /// <para>
        /// The encryption configuration for Amazon Simple Storage Service (Amazon S3) data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Encryption> S3Encryption { get; set; } = AWSConfigs.InitializeCollections ? new List<S3Encryption>() : null;

        /// <summary>
        /// Checks to see if the S3Encryption property is set.
        /// </summary>
        internal bool IsSetS3Encryption() => this.S3Encryption != null && (this.S3Encryption.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
