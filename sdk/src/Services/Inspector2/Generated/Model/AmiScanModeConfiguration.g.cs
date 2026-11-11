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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The scan mode configuration that determines which Amazon Machine Images (AMIs) are
    /// scanned.
    /// </summary>
    public partial class AmiScanModeConfiguration
    {
        /// <summary>
        /// Gets and sets the property ExcludeBackupDlmAmis. 
        /// <para>
        /// Whether to exclude AMIs created by Amazon Data Lifecycle Manager (DLM) backups from
        /// scanning.
        /// </para>
        /// </summary>
        public bool? ExcludeBackupDlmAmis { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeBackupDlmAmis property is set.
        /// </summary>
        internal bool IsSetExcludeBackupDlmAmis() => this.ExcludeBackupDlmAmis.HasValue;

        /// <summary>
        /// Gets and sets the property ExcludeCopiedAmis. 
        /// <para>
        /// Whether to exclude AMIs that are copies of other AMIs from scanning.
        /// </para>
        /// </summary>
        public bool? ExcludeCopiedAmis { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeCopiedAmis property is set.
        /// </summary>
        internal bool IsSetExcludeCopiedAmis() => this.ExcludeCopiedAmis.HasValue;

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The scan mode that determines whether all AMIs are scanned or only those matching
        /// the specified tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AmiScanMode ScanMode { get; set; }

        /// <summary>
        /// Checks to see if the ScanMode property is set.
        /// </summary>
        internal bool IsSetScanMode() => this.ScanMode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag filters used to select which AMIs are scanned when using targeted scanning.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<AmiTagFilter> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<AmiTagFilter>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
