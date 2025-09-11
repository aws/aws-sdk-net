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
    /// A set of actions that correspond to QuickSight permissions.
    /// </summary>
    public partial class Capabilities
    {
        private CapabilityState _addOrRunAnomalyDetectionForAnalyses;
        private CapabilityState _analysis;
        private CapabilityState _createAndUpdateDashboardEmailReports;
        private CapabilityState _createAndUpdateDatasets;
        private CapabilityState _createAndUpdateDataSources;
        private CapabilityState _createAndUpdateThemes;
        private CapabilityState _createAndUpdateThresholdAlerts;
        private CapabilityState _createSharedFolders;
        private CapabilityState _createSPICEDataset;
        private CapabilityState _dashboard;
        private CapabilityState _exportToCsv;
        private CapabilityState _exportToCsvInScheduledReports;
        private CapabilityState _exportToExcel;
        private CapabilityState _exportToExcelInScheduledReports;
        private CapabilityState _exportToPdf;
        private CapabilityState _exportToPdfInScheduledReports;
        private CapabilityState _includeContentInScheduledReportsEmail;
        private CapabilityState _printReports;
        private CapabilityState _renameSharedFolders;
        private CapabilityState _shareAnalyses;
        private CapabilityState _shareDashboards;
        private CapabilityState _shareDatasets;
        private CapabilityState _shareDataSources;
        private CapabilityState _subscribeDashboardEmailReports;
        private CapabilityState _viewAccountSPICECapacity;

        /// <summary>
        /// Gets and sets the property AddOrRunAnomalyDetectionForAnalyses. 
        /// <para>
        /// The ability to add or run anomaly detection.
        /// </para>
        /// </summary>
        public CapabilityState AddOrRunAnomalyDetectionForAnalyses
        {
            get { return this._addOrRunAnomalyDetectionForAnalyses; }
            set { this._addOrRunAnomalyDetectionForAnalyses = value; }
        }

        // Check to see if AddOrRunAnomalyDetectionForAnalyses property is set
        internal bool IsSetAddOrRunAnomalyDetectionForAnalyses()
        {
            return this._addOrRunAnomalyDetectionForAnalyses != null;
        }

        /// <summary>
        /// Gets and sets the property Analysis. 
        /// <para>
        /// The ability to perform analysis-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Analysis
        {
            get { return this._analysis; }
            set { this._analysis = value; }
        }

        // Check to see if Analysis property is set
        internal bool IsSetAnalysis()
        {
            return this._analysis != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDashboardEmailReports. 
        /// <para>
        /// The ability to create and update email reports.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDashboardEmailReports
        {
            get { return this._createAndUpdateDashboardEmailReports; }
            set { this._createAndUpdateDashboardEmailReports = value; }
        }

        // Check to see if CreateAndUpdateDashboardEmailReports property is set
        internal bool IsSetCreateAndUpdateDashboardEmailReports()
        {
            return this._createAndUpdateDashboardEmailReports != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDatasets. 
        /// <para>
        /// The ability to create and update datasets.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDatasets
        {
            get { return this._createAndUpdateDatasets; }
            set { this._createAndUpdateDatasets = value; }
        }

        // Check to see if CreateAndUpdateDatasets property is set
        internal bool IsSetCreateAndUpdateDatasets()
        {
            return this._createAndUpdateDatasets != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateDataSources. 
        /// <para>
        /// The ability to create and update data sources.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateDataSources
        {
            get { return this._createAndUpdateDataSources; }
            set { this._createAndUpdateDataSources = value; }
        }

        // Check to see if CreateAndUpdateDataSources property is set
        internal bool IsSetCreateAndUpdateDataSources()
        {
            return this._createAndUpdateDataSources != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateThemes. 
        /// <para>
        /// The ability to export to Create and Update themes.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateThemes
        {
            get { return this._createAndUpdateThemes; }
            set { this._createAndUpdateThemes = value; }
        }

        // Check to see if CreateAndUpdateThemes property is set
        internal bool IsSetCreateAndUpdateThemes()
        {
            return this._createAndUpdateThemes != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAndUpdateThresholdAlerts. 
        /// <para>
        /// The ability to create and update threshold alerts.
        /// </para>
        /// </summary>
        public CapabilityState CreateAndUpdateThresholdAlerts
        {
            get { return this._createAndUpdateThresholdAlerts; }
            set { this._createAndUpdateThresholdAlerts = value; }
        }

        // Check to see if CreateAndUpdateThresholdAlerts property is set
        internal bool IsSetCreateAndUpdateThresholdAlerts()
        {
            return this._createAndUpdateThresholdAlerts != null;
        }

        /// <summary>
        /// Gets and sets the property CreateSharedFolders. 
        /// <para>
        /// The ability to create shared folders.
        /// </para>
        /// </summary>
        public CapabilityState CreateSharedFolders
        {
            get { return this._createSharedFolders; }
            set { this._createSharedFolders = value; }
        }

        // Check to see if CreateSharedFolders property is set
        internal bool IsSetCreateSharedFolders()
        {
            return this._createSharedFolders != null;
        }

        /// <summary>
        /// Gets and sets the property CreateSPICEDataset. 
        /// <para>
        /// The ability to create a SPICE dataset.
        /// </para>
        /// </summary>
        public CapabilityState CreateSPICEDataset
        {
            get { return this._createSPICEDataset; }
            set { this._createSPICEDataset = value; }
        }

        // Check to see if CreateSPICEDataset property is set
        internal bool IsSetCreateSPICEDataset()
        {
            return this._createSPICEDataset != null;
        }

        /// <summary>
        /// Gets and sets the property Dashboard. 
        /// <para>
        /// The ability to perform dashboard-related actions.
        /// </para>
        /// </summary>
        public CapabilityState Dashboard
        {
            get { return this._dashboard; }
            set { this._dashboard = value; }
        }

        // Check to see if Dashboard property is set
        internal bool IsSetDashboard()
        {
            return this._dashboard != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToCsv. 
        /// <para>
        /// The ability to export to CSV files from the UI.
        /// </para>
        /// </summary>
        public CapabilityState ExportToCsv
        {
            get { return this._exportToCsv; }
            set { this._exportToCsv = value; }
        }

        // Check to see if ExportToCsv property is set
        internal bool IsSetExportToCsv()
        {
            return this._exportToCsv != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToCsvInScheduledReports. 
        /// <para>
        /// The ability to export to CSV files in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState ExportToCsvInScheduledReports
        {
            get { return this._exportToCsvInScheduledReports; }
            set { this._exportToCsvInScheduledReports = value; }
        }

        // Check to see if ExportToCsvInScheduledReports property is set
        internal bool IsSetExportToCsvInScheduledReports()
        {
            return this._exportToCsvInScheduledReports != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToExcel. 
        /// <para>
        /// The ability to export to Excel files from the UI.
        /// </para>
        /// </summary>
        public CapabilityState ExportToExcel
        {
            get { return this._exportToExcel; }
            set { this._exportToExcel = value; }
        }

        // Check to see if ExportToExcel property is set
        internal bool IsSetExportToExcel()
        {
            return this._exportToExcel != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToExcelInScheduledReports. 
        /// <para>
        /// The ability to export to Excel files in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState ExportToExcelInScheduledReports
        {
            get { return this._exportToExcelInScheduledReports; }
            set { this._exportToExcelInScheduledReports = value; }
        }

        // Check to see if ExportToExcelInScheduledReports property is set
        internal bool IsSetExportToExcelInScheduledReports()
        {
            return this._exportToExcelInScheduledReports != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToPdf. 
        /// <para>
        /// The ability to export to PDF files from the UI.
        /// </para>
        /// </summary>
        public CapabilityState ExportToPdf
        {
            get { return this._exportToPdf; }
            set { this._exportToPdf = value; }
        }

        // Check to see if ExportToPdf property is set
        internal bool IsSetExportToPdf()
        {
            return this._exportToPdf != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToPdfInScheduledReports. 
        /// <para>
        /// The ability to export to PDF files in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState ExportToPdfInScheduledReports
        {
            get { return this._exportToPdfInScheduledReports; }
            set { this._exportToPdfInScheduledReports = value; }
        }

        // Check to see if ExportToPdfInScheduledReports property is set
        internal bool IsSetExportToPdfInScheduledReports()
        {
            return this._exportToPdfInScheduledReports != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeContentInScheduledReportsEmail. 
        /// <para>
        /// The ability to include content in scheduled email reports.
        /// </para>
        /// </summary>
        public CapabilityState IncludeContentInScheduledReportsEmail
        {
            get { return this._includeContentInScheduledReportsEmail; }
            set { this._includeContentInScheduledReportsEmail = value; }
        }

        // Check to see if IncludeContentInScheduledReportsEmail property is set
        internal bool IsSetIncludeContentInScheduledReportsEmail()
        {
            return this._includeContentInScheduledReportsEmail != null;
        }

        /// <summary>
        /// Gets and sets the property PrintReports. 
        /// <para>
        /// The ability to print reports.
        /// </para>
        /// </summary>
        public CapabilityState PrintReports
        {
            get { return this._printReports; }
            set { this._printReports = value; }
        }

        // Check to see if PrintReports property is set
        internal bool IsSetPrintReports()
        {
            return this._printReports != null;
        }

        /// <summary>
        /// Gets and sets the property RenameSharedFolders. 
        /// <para>
        /// The ability to rename shared folders.
        /// </para>
        /// </summary>
        public CapabilityState RenameSharedFolders
        {
            get { return this._renameSharedFolders; }
            set { this._renameSharedFolders = value; }
        }

        // Check to see if RenameSharedFolders property is set
        internal bool IsSetRenameSharedFolders()
        {
            return this._renameSharedFolders != null;
        }

        /// <summary>
        /// Gets and sets the property ShareAnalyses. 
        /// <para>
        /// The ability to share analyses.
        /// </para>
        /// </summary>
        public CapabilityState ShareAnalyses
        {
            get { return this._shareAnalyses; }
            set { this._shareAnalyses = value; }
        }

        // Check to see if ShareAnalyses property is set
        internal bool IsSetShareAnalyses()
        {
            return this._shareAnalyses != null;
        }

        /// <summary>
        /// Gets and sets the property ShareDashboards. 
        /// <para>
        /// The ability to share dashboards.
        /// </para>
        /// </summary>
        public CapabilityState ShareDashboards
        {
            get { return this._shareDashboards; }
            set { this._shareDashboards = value; }
        }

        // Check to see if ShareDashboards property is set
        internal bool IsSetShareDashboards()
        {
            return this._shareDashboards != null;
        }

        /// <summary>
        /// Gets and sets the property ShareDatasets. 
        /// <para>
        /// The ability to share datasets.
        /// </para>
        /// </summary>
        public CapabilityState ShareDatasets
        {
            get { return this._shareDatasets; }
            set { this._shareDatasets = value; }
        }

        // Check to see if ShareDatasets property is set
        internal bool IsSetShareDatasets()
        {
            return this._shareDatasets != null;
        }

        /// <summary>
        /// Gets and sets the property ShareDataSources. 
        /// <para>
        /// The ability to share data sources.
        /// </para>
        /// </summary>
        public CapabilityState ShareDataSources
        {
            get { return this._shareDataSources; }
            set { this._shareDataSources = value; }
        }

        // Check to see if ShareDataSources property is set
        internal bool IsSetShareDataSources()
        {
            return this._shareDataSources != null;
        }

        /// <summary>
        /// Gets and sets the property SubscribeDashboardEmailReports. 
        /// <para>
        /// The ability to subscribe to email reports.
        /// </para>
        /// </summary>
        public CapabilityState SubscribeDashboardEmailReports
        {
            get { return this._subscribeDashboardEmailReports; }
            set { this._subscribeDashboardEmailReports = value; }
        }

        // Check to see if SubscribeDashboardEmailReports property is set
        internal bool IsSetSubscribeDashboardEmailReports()
        {
            return this._subscribeDashboardEmailReports != null;
        }

        /// <summary>
        /// Gets and sets the property ViewAccountSPICECapacity. 
        /// <para>
        /// The ability to view account SPICE capacity.
        /// </para>
        /// </summary>
        public CapabilityState ViewAccountSPICECapacity
        {
            get { return this._viewAccountSPICECapacity; }
            set { this._viewAccountSPICECapacity = value; }
        }

        // Check to see if ViewAccountSPICECapacity property is set
        internal bool IsSetViewAccountSPICECapacity()
        {
            return this._viewAccountSPICECapacity != null;
        }

    }
}