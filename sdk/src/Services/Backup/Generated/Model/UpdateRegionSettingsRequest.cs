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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
    /// Container for the parameters to the UpdateRegionSettings operation.
    /// Updates the current service opt-in settings for the Region.
    /// 
    ///  
    /// <para>
    /// Use the <c>DescribeRegionSettings</c> API to determine the resource types that are
    /// supported.
    /// </para>
    /// </summary>
    public partial class UpdateRegionSettingsRequest : AmazonBackupRequest
    {
        private Dictionary<string, bool> _resourceTypeManagementPreference = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;
        private Dictionary<string, bool> _resourceTypeOptInPreference = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;

        /// <summary>
        /// Gets and sets the property ResourceTypeManagementPreference. 
        /// <para>
        /// Enables or disables full Backup management of backups for a resource type. To enable
        /// full Backup management for DynamoDB along with <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/advanced-ddb-backup.html">
        /// Backup's advanced DynamoDB backup features</a>, follow the procedure to <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/advanced-ddb-backup.html#advanced-ddb-backup-enable-cli">
        /// enable advanced DynamoDB backup programmatically</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, bool> ResourceTypeManagementPreference
        {
            get { return this._resourceTypeManagementPreference; }
            set { this._resourceTypeManagementPreference = value; }
        }

        // Check to see if ResourceTypeManagementPreference property is set
        internal bool IsSetResourceTypeManagementPreference()
        {
            return this._resourceTypeManagementPreference != null && (this._resourceTypeManagementPreference.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypeOptInPreference. 
        /// <para>
        /// Updates the list of services along with the opt-in preferences for the Region.
        /// </para>
        ///  
        /// <para>
        /// If resource assignments are only based on tags, then service opt-in settings are applied.
        /// If a resource type is explicitly assigned to a backup plan, such as Amazon S3, Amazon
        /// EC2, or Amazon RDS, it will be included in the backup even if the opt-in is not enabled
        /// for that particular service. If both a resource type and tags are specified in a resource
        /// assignment, the resource type specified in the backup plan takes priority over the
        /// tag condition. Service opt-in settings are disregarded in this situation.
        /// </para>
        /// </summary>
        public Dictionary<string, bool> ResourceTypeOptInPreference
        {
            get { return this._resourceTypeOptInPreference; }
            set { this._resourceTypeOptInPreference = value; }
        }

        // Check to see if ResourceTypeOptInPreference property is set
        internal bool IsSetResourceTypeOptInPreference()
        {
            return this._resourceTypeOptInPreference != null && (this._resourceTypeOptInPreference.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}