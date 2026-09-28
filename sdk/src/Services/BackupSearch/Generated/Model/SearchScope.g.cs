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

namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// The search scope is all backup properties input into a search.
    /// </summary>
    public partial class SearchScope
    {
        /// <summary>
        /// Gets and sets the property BackupResourceArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the backup resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> BackupResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BackupResourceArns property is set.
        /// </summary>
        internal bool IsSetBackupResourceArns() => this.BackupResourceArns != null && (this.BackupResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BackupResourceCreationTime. 
        /// <para>
        /// This is the time a backup resource was created.
        /// </para>
        /// </summary>
        public BackupCreationTimeFilter BackupResourceCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the BackupResourceCreationTime property is set.
        /// </summary>
        internal bool IsSetBackupResourceCreationTime() => this.BackupResourceCreationTime != null;

        /// <summary>
        /// Gets and sets the property BackupResourceTags. 
        /// <para>
        /// These are one or more tags on the backup (recovery point).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> BackupResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the BackupResourceTags property is set.
        /// </summary>
        internal bool IsSetBackupResourceTags() => this.BackupResourceTags != null && (this.BackupResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BackupResourceTypes. 
        /// <para>
        /// The resource types included in a search.
        /// </para>
        ///  
        /// <para>
        /// Eligible resource types include S3 and EBS.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> BackupResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BackupResourceTypes property is set.
        /// </summary>
        internal bool IsSetBackupResourceTypes() => this.BackupResourceTypes != null && (this.BackupResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceResourceArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the source resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> SourceResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceResourceArns property is set.
        /// </summary>
        internal bool IsSetSourceResourceArns() => this.SourceResourceArns != null && (this.SourceResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
