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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the StartAssetBundleExportJob operation. Starts an
    /// Asset Bundle export job. <para> An Asset Bundle export job exports specified Amazon
    /// Quick Sight assets. You can also choose to export any asset dependencies in the same
    /// job. Export jobs run asynchronously and can be polled with a <c>DescribeAssetBundleExportJob</c>
    /// API call. When a job is successfully completed, a download URL that contains the exported
    /// assets is returned. The URL is valid for 5 minutes and can be refreshed with a <c>DescribeAssetBundleExportJob</c>
    /// API call. Each Amazon Quick Sight account can run up to 5 export jobs concurrently.
    /// </para> <para> The API caller must have the necessary permissions in their IAM role
    /// to access each resource before the resources can be exported. </para>
    /// </summary>
    public partial class StartAssetBundleExportJobRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AssetBundleExportJobId. 
        /// <para>
        /// The ID of the job. This ID is unique while the job is running. After the job is completed,
        /// you can reuse this ID for another job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AssetBundleExportJobId { get; set; }

        /// <summary>
        /// Checks to see if the AssetBundleExportJobId property is set.
        /// </summary>
        internal bool IsSetAssetBundleExportJobId() => this.AssetBundleExportJobId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account to export assets from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CloudFormationOverridePropertyConfiguration. 
        /// <para>
        /// An optional collection of structures that generate CloudFormation parameters to override
        /// the existing resource property values when the resource is exported to a new CloudFormation
        /// template.
        /// </para>
        ///  
        /// <para>
        /// Use this field if the <c>ExportFormat</c> field of a <c>StartAssetBundleExportJobRequest</c>
        /// API call is set to <c>CLOUDFORMATION_JSON</c>.
        /// </para>
        /// </summary>
        public AssetBundleCloudFormationOverridePropertyConfiguration CloudFormationOverridePropertyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CloudFormationOverridePropertyConfiguration property is set.
        /// </summary>
        internal bool IsSetCloudFormationOverridePropertyConfiguration() => this.CloudFormationOverridePropertyConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The export data format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetBundleExportFormat ExportFormat { get; set; }

        /// <summary>
        /// Checks to see if the ExportFormat property is set.
        /// </summary>
        internal bool IsSetExportFormat() => this.ExportFormat != null;

        /// <summary>
        /// Gets and sets the property IncludeAllDependencies. 
        /// <para>
        /// A Boolean that determines whether all dependencies of each resource ARN are recursively
        /// exported with the job. For example, say you provided a Dashboard ARN to the <c>ResourceArns</c>
        /// parameter. If you set <c>IncludeAllDependencies</c> to <c>TRUE</c>, any theme, dataset,
        /// and data source resource that is a dependency of the dashboard is also exported.
        /// </para>
        /// </summary>
        public bool? IncludeAllDependencies { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAllDependencies property is set.
        /// </summary>
        internal bool IsSetIncludeAllDependencies() => this.IncludeAllDependencies.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeFolderMembers. 
        /// <para>
        /// A setting that indicates whether you want to include folder assets. You can also use
        /// this setting to recusrsively include all subfolders of an exported folder.
        /// </para>
        /// </summary>
        public IncludeFolderMembers IncludeFolderMembers { get; set; }

        /// <summary>
        /// Checks to see if the IncludeFolderMembers property is set.
        /// </summary>
        internal bool IsSetIncludeFolderMembers() => this.IncludeFolderMembers != null;

        /// <summary>
        /// Gets and sets the property IncludeFolderMemberships. 
        /// <para>
        /// A Boolean that determines if the exported asset carries over information about the
        /// folders that the asset is a member of. 
        /// </para>
        /// </summary>
        public bool? IncludeFolderMemberships { get; set; }

        /// <summary>
        /// Checks to see if the IncludeFolderMemberships property is set.
        /// </summary>
        internal bool IsSetIncludeFolderMemberships() => this.IncludeFolderMemberships.HasValue;

        /// <summary>
        /// Gets and sets the property IncludePermissions. 
        /// <para>
        /// A Boolean that determines whether all permissions for each resource ARN are exported
        /// with the job. If you set <c>IncludePermissions</c> to <c>TRUE</c>, any permissions
        /// associated with each resource are exported. 
        /// </para>
        /// </summary>
        public bool? IncludePermissions { get; set; }

        /// <summary>
        /// Checks to see if the IncludePermissions property is set.
        /// </summary>
        internal bool IsSetIncludePermissions() => this.IncludePermissions.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeTags. 
        /// <para>
        ///  A Boolean that determines whether all tags for each resource ARN are exported with
        /// the job. If you set <c>IncludeTags</c> to <c>TRUE</c>, any tags associated with each
        /// resource are exported.
        /// </para>
        /// </summary>
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// Checks to see if the IncludeTags property is set.
        /// </summary>
        internal bool IsSetIncludeTags() => this.IncludeTags.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// An array of resource ARNs to export. The following resources are supported.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Analysis</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Dashboard</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DataSet</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DataSource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RefreshSchedule</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Theme</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VPCConnection</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The API caller must have the necessary permissions in their IAM role to access each
        /// resource before the resources can be exported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> ResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceArns property is set.
        /// </summary>
        internal bool IsSetResourceArns() => this.ResourceArns != null && (this.ResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidationStrategy. 
        /// <para>
        /// An optional parameter that determines which validation strategy to use for the export
        /// job. If <c>StrictModeForAllResources</c> is set to <c>TRUE</c>, strict validation
        /// for every error is enforced. If it is set to <c>FALSE</c>, validation is skipped for
        /// specific UI errors that are shown as warnings. The default value for <c>StrictModeForAllResources</c>
        /// is <c>FALSE</c>.
        /// </para>
        /// </summary>
        public AssetBundleExportJobValidationStrategy ValidationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStrategy property is set.
        /// </summary>
        internal bool IsSetValidationStrategy() => this.ValidationStrategy != null;
    }
}
