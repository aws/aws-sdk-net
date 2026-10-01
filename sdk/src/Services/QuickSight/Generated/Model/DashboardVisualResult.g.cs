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
    /// The QA result that is made from dashboard visual.
    /// </summary>
    public partial class DashboardVisualResult
    {
        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string DashboardId { get; set; }

        /// <summary>
        /// Checks to see if the DashboardId property is set.
        /// </summary>
        internal bool IsSetDashboardId() => this.DashboardId != null;

        /// <summary>
        /// Gets and sets the property DashboardName. 
        /// <para>
        /// The name of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DashboardName { get; set; }

        /// <summary>
        /// Checks to see if the DashboardName property is set.
        /// </summary>
        internal bool IsSetDashboardName() => this.DashboardName != null;

        /// <summary>
        /// Gets and sets the property DashboardUrl. 
        /// <para>
        /// The URL of the dashboard.
        /// </para>
        /// </summary>
        public string DashboardUrl { get; set; }

        /// <summary>
        /// Checks to see if the DashboardUrl property is set.
        /// </summary>
        internal bool IsSetDashboardUrl() => this.DashboardUrl != null;

        /// <summary>
        /// Gets and sets the property SheetId. 
        /// <para>
        /// The ID of the sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SheetId { get; set; }

        /// <summary>
        /// Checks to see if the SheetId property is set.
        /// </summary>
        internal bool IsSetSheetId() => this.SheetId != null;

        /// <summary>
        /// Gets and sets the property SheetName. 
        /// <para>
        /// The name of the sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SheetName { get; set; }

        /// <summary>
        /// Checks to see if the SheetName property is set.
        /// </summary>
        internal bool IsSetSheetName() => this.SheetName != null;

        /// <summary>
        /// Gets and sets the property VisualId. 
        /// <para>
        /// The ID of the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string VisualId { get; set; }

        /// <summary>
        /// Checks to see if the VisualId property is set.
        /// </summary>
        internal bool IsSetVisualId() => this.VisualId != null;

        /// <summary>
        /// Gets and sets the property VisualSubtitle. 
        /// <para>
        /// The subtitle of the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VisualSubtitle { get; set; }

        /// <summary>
        /// Checks to see if the VisualSubtitle property is set.
        /// </summary>
        internal bool IsSetVisualSubtitle() => this.VisualSubtitle != null;

        /// <summary>
        /// Gets and sets the property VisualTitle. 
        /// <para>
        /// The title of the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VisualTitle { get; set; }

        /// <summary>
        /// Checks to see if the VisualTitle property is set.
        /// </summary>
        internal bool IsSetVisualTitle() => this.VisualTitle != null;
    }
}
