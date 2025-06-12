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
    /// An optional collection of CloudFormation property configurations that control how
    /// the export job is generated.
    /// </summary>
    public partial class AssetBundleCloudFormationOverridePropertyConfiguration
    {
        private List<AssetBundleExportJobAnalysisOverrideProperties> _analyses = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobAnalysisOverrideProperties>() : null;
        private List<AssetBundleExportJobDashboardOverrideProperties> _dashboards = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobDashboardOverrideProperties>() : null;
        private List<AssetBundleExportJobDataSetOverrideProperties> _dataSets = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobDataSetOverrideProperties>() : null;
        private List<AssetBundleExportJobDataSourceOverrideProperties> _dataSources = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobDataSourceOverrideProperties>() : null;
        private List<AssetBundleExportJobFolderOverrideProperties> _folders = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobFolderOverrideProperties>() : null;
        private List<AssetBundleExportJobRefreshScheduleOverrideProperties> _refreshSchedules = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobRefreshScheduleOverrideProperties>() : null;
        private AssetBundleExportJobResourceIdOverrideConfiguration _resourceIdOverrideConfiguration;
        private List<AssetBundleExportJobThemeOverrideProperties> _themes = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobThemeOverrideProperties>() : null;
        private List<AssetBundleExportJobVPCConnectionOverrideProperties> _vpcConnections = AWSConfigs.InitializeCollections ? new List<AssetBundleExportJobVPCConnectionOverrideProperties>() : null;

        /// <summary>
        /// Gets and sets the property Analyses. 
        /// <para>
        /// An optional list of structures that control how <c>Analysis</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<AssetBundleExportJobAnalysisOverrideProperties> Analyses
        {
            get { return this._analyses; }
            set { this._analyses = value; }
        }

        // Check to see if Analyses property is set
        internal bool IsSetAnalyses()
        {
            return this._analyses != null && (this._analyses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dashboards. 
        /// <para>
        /// An optional list of structures that control how <c>Dashboard</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<AssetBundleExportJobDashboardOverrideProperties> Dashboards
        {
            get { return this._dashboards; }
            set { this._dashboards = value; }
        }

        // Check to see if Dashboards property is set
        internal bool IsSetDashboards()
        {
            return this._dashboards != null && (this._dashboards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataSets. 
        /// <para>
        /// An optional list of structures that control how <c>DataSet</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<AssetBundleExportJobDataSetOverrideProperties> DataSets
        {
            get { return this._dataSets; }
            set { this._dataSets = value; }
        }

        // Check to see if DataSets property is set
        internal bool IsSetDataSets()
        {
            return this._dataSets != null && (this._dataSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// An optional list of structures that control how <c>DataSource</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<AssetBundleExportJobDataSourceOverrideProperties> DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null && (this._dataSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Folders. 
        /// <para>
        /// An optional list of structures that controls how <c>Folder</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<AssetBundleExportJobFolderOverrideProperties> Folders
        {
            get { return this._folders; }
            set { this._folders = value; }
        }

        // Check to see if Folders property is set
        internal bool IsSetFolders()
        {
            return this._folders != null && (this._folders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RefreshSchedules. 
        /// <para>
        /// An optional list of structures that control how <c>RefreshSchedule</c> resources are
        /// parameterized in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<AssetBundleExportJobRefreshScheduleOverrideProperties> RefreshSchedules
        {
            get { return this._refreshSchedules; }
            set { this._refreshSchedules = value; }
        }

        // Check to see if RefreshSchedules property is set
        internal bool IsSetRefreshSchedules()
        {
            return this._refreshSchedules != null && (this._refreshSchedules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdOverrideConfiguration. 
        /// <para>
        /// An optional list of structures that control how resource IDs are parameterized in
        /// the returned CloudFormation template.
        /// </para>
        /// </summary>
        public AssetBundleExportJobResourceIdOverrideConfiguration ResourceIdOverrideConfiguration
        {
            get { return this._resourceIdOverrideConfiguration; }
            set { this._resourceIdOverrideConfiguration = value; }
        }

        // Check to see if ResourceIdOverrideConfiguration property is set
        internal bool IsSetResourceIdOverrideConfiguration()
        {
            return this._resourceIdOverrideConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Themes. 
        /// <para>
        /// An optional list of structures that control how <c>Theme</c> resources are parameterized
        /// in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<AssetBundleExportJobThemeOverrideProperties> Themes
        {
            get { return this._themes; }
            set { this._themes = value; }
        }

        // Check to see if Themes property is set
        internal bool IsSetThemes()
        {
            return this._themes != null && (this._themes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VPCConnections. 
        /// <para>
        /// An optional list of structures that control how <c>VPCConnection</c> resources are
        /// parameterized in the returned CloudFormation template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<AssetBundleExportJobVPCConnectionOverrideProperties> VPCConnections
        {
            get { return this._vpcConnections; }
            set { this._vpcConnections = value; }
        }

        // Check to see if VPCConnections property is set
        internal bool IsSetVPCConnections()
        {
            return this._vpcConnections != null && (this._vpcConnections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}