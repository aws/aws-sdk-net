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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Container for the parameters to the StartAssetBundleExportJob operation.
    /// Starts an Asset Bundle export job.
    /// 
    ///  
    /// <para>
    /// An Asset Bundle export job exports specified QuickSight assets. You can also choose
    /// to export any asset dependencies in the same job. Export jobs run asynchronously and
    /// can be polled with a <c>DescribeAssetBundleExportJob</c> API call. When a job is successfully
    /// completed, a download URL that contains the exported assets is returned. The URL is
    /// valid for 5 minutes and can be refreshed with a <c>DescribeAssetBundleExportJob</c>
    /// API call. Each QuickSight account can run up to 5 export jobs concurrently.
    /// </para>
    ///  
    /// <para>
    /// The API caller must have the necessary permissions in their IAM role to access each
    /// resource before the resources can be exported.
    /// </para>
    /// </summary>
    public partial class StartAssetBundleExportJobRequest : AmazonQuickSightRequest
    {
        private string _assetBundleExportJobId;
        private string _awsAccountId;
        private AssetBundleCloudFormationOverridePropertyConfiguration _cloudFormationOverridePropertyConfiguration;
        private AssetBundleExportFormat _exportFormat;
        private bool? _includeAllDependencies;
        private IncludeFolderMembers _includeFolderMembers;
        private bool? _includeFolderMemberships;
        private bool? _includePermissions;
        private bool? _includeTags;
        private List<string> _resourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AssetBundleExportJobValidationStrategy _validationStrategy;

        /// <summary>
        /// Gets and sets the property AssetBundleExportJobId. 
        /// <para>
        /// The ID of the job. This ID is unique while the job is running. After the job is completed,
        /// you can reuse this ID for another job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AssetBundleExportJobId
        {
            get { return this._assetBundleExportJobId; }
            set { this._assetBundleExportJobId = value; }
        }

        // Check to see if AssetBundleExportJobId property is set
        internal bool IsSetAssetBundleExportJobId()
        {
            return this._assetBundleExportJobId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account to export assets from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

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
        public AssetBundleCloudFormationOverridePropertyConfiguration CloudFormationOverridePropertyConfiguration
        {
            get { return this._cloudFormationOverridePropertyConfiguration; }
            set { this._cloudFormationOverridePropertyConfiguration = value; }
        }

        // Check to see if CloudFormationOverridePropertyConfiguration property is set
        internal bool IsSetCloudFormationOverridePropertyConfiguration()
        {
            return this._cloudFormationOverridePropertyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The export data format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetBundleExportFormat ExportFormat
        {
            get { return this._exportFormat; }
            set { this._exportFormat = value; }
        }

        // Check to see if ExportFormat property is set
        internal bool IsSetExportFormat()
        {
            return this._exportFormat != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeAllDependencies. 
        /// <para>
        /// A Boolean that determines whether all dependencies of each resource ARN are recursively
        /// exported with the job. For example, say you provided a Dashboard ARN to the <c>ResourceArns</c>
        /// parameter. If you set <c>IncludeAllDependencies</c> to <c>TRUE</c>, any theme, dataset,
        /// and data source resource that is a dependency of the dashboard is also exported.
        /// </para>
        /// </summary>
        public bool? IncludeAllDependencies
        {
            get { return this._includeAllDependencies; }
            set { this._includeAllDependencies = value; }
        }

        // Check to see if IncludeAllDependencies property is set
        internal bool IsSetIncludeAllDependencies()
        {
            return this._includeAllDependencies.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeFolderMembers. 
        /// <para>
        /// A setting that indicates whether you want to include folder assets. You can also use
        /// this setting to recusrsively include all subfolders of an exported folder.
        /// </para>
        /// </summary>
        public IncludeFolderMembers IncludeFolderMembers
        {
            get { return this._includeFolderMembers; }
            set { this._includeFolderMembers = value; }
        }

        // Check to see if IncludeFolderMembers property is set
        internal bool IsSetIncludeFolderMembers()
        {
            return this._includeFolderMembers != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeFolderMemberships. 
        /// <para>
        /// A Boolean that determines if the exported asset carries over information about the
        /// folders that the asset is a member of. 
        /// </para>
        /// </summary>
        public bool? IncludeFolderMemberships
        {
            get { return this._includeFolderMemberships; }
            set { this._includeFolderMemberships = value; }
        }

        // Check to see if IncludeFolderMemberships property is set
        internal bool IsSetIncludeFolderMemberships()
        {
            return this._includeFolderMemberships.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludePermissions. 
        /// <para>
        /// A Boolean that determines whether all permissions for each resource ARN are exported
        /// with the job. If you set <c>IncludePermissions</c> to <c>TRUE</c>, any permissions
        /// associated with each resource are exported. 
        /// </para>
        /// </summary>
        public bool? IncludePermissions
        {
            get { return this._includePermissions; }
            set { this._includePermissions = value; }
        }

        // Check to see if IncludePermissions property is set
        internal bool IsSetIncludePermissions()
        {
            return this._includePermissions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeTags. 
        /// <para>
        ///  A Boolean that determines whether all tags for each resource ARN are exported with
        /// the job. If you set <c>IncludeTags</c> to <c>TRUE</c>, any tags associated with each
        /// resource are exported.
        /// </para>
        /// </summary>
        public bool? IncludeTags
        {
            get { return this._includeTags; }
            set { this._includeTags = value; }
        }

        // Check to see if IncludeTags property is set
        internal bool IsSetIncludeTags()
        {
            return this._includeTags.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && (this._resourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public AssetBundleExportJobValidationStrategy ValidationStrategy
        {
            get { return this._validationStrategy; }
            set { this._validationStrategy = value; }
        }

        // Check to see if ValidationStrategy property is set
        internal bool IsSetValidationStrategy()
        {
            return this._validationStrategy != null;
        }

    }
}