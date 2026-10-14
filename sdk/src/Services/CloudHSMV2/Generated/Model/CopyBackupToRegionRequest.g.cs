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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the CopyBackupToRegion operation. Copy an CloudHSM
    /// cluster backup to a different region. <para> <b>Cross-account use:</b> No. You cannot
    /// perform this operation on an CloudHSM backup in a different Amazon Web Services account.
    /// </para>
    /// </summary>
    public partial class CopyBackupToRegionRequest : AmazonCloudHSMV2Request
    {
        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The ID of the backup that will be copied to the destination region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupId { get; set; }

        /// <summary>
        /// Checks to see if the BackupId property is set.
        /// </summary>
        internal bool IsSetBackupId() => this.BackupId != null;

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The AWS region that will contain your copied CloudHSM cluster backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRegion property is set.
        /// </summary>
        internal bool IsSetDestinationRegion() => this.DestinationRegion != null;

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// Tags to apply to the destination backup during creation. If you specify tags, only
        /// these tags will be applied to the destination backup. If you do not specify tags,
        /// the service copies tags from the source backup to the destination backup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
