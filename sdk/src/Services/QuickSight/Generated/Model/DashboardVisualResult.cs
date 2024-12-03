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
    /// The QA result that is made from dashboard visual.
    /// </summary>
    public partial class DashboardVisualResult
    {
        private string _dashboardId;
        private string _dashboardName;
        private string _dashboardUrl;
        private string _sheetId;
        private string _sheetName;
        private string _visualId;
        private string _visualSubtitle;
        private string _visualTitle;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string DashboardId
        {
            get { return this._dashboardId; }
            set { this._dashboardId = value; }
        }

        // Check to see if DashboardId property is set
        internal bool IsSetDashboardId()
        {
            return this._dashboardId != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardName. 
        /// <para>
        /// The name of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DashboardName
        {
            get { return this._dashboardName; }
            set { this._dashboardName = value; }
        }

        // Check to see if DashboardName property is set
        internal bool IsSetDashboardName()
        {
            return this._dashboardName != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardUrl. 
        /// <para>
        /// The URL of the dashboard.
        /// </para>
        /// </summary>
        public string DashboardUrl
        {
            get { return this._dashboardUrl; }
            set { this._dashboardUrl = value; }
        }

        // Check to see if DashboardUrl property is set
        internal bool IsSetDashboardUrl()
        {
            return this._dashboardUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SheetId. 
        /// <para>
        /// The ID of the sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string SheetId
        {
            get { return this._sheetId; }
            set { this._sheetId = value; }
        }

        // Check to see if SheetId property is set
        internal bool IsSetSheetId()
        {
            return this._sheetId != null;
        }

        /// <summary>
        /// Gets and sets the property SheetName. 
        /// <para>
        /// The name of the sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SheetName
        {
            get { return this._sheetName; }
            set { this._sheetName = value; }
        }

        // Check to see if SheetName property is set
        internal bool IsSetSheetName()
        {
            return this._sheetName != null;
        }

        /// <summary>
        /// Gets and sets the property VisualId. 
        /// <para>
        /// The ID of the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string VisualId
        {
            get { return this._visualId; }
            set { this._visualId = value; }
        }

        // Check to see if VisualId property is set
        internal bool IsSetVisualId()
        {
            return this._visualId != null;
        }

        /// <summary>
        /// Gets and sets the property VisualSubtitle. 
        /// <para>
        /// The subtitle of the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VisualSubtitle
        {
            get { return this._visualSubtitle; }
            set { this._visualSubtitle = value; }
        }

        // Check to see if VisualSubtitle property is set
        internal bool IsSetVisualSubtitle()
        {
            return this._visualSubtitle != null;
        }

        /// <summary>
        /// Gets and sets the property VisualTitle. 
        /// <para>
        /// The title of the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VisualTitle
        {
            get { return this._visualTitle; }
            set { this._visualTitle = value; }
        }

        // Check to see if VisualTitle property is set
        internal bool IsSetVisualTitle()
        {
            return this._visualTitle != null;
        }

    }
}