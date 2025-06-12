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
    /// A structure that contains the override permission configurations that modify the permissions
    /// for specified resources before the resource is imported.
    /// </summary>
    public partial class AssetBundleImportJobOverridePermissions
    {
        private List<AssetBundleImportJobAnalysisOverridePermissions> _analyses = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobAnalysisOverridePermissions>() : null;
        private List<AssetBundleImportJobDashboardOverridePermissions> _dashboards = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDashboardOverridePermissions>() : null;
        private List<AssetBundleImportJobDataSetOverridePermissions> _dataSets = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDataSetOverridePermissions>() : null;
        private List<AssetBundleImportJobDataSourceOverridePermissions> _dataSources = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobDataSourceOverridePermissions>() : null;
        private List<AssetBundleImportJobFolderOverridePermissions> _folders = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobFolderOverridePermissions>() : null;
        private List<AssetBundleImportJobThemeOverridePermissions> _themes = AWSConfigs.InitializeCollections ? new List<AssetBundleImportJobThemeOverridePermissions>() : null;

        /// <summary>
        /// Gets and sets the property Analyses. 
        /// <para>
        /// A list of permissions overrides for any <c>Analysis</c> resources that are present
        /// in the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AssetBundleImportJobAnalysisOverridePermissions> Analyses
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
        /// A list of permissions overrides for any <c>Dashboard</c> resources that are present
        /// in the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<AssetBundleImportJobDashboardOverridePermissions> Dashboards
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
        /// A list of permissions overrides for any <c>DataSet</c> resources that are present
        /// in the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<AssetBundleImportJobDataSetOverridePermissions> DataSets
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
        /// A list of permissions overrides for any <c>DataSource</c> resources that are present
        /// in the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<AssetBundleImportJobDataSourceOverridePermissions> DataSources
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
        /// A list of permissions for the folders that you want to apply overrides to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<AssetBundleImportJobFolderOverridePermissions> Folders
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
        /// Gets and sets the property Themes. 
        /// <para>
        /// A list of permissions overrides for any <c>Theme</c> resources that are present in
        /// the asset bundle that is imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<AssetBundleImportJobThemeOverridePermissions> Themes
        {
            get { return this._themes; }
            set { this._themes = value; }
        }

        // Check to see if Themes property is set
        internal bool IsSetThemes()
        {
            return this._themes != null && (this._themes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}