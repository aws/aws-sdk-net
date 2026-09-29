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
    /// A structure that contains the override tag configuration that modify the tags that
    /// are assigned to specified resources before the resource is imported.
    /// </summary>
    public partial class AssetBundleImportJobOverrideTags
    {
        /// <summary>
        /// Gets and sets the property Analyses. 
        /// <para>
        /// A list of tag overrides for any <c>Analysis</c> resources that are present in the
        /// asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AssetBundleImportJobAnalysisOverrideTags> Analyses { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobAnalysisOverrideTags>() : null;

        /// <summary>
        /// Checks to see if the Analyses property is set.
        /// </summary>
        internal bool IsSetAnalyses() => this.Analyses != null && (this.Analyses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dashboards. 
        /// <para>
        /// A list of tag overrides for any <c>Dashboard</c> resources that are present in the
        /// asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AssetBundleImportJobDashboardOverrideTags> Dashboards { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDashboardOverrideTags>() : null;

        /// <summary>
        /// Checks to see if the Dashboards property is set.
        /// </summary>
        internal bool IsSetDashboards() => this.Dashboards != null && (this.Dashboards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSets. 
        /// <para>
        /// A list of tag overrides for any <c>DataSet</c> resources that are present in the asset
        /// bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AssetBundleImportJobDataSetOverrideTags> DataSets { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDataSetOverrideTags>() : null;

        /// <summary>
        /// Checks to see if the DataSets property is set.
        /// </summary>
        internal bool IsSetDataSets() => this.DataSets != null && (this.DataSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// A list of tag overrides for any <c>DataSource</c> resources that are present in the
        /// asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AssetBundleImportJobDataSourceOverrideTags> DataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDataSourceOverrideTags>() : null;

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null && (this.DataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Folders. 
        /// <para>
        /// A list of tag overrides for any <c>Folder</c> resources that are present in the asset
        /// bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AssetBundleImportJobFolderOverrideTags> Folders { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobFolderOverrideTags>() : null;

        /// <summary>
        /// Checks to see if the Folders property is set.
        /// </summary>
        internal bool IsSetFolders() => this.Folders != null && (this.Folders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Themes. 
        /// <para>
        /// A list of tag overrides for any <c>Theme</c> resources that are present in the asset
        /// bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AssetBundleImportJobThemeOverrideTags> Themes { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobThemeOverrideTags>() : null;

        /// <summary>
        /// Checks to see if the Themes property is set.
        /// </summary>
        internal bool IsSetThemes() => this.Themes != null && (this.Themes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicsV2. 
        /// <para>
        /// A list of tag overrides for any <c>Topic</c> resources that are present in the asset
        /// bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AssetBundleImportJobTopicV2OverrideTags> TopicsV2 { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobTopicV2OverrideTags>() : null;

        /// <summary>
        /// Checks to see if the TopicsV2 property is set.
        /// </summary>
        internal bool IsSetTopicsV2() => this.TopicsV2 != null && (this.TopicsV2.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VPCConnections. 
        /// <para>
        /// A list of tag overrides for any <c>VPCConnection</c> resources that are present in
        /// the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AssetBundleImportJobVPCConnectionOverrideTags> VPCConnections { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobVPCConnectionOverrideTags>() : null;

        /// <summary>
        /// Checks to see if the VPCConnections property is set.
        /// </summary>
        internal bool IsSetVPCConnections() => this.VPCConnections != null && (this.VPCConnections.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
