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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration for centralization destination log groups, including encryption and
    /// backup settings.
    /// </summary>
    public partial class DestinationLogsConfiguration
    {
        /// <summary>
        /// Gets and sets the property BackupConfiguration. 
        /// <para>
        /// Configuration defining the backup region and an optional KMS key for the backup destination.
        /// </para>
        /// </summary>
        public LogsBackupConfiguration BackupConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BackupConfiguration property is set.
        /// </summary>
        internal bool IsSetBackupConfiguration() => this.BackupConfiguration != null;

        /// <summary>
        /// Gets and sets the property LogGroupDeletionProtection. 
        /// <para>
        /// Specifies whether this centralization rule enables deletion protection on the destination
        /// log groups that it creates. If you don't specify this setting, the rule doesn't enable
        /// deletion protection on the log groups that it creates. If you specify a backup Region
        /// in <c>BackupConfiguration</c>, the setting also applies to the log groups that the
        /// rule creates in the backup Region.
        /// </para>
        ///  
        /// <para>
        /// When you set this to <c>ENABLED</c>, the rule enables deletion protection only on
        /// log groups that it creates after you enable the setting. It does not add deletion
        /// protection to log groups the rule created before you enabled the setting.
        /// </para>
        ///  
        /// <para>
        /// If you remove this setting from the rule or delete the rule, deletion protection stays
        /// enabled on log groups that already have it. To delete one of these log groups, first
        /// disable deletion protection on the log group in the destination account.
        /// </para>
        /// </summary>
        public DeletionProtection LogGroupDeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupDeletionProtection property is set.
        /// </summary>
        internal bool IsSetLogGroupDeletionProtection() => this.LogGroupDeletionProtection != null;

        /// <summary>
        /// Gets and sets the property LogGroupNameConfiguration. 
        /// <para>
        /// Configuration that specifies a naming pattern for destination log groups created during
        /// centralization. The pattern supports static text and dynamic variables that are replaced
        /// with source attributes when log groups are created.
        /// </para>
        /// </summary>
        public LogGroupNameConfiguration LogGroupNameConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupNameConfiguration property is set.
        /// </summary>
        internal bool IsSetLogGroupNameConfiguration() => this.LogGroupNameConfiguration != null;

        /// <summary>
        /// Gets and sets the property LogsEncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for centralization destination log groups.
        /// </para>
        /// </summary>
        public LogsEncryptionConfiguration LogsEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogsEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetLogsEncryptionConfiguration() => this.LogsEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property TagPropagationConfiguration. 
        /// <para>
        /// Specifies the tag propagation configuration for this centralization rule. When present,
        /// <c>LogGroupNameConfiguration</c> must use a <c>LogGroupNamePattern</c> that contains
        /// <c>${source.logGroup}</c>, <c>${source.accountId}</c>, and <c>${source.region}</c>.
        /// </para>
        /// </summary>
        public TagPropagationConfiguration TagPropagationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TagPropagationConfiguration property is set.
        /// </summary>
        internal bool IsSetTagPropagationConfiguration() => this.TagPropagationConfiguration != null;
    }
}
