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

namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Container for the parameters to the PutSynchronizationConfiguration operation. Creates
    /// or updates the synchronization configuration for the specified S3 File System, including
    /// import data rules and expiration data rules.
    /// </summary>
    public partial class PutSynchronizationConfigurationRequest : AmazonS3FilesRequest
    {
        /// <summary>
        /// Gets and sets the property ExpirationDataRules. 
        /// <para>
        /// An array of expiration data rules that control when cached data expires from the file
        /// system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<ExpirationDataRule> ExpirationDataRules { get; set; } = AWSConfigs.InitializeCollections ? new List<ExpirationDataRule>() : null;

        /// <summary>
        /// Checks to see if the ExpirationDataRules property is set.
        /// </summary>
        internal bool IsSetExpirationDataRules() => this.ExpirationDataRules != null && (this.ExpirationDataRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the S3 File System to configure synchronization
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property ImportDataRules. 
        /// <para>
        /// An array of import data rules that control how data is imported from S3 into the file
        /// system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<ImportDataRule> ImportDataRules { get; set; } = AWSConfigs.InitializeCollections ? new List<ImportDataRule>() : null;

        /// <summary>
        /// Checks to see if the ImportDataRules property is set.
        /// </summary>
        internal bool IsSetImportDataRules() => this.ImportDataRules != null && (this.ImportDataRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LatestVersionNumber. 
        /// <para>
        /// The version number of the current synchronization configuration. Omit this value when
        /// creating a synchronization configuration for the first time. For subsequent updates,
        /// provide this value for optimistic concurrency control. If the version number does
        /// not match the current configuration, the request fails with a <c>ConflictException</c>.
        /// </para>
        /// </summary>
        public int? LatestVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionNumber property is set.
        /// </summary>
        internal bool IsSetLatestVersionNumber() => this.LatestVersionNumber.HasValue;
    }
}
