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
    /// This is the response object from the GetDataCatalogExportConfiguration operation.
    /// </summary>
    public partial class GetDataCatalogExportConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp at which the export configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the exported data.
        /// </para>
        /// </summary>
        public ExportEncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExportSetting. 
        /// <para>
        /// The export setting for the data catalog. Valid values are <c>ENABLED</c> and <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ExportSetting ExportSetting { get; set; }

        /// <summary>
        /// Checks to see if the ExportSetting property is set.
        /// </summary>
        internal bool IsSetExportSetting() => this.ExportSetting != null;

        /// <summary>
        /// Gets and sets the property S3TableBucketArn. 
        /// <para>
        /// The ARN of the S3 Tables bucket where catalog metadata is exported.
        /// </para>
        /// </summary>
        public string S3TableBucketArn { get; set; }

        /// <summary>
        /// Checks to see if the S3TableBucketArn property is set.
        /// </summary>
        internal bool IsSetS3TableBucketArn() => this.S3TableBucketArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the export. Valid values are <c>ENABLING</c>, <c>ENABLED</c>,
        /// <c>DISABLING</c>, <c>DISABLED</c>, and <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ExportStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the export configuration was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
