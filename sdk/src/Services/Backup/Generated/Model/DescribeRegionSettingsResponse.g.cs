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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the DescribeRegionSettings operation.
    /// </summary>
    public partial class DescribeRegionSettingsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ResourceTypeManagementPreference. 
        /// <para>
        /// Returns whether Backup fully manages the backups for a resource type.
        /// </para>
        ///  
        /// <para>
        /// For the benefits of full Backup management, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html#full-management">Full
        /// Backup management</a>.
        /// </para>
        ///  
        /// <para>
        /// For a list of resource types and whether each supports full Backup management, see
        /// the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-feature-availability.html#features-by-resource">Feature
        /// availability by resource</a> table.
        /// </para>
        ///  
        /// <para>
        /// If <c>"DynamoDB":false</c>, you can enable full Backup management for DynamoDB backup
        /// by enabling <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/advanced-ddb-backup.html#advanced-ddb-backup-enable-cli">
        /// Backup's advanced DynamoDB backup features</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, bool> ResourceTypeManagementPreference { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypeManagementPreference property is set.
        /// </summary>
        internal bool IsSetResourceTypeManagementPreference() => this.ResourceTypeManagementPreference != null && (this.ResourceTypeManagementPreference.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTypeOptInPreference. 
        /// <para>
        /// The services along with the opt-in preferences in the Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, bool> ResourceTypeOptInPreference { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypeOptInPreference property is set.
        /// </summary>
        internal bool IsSetResourceTypeOptInPreference() => this.ResourceTypeOptInPreference != null && (this.ResourceTypeOptInPreference.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
