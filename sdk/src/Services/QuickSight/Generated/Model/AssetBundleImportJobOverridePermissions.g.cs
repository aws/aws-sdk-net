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
    /// A structure that contains the override permission configurations that modify the permissions
    /// for specified resources before the resource is imported.
    /// </summary>
    public partial class AssetBundleImportJobOverridePermissions
    {
        /// <summary>
        /// Gets and sets the property Analyses. 
        /// <para>
        /// A list of permissions overrides for any <c>Analysis</c> resources that are present
        /// in the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<AssetBundleImportJobAnalysisOverridePermissions> Analyses { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobAnalysisOverridePermissions>() : null;

        /// <summary>
        /// Checks to see if the Analyses property is set.
        /// </summary>
        internal bool IsSetAnalyses() => this.Analyses != null && (this.Analyses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dashboards. 
        /// <para>
        /// A list of permissions overrides for any <c>Dashboard</c> resources that are present
        /// in the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<AssetBundleImportJobDashboardOverridePermissions> Dashboards { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDashboardOverridePermissions>() : null;

        /// <summary>
        /// Checks to see if the Dashboards property is set.
        /// </summary>
        internal bool IsSetDashboards() => this.Dashboards != null && (this.Dashboards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSets. 
        /// <para>
        /// A list of permissions overrides for any <c>DataSet</c> resources that are present
        /// in the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<AssetBundleImportJobDataSetOverridePermissions> DataSets { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDataSetOverridePermissions>() : null;

        /// <summary>
        /// Checks to see if the DataSets property is set.
        /// </summary>
        internal bool IsSetDataSets() => this.DataSets != null && (this.DataSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// A list of permissions overrides for any <c>DataSource</c> resources that are present
        /// in the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<AssetBundleImportJobDataSourceOverridePermissions> DataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDataSourceOverridePermissions>() : null;

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null && (this.DataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Folders. 
        /// <para>
        /// A list of permissions for the folders that you want to apply overrides to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<AssetBundleImportJobFolderOverridePermissions> Folders { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobFolderOverridePermissions>() : null;

        /// <summary>
        /// Checks to see if the Folders property is set.
        /// </summary>
        internal bool IsSetFolders() => this.Folders != null && (this.Folders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Themes. 
        /// <para>
        /// A list of permissions overrides for any <c>Theme</c> resources that are present in
        /// the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<AssetBundleImportJobThemeOverridePermissions> Themes { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobThemeOverridePermissions>() : null;

        /// <summary>
        /// Checks to see if the Themes property is set.
        /// </summary>
        internal bool IsSetThemes() => this.Themes != null && (this.Themes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicsV2. 
        /// <para>
        /// A list of permissions for the topics that you want to apply overrides to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<AssetBundleImportJobTopicV2OverridePermissions> TopicsV2 { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobTopicV2OverridePermissions>() : null;

        /// <summary>
        /// Checks to see if the TopicsV2 property is set.
        /// </summary>
        internal bool IsSetTopicsV2() => this.TopicsV2 != null && (this.TopicsV2.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
