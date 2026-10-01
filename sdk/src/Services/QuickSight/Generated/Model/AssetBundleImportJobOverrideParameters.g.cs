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
    /// A list of overrides that modify the asset bundle resource configuration before the
    /// resource is imported.
    /// </summary>
    public partial class AssetBundleImportJobOverrideParameters
    {
        /// <summary>
        /// Gets and sets the property Analyses. 
        /// <para>
        /// A list of overrides for any <c>Analysis</c> resources that are present in the asset
        /// bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleImportJobAnalysisOverrideParameters> Analyses { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobAnalysisOverrideParameters>() : null;

        /// <summary>
        /// Checks to see if the Analyses property is set.
        /// </summary>
        internal bool IsSetAnalyses() => this.Analyses != null && (this.Analyses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dashboards. 
        /// <para>
        /// A list of overrides for any <c>Dashboard</c> resources that are present in the asset
        /// bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleImportJobDashboardOverrideParameters> Dashboards { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDashboardOverrideParameters>() : null;

        /// <summary>
        /// Checks to see if the Dashboards property is set.
        /// </summary>
        internal bool IsSetDashboards() => this.Dashboards != null && (this.Dashboards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSets. 
        /// <para>
        /// A list of overrides for any <c>DataSet</c> resources that are present in the asset
        /// bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleImportJobDataSetOverrideParameters> DataSets { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDataSetOverrideParameters>() : null;

        /// <summary>
        /// Checks to see if the DataSets property is set.
        /// </summary>
        internal bool IsSetDataSets() => this.DataSets != null && (this.DataSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        ///  A list of overrides for any <c>DataSource</c> resources that are present in the asset
        /// bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleImportJobDataSourceOverrideParameters> DataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDataSourceOverrideParameters>() : null;

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null && (this.DataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Folders. 
        /// <para>
        /// A list of overrides for any <c>Folder</c> resources that are present in the asset
        /// bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleImportJobFolderOverrideParameters> Folders { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobFolderOverrideParameters>() : null;

        /// <summary>
        /// Checks to see if the Folders property is set.
        /// </summary>
        internal bool IsSetFolders() => this.Folders != null && (this.Folders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RefreshSchedules. 
        /// <para>
        /// A list of overrides for any <c>RefreshSchedule</c> resources that are present in the
        /// asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleImportJobRefreshScheduleOverrideParameters> RefreshSchedules { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobRefreshScheduleOverrideParameters>() : null;

        /// <summary>
        /// Checks to see if the RefreshSchedules property is set.
        /// </summary>
        internal bool IsSetRefreshSchedules() => this.RefreshSchedules != null && (this.RefreshSchedules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceIdOverrideConfiguration. 
        /// <para>
        /// An optional structure that configures resource ID overrides to be applied within the
        /// import job.
        /// </para>
        /// </summary>
        public AssetBundleImportJobResourceIdOverrideConfiguration ResourceIdOverrideConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdOverrideConfiguration property is set.
        /// </summary>
        internal bool IsSetResourceIdOverrideConfiguration() => this.ResourceIdOverrideConfiguration != null;

        /// <summary>
        /// Gets and sets the property Themes. 
        /// <para>
        /// A list of overrides for any <c>Theme</c> resources that are present in the asset bundle
        /// that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleImportJobThemeOverrideParameters> Themes { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobThemeOverrideParameters>() : null;

        /// <summary>
        /// Checks to see if the Themes property is set.
        /// </summary>
        internal bool IsSetThemes() => this.Themes != null && (this.Themes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicsV2. 
        /// <para>
        /// A list of overrides for any <c>Topic</c> resources that are present in the asset bundle
        /// that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleImportJobTopicV2OverrideParameters> TopicsV2 { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobTopicV2OverrideParameters>() : null;

        /// <summary>
        /// Checks to see if the TopicsV2 property is set.
        /// </summary>
        internal bool IsSetTopicsV2() => this.TopicsV2 != null && (this.TopicsV2.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VPCConnections. 
        /// <para>
        /// A list of overrides for any <c>VPCConnection</c> resources that are present in the
        /// asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleImportJobVPCConnectionOverrideParameters> VPCConnections { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobVPCConnectionOverrideParameters>() : null;

        /// <summary>
        /// Checks to see if the VPCConnections property is set.
        /// </summary>
        internal bool IsSetVPCConnections() => this.VPCConnections != null && (this.VPCConnections.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
