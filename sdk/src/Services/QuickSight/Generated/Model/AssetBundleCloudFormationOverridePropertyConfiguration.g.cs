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
    /// An optional collection of CloudFormation property configurations that control how
    /// the export job is generated.
    /// </summary>
    public partial class AssetBundleCloudFormationOverridePropertyConfiguration
    {
        /// <summary>
        /// Gets and sets the property Analyses. 
        /// <para>
        /// An optional list of structures that control how <c>Analysis</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleExportJobAnalysisOverrideProperties> Analyses { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobAnalysisOverrideProperties>() : null;

        /// <summary>
        /// Checks to see if the Analyses property is set.
        /// </summary>
        internal bool IsSetAnalyses() => this.Analyses != null && (this.Analyses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dashboards. 
        /// <para>
        /// An optional list of structures that control how <c>Dashboard</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleExportJobDashboardOverrideProperties> Dashboards { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobDashboardOverrideProperties>() : null;

        /// <summary>
        /// Checks to see if the Dashboards property is set.
        /// </summary>
        internal bool IsSetDashboards() => this.Dashboards != null && (this.Dashboards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSets. 
        /// <para>
        /// An optional list of structures that control how <c>DataSet</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleExportJobDataSetOverrideProperties> DataSets { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobDataSetOverrideProperties>() : null;

        /// <summary>
        /// Checks to see if the DataSets property is set.
        /// </summary>
        internal bool IsSetDataSets() => this.DataSets != null && (this.DataSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// An optional list of structures that control how <c>DataSource</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleExportJobDataSourceOverrideProperties> DataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobDataSourceOverrideProperties>() : null;

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null && (this.DataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Folders. 
        /// <para>
        /// An optional list of structures that controls how <c>Folder</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleExportJobFolderOverrideProperties> Folders { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobFolderOverrideProperties>() : null;

        /// <summary>
        /// Checks to see if the Folders property is set.
        /// </summary>
        internal bool IsSetFolders() => this.Folders != null && (this.Folders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RefreshSchedules. 
        /// <para>
        /// An optional list of structures that control how <c>RefreshSchedule</c> resources are
        /// parameterized in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleExportJobRefreshScheduleOverrideProperties> RefreshSchedules { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobRefreshScheduleOverrideProperties>() : null;

        /// <summary>
        /// Checks to see if the RefreshSchedules property is set.
        /// </summary>
        internal bool IsSetRefreshSchedules() => this.RefreshSchedules != null && (this.RefreshSchedules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceIdOverrideConfiguration. 
        /// <para>
        /// An optional list of structures that control how resource IDs are parameterized in
        /// the returned CloudFormation template.
        /// </para>
        /// </summary>
        public AssetBundleExportJobResourceIdOverrideConfiguration ResourceIdOverrideConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdOverrideConfiguration property is set.
        /// </summary>
        internal bool IsSetResourceIdOverrideConfiguration() => this.ResourceIdOverrideConfiguration != null;

        /// <summary>
        /// Gets and sets the property Themes. 
        /// <para>
        /// An optional list of structures that control how <c>Theme</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleExportJobThemeOverrideProperties> Themes { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobThemeOverrideProperties>() : null;

        /// <summary>
        /// Checks to see if the Themes property is set.
        /// </summary>
        internal bool IsSetThemes() => this.Themes != null && (this.Themes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicsV2. 
        /// <para>
        /// An optional list of structures that controls how <c>Topic</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleExportJobTopicV2OverrideProperties> TopicsV2 { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobTopicV2OverrideProperties>() : null;

        /// <summary>
        /// Checks to see if the TopicsV2 property is set.
        /// </summary>
        internal bool IsSetTopicsV2() => this.TopicsV2 != null && (this.TopicsV2.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VPCConnections. 
        /// <para>
        /// An optional list of structures that control how <c>VPCConnection</c> resources are
        /// parameterized in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AssetBundleExportJobVPCConnectionOverrideProperties> VPCConnections { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobVPCConnectionOverrideProperties>() : null;

        /// <summary>
        /// Checks to see if the VPCConnections property is set.
        /// </summary>
        internal bool IsSetVPCConnections() => this.VPCConnections != null && (this.VPCConnections.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
