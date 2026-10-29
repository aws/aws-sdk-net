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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the source of the data included in the resource data sync.
    /// </summary>
    public partial class ResourceDataSyncSource
    {
        /// <summary>
        /// Gets and sets the property AwsOrganizationsSource. 
        /// <para>
        /// Information about the <c>AwsOrganizationsSource</c> resource data sync source. A sync
        /// source of this type can synchronize data from Organizations.
        /// </para>
        /// </summary>
        public ResourceDataSyncAwsOrganizationsSource AwsOrganizationsSource { get; set; }

        /// <summary>
        /// Checks to see if the AwsOrganizationsSource property is set.
        /// </summary>
        internal bool IsSetAwsOrganizationsSource() => this.AwsOrganizationsSource != null;

        /// <summary>
        /// Gets and sets the property EnableAllOpsDataSources. 
        /// <para>
        /// When you create a resource data sync, if you choose one of the Organizations options,
        /// then Systems Manager automatically enables all OpsData sources in the selected Amazon
        /// Web Services Regions for all Amazon Web Services accounts in your organization (or
        /// in the selected organization units). For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/Explorer-resource-data-sync.html">Setting
        /// up Systems Manager Explorer to display data from multiple accounts and Regions</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableAllOpsDataSources { get; set; }

        /// <summary>
        /// Checks to see if the EnableAllOpsDataSources property is set.
        /// </summary>
        internal bool IsSetEnableAllOpsDataSources() => this.EnableAllOpsDataSources.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeFutureRegions. 
        /// <para>
        /// Whether to automatically synchronize and aggregate data from new Amazon Web Services
        /// Regions when those Regions come online.
        /// </para>
        /// </summary>
        public bool? IncludeFutureRegions { get; set; }

        /// <summary>
        /// Checks to see if the IncludeFutureRegions property is set.
        /// </summary>
        internal bool IsSetIncludeFutureRegions() => this.IncludeFutureRegions.HasValue;

        /// <summary>
        /// Gets and sets the property SourceRegions. 
        /// <para>
        /// The <c>SyncSource</c> Amazon Web Services Regions included in the resource data sync.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SourceRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceRegions property is set.
        /// </summary>
        internal bool IsSetSourceRegions() => this.SourceRegions != null && (this.SourceRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of data source for the resource data sync. <c>SourceType</c> is either <c>AwsOrganizations</c>
        /// (if an organization is present in Organizations) or <c>SingleAccountMultiRegions</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
